using System;
using System.Collections.Generic;
using System.Linq;
using POOMeireRenzo.Dto;
using POOMeireRenzo.Interfaces;
using POOMeireRenzo.Model;
using POOMeireRenzo.Repository;

namespace POOMeireRenzo.Services
{
    public class PresupuestoService : IPresupuestoService
    {
        private readonly MenuRepository menuRepository;
        private readonly PresupuestoRepository presupuestoRepository;
        private static readonly Random random = new Random();

        public PresupuestoService()
        {
            this.menuRepository = MenuRepository.Instancia;
            this.presupuestoRepository = PresupuestoRepository.Instancia;
        }

        public (bool EsValido, string MensajeError) ValidarCliente(ClienteDto cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre) ||
                string.IsNullOrWhiteSpace(cliente.Documento) ||
                string.IsNullOrWhiteSpace(cliente.Telefono))
            {
                return (false, "Por favor, complete todos los campos antes de continuar.");
            }

            if (!long.TryParse(cliente.Documento, out _))
            {
                return (false, "El documento debe contener únicamente valores numéricos.");
            }

            if (!long.TryParse(cliente.Telefono, out _))
            {
                return (false, "El teléfono debe contener únicamente valores numéricos.");
            }

            return (true, string.Empty);
        }

        public List<MenuDto> ObtenerMenus()
        {
            return this.menuRepository.ObtenerTodos().ToList();
        }

        public List<LugarDto> ObtenerLugares()
        {
            return new List<LugarDto>
            {
                new LugarDto(1, "Salón Ismael", 2500000m),
                new LugarDto(2, "Salón Golondrinas", 2000000m),
                new LugarDto(3, "Salón Romeó", 3500000m),
                new LugarDto(4, "Salón OASIS", 4000000m)
            };
        }

        public List<ServicioAdicionalDto> ObtenerServiciosAdicionales()
        {
            return new List<ServicioAdicionalDto>
            {
                new ServicioAdicionalDto(1, "Extra carne", 15000m),
                new ServicioAdicionalDto(2, "Consumiciones extra", 30000m),
                new ServicioAdicionalDto(3, "Consumiciones ilimitadas", 70000m),
                new ServicioAdicionalDto(4, "Elegir canción", 30000m)
            };
        }

        public CalculoPresupuestoDto ProcesarCalculo(CalculoPresupuestoDto dto, LugarDto? lugarSeleccionado)
        {
            dto.TotalInvitados = dto.CantidadAdultos + dto.CantidadNinos;
            int sumaEspeciales = dto.Celiacos + dto.Vegetarianos + dto.Diabeticos;

            if (sumaEspeciales > dto.TotalInvitados)
            {
                dto.EsValido = false;
                dto.MensajeError = $"La cantidad de menús especiales no puede superar el total de invitados ({dto.TotalInvitados}).";
                dto.MenusEstandarRestantes = 0;
                dto.TotalEstimado = 0m;
                return dto;
            }

            dto.EsValido = true;
            dto.MenusEstandarRestantes = dto.TotalInvitados - sumaEspeciales;
            dto.TodosLosItemsCalculados.Clear();

            decimal totalCalculado = 0m;

            if (lugarSeleccionado != null && dto.Horas > 0)
            {
                decimal costoSalon = lugarSeleccionado.CostoBase * dto.Horas;
                totalCalculado += costoSalon;

                dto.TodosLosItemsCalculados.Add(new ItemPresupuestoDto(
                    "Salón",
                    $"{lugarSeleccionado.Nombre} ({dto.Horas} hs)",
                    1,
                    costoSalon,
                    costoSalon
                ));
            }

            IEnumerable<MenuDto> menus = this.ObtenerMenus();

            decimal cEstandar = ObtenerPrecioMenu(menus, TipoMenu.Estandar, 20000m);
            decimal cCeliaco = ObtenerPrecioMenu(menus, TipoMenu.Celiaco, 28000m);
            decimal cVegetariano = ObtenerPrecioMenu(menus, TipoMenu.Vegetariano, 17500m);
            decimal cDiabetico = ObtenerPrecioMenu(menus, TipoMenu.Diabetico, 19000m);

            if (dto.MenusEstandarRestantes > 0)
            {
                decimal sub = dto.MenusEstandarRestantes * cEstandar;
                totalCalculado += sub;
                dto.TodosLosItemsCalculados.Add(new ItemPresupuestoDto("Menú", "Menú Estándar", dto.MenusEstandarRestantes, cEstandar, sub));
            }

            if (dto.Celiacos > 0)
            {
                decimal sub = dto.Celiacos * cCeliaco;
                totalCalculado += sub;
                dto.TodosLosItemsCalculados.Add(new ItemPresupuestoDto("Menú", "Menú Celíaco", dto.Celiacos, cCeliaco, sub));
            }

            if (dto.Vegetarianos > 0)
            {
                decimal sub = dto.Vegetarianos * cVegetariano;
                totalCalculado += sub;
                dto.TodosLosItemsCalculados.Add(new ItemPresupuestoDto("Menú", "Menú Vegetariano", dto.Vegetarianos, cVegetariano, sub));
            }

            if (dto.Diabeticos > 0)
            {
                decimal sub = dto.Diabeticos * cDiabetico;
                totalCalculado += sub;
                dto.TodosLosItemsCalculados.Add(new ItemPresupuestoDto("Menú", "Menú Diabético", dto.Diabeticos, cDiabetico, sub));
            }

            foreach (ItemPresupuestoDto extra in dto.ExtrasAgregados)
            {
                totalCalculado += extra.Subtotal;
                dto.TodosLosItemsCalculados.Add(extra);
            }

            dto.TotalEstimado = totalCalculado;
            return dto;
        }

        public PresupuestoDto GuardarPresupuesto(ClienteDto cliente, CalculoPresupuestoDto dtoCalculado)
        {
            PresupuestoDto presupuesto = new PresupuestoDto
            {
                Id = random.Next(1000, 9999),
                Cliente = cliente,
                Total = dtoCalculado.TotalEstimado,
                Items = dtoCalculado.TodosLosItemsCalculados,
                Estado = EstadoPresupuesto.Pendiente
            };

            this.presupuestoRepository.Guardar(presupuesto);
            return presupuesto;
        }

        public PresupuestoDto CrearYGuardarPresupuesto(
            ClienteDto clienteDto,
            int lugarId,
            decimal duracionHoras,
            int cantidadAdultos,
            int cantidadNinos,
            List<ItemPresupuestoDto> itemsDto)
        {
            PresupuestoDto presupuesto = new PresupuestoDto
            {
                Id = random.Next(1000, 9999),
                Cliente = clienteDto,
                Total = itemsDto.Sum(i => i.Subtotal),
                Items = itemsDto,
                Estado = EstadoPresupuesto.Pendiente
            };

            this.presupuestoRepository.Guardar(presupuesto);
            return presupuesto;
        }

        private decimal ObtenerPrecioMenu(IEnumerable<MenuDto> menus, TipoMenu tipo, decimal defecto)
        {
            MenuDto? m = menus.FirstOrDefault(x => x.TipoMenu == tipo);
            return m != null ? m.CostoPorPersona : defecto;
        }
    }
}
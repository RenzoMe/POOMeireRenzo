using System;
using System.Collections.Generic;
using POOMeireRenzo.Dto;
using POOMeireRenzo.Model;
using POOMeireRenzo.Repository;

namespace POOMeireRenzo.Services
{
    public class PresupuestoService
    {
        private static readonly Random random = new Random();

        public PresupuestoService()
        {
            // Constructor vacío explícito
        }

        // Obtener lista de salones convertida a DTO para la Vista
        public List<SalonDto> ObtenerSalones()
        {
            List<Salon> salonesDominio = SalonRepository.Instancia.ObtenerTodos();
            List<SalonDto> salonesDto = new List<SalonDto>();

            foreach (Salon salon in salonesDominio)
            {
                SalonDto dto = new SalonDto(salon.Id, salon.Nombre, salon.PrecioBase, salon.PrecioPorHora);
                salonesDto.Add(dto);
            }

            return salonesDto;
        }

        // Validación del cliente usando ClienteDto
        public (bool EsValido, string MensajeError) ValidarCliente(ClienteDto clienteDto)
        {
            if (string.IsNullOrWhiteSpace(clienteDto.Nombre) ||
                string.IsNullOrWhiteSpace(clienteDto.Telefono) ||
                string.IsNullOrWhiteSpace(clienteDto.Correo))
            {
                return (false, "Por favor, complete todos los campos obligatorios del cliente (Nombre, Teléfono y Correo).");
            }

            if (!long.TryParse(clienteDto.Telefono, out long _))
            {
                return (false, "El teléfono debe contener únicamente valores numéricos.");
            }

            return (true, string.Empty);
        }

        // Procesamiento centralizado mediante Request DTO y mapeo a modelos de dominio
        public PresupuestoDto CalcularYCrearPresupuesto(CrearPresupuestoRequestDto request)
        {
            // Mapeo DTO de entrada -> Modelos de Dominio
            Cliente cliente = new Cliente(request.Cliente.Nombre, request.Cliente.Telefono, request.Cliente.Correo);
            Salon salon = new Salon(request.SalonSeleccionado.Id, request.SalonSeleccionado.Nombre, request.SalonSeleccionado.PrecioBase, request.SalonSeleccionado.PrecioPorHora);

            MenuNormal menuNormal = new MenuNormal(
                request.MenuNormal.PlatoPrincipal,
                request.MenuNormal.PrecioPlato,
                request.MenuNormal.Bebida,
                request.MenuNormal.PrecioBebida,
                request.MenuNormal.Postre,
                request.MenuNormal.PrecioPostre
            );

            List<MenuEspecial> listaEspeciales = new List<MenuEspecial>();
            foreach (MenuEspecialDto espDto in request.ListaEspeciales)
            {
                MenuEspecial especial = new MenuEspecial(espDto.Tipo, espDto.Nombre, espDto.Precio, espDto.Cantidad);
                listaEspeciales.Add(especial);
            }

            List<ServicioExtra> listaExtras = new List<ServicioExtra>();
            foreach (ServicioExtraDto extDto in request.ListaExtras)
            {
                ServicioExtra extra = new ServicioExtra(extDto.Nombre, extDto.Precio, extDto.Cantidad);
                listaExtras.Add(extra);
            }

            int totalInvitados = request.CantidadAdultos + request.CantidadNinos;
            List<ItemPresupuesto> itemsCalculados = new List<ItemPresupuesto>();
            decimal totalGeneral = 0m;

            // A. Cálculo del Salón
            decimal costoSalon = salon.PrecioBase + (request.Horas * salon.PrecioPorHora);
            totalGeneral += costoSalon;

            ItemPresupuesto itemSalon = new ItemPresupuesto(
                "Salón",
                salon.Nombre + " (" + request.Horas.ToString() + " horas)",
                1,
                costoSalon,
                costoSalon
            );
            itemsCalculados.Add(itemSalon);
            ItemPresupuestoRepository.Instancia.Guardar(itemSalon);

            // B. Validación de Menús Especiales
            int totalEspeciales = 0;
            foreach (MenuEspecial especial in listaEspeciales)
            {
                totalEspeciales += especial.Cantidad;
            }

            if (totalEspeciales > totalInvitados)
            {
                throw new Exception("La cantidad de menús especiales no puede superar el total de invitados (" + totalInvitados.ToString() + ").");
            }

            // C. Cálculo del Menú Normal
            int totalMenusNormales = totalInvitados - totalEspeciales;
            decimal costoUnitarioMenuNormal = menuNormal.CostoTotalPorPersona;

            if (totalMenusNormales > 0)
            {
                decimal subtotalNormal = totalMenusNormales * costoUnitarioMenuNormal;
                totalGeneral += subtotalNormal;

                string descripcionMenu = "Menú Normal (Plato: " + menuNormal.PlatoPrincipal + " | Bebida: " + menuNormal.Bebida + " | Postre: " + menuNormal.Postre + ")";

                ItemPresupuesto itemNormal = new ItemPresupuesto(
                    "Menú",
                    descripcionMenu,
                    totalMenusNormales,
                    costoUnitarioMenuNormal,
                    subtotalNormal
                );
                itemsCalculados.Add(itemNormal);
                ItemPresupuestoRepository.Instancia.Guardar(itemNormal);
            }

            // D. Inclusión de Menús Especiales
            foreach (MenuEspecial especial in listaEspeciales)
            {
                if (especial.Cantidad > 0)
                {
                    decimal subtotalEspecial = especial.Subtotal;
                    totalGeneral += subtotalEspecial;

                    ItemPresupuesto itemEspecial = new ItemPresupuesto(
                        "Menú Especial",
                        especial.Tipo + ": " + especial.Nombre,
                        especial.Cantidad,
                        especial.Precio,
                        subtotalEspecial
                    );
                    itemsCalculados.Add(itemEspecial);
                    ItemPresupuestoRepository.Instancia.Guardar(itemEspecial);
                }
            }

            // E. Inclusión de Servicios Extra
            foreach (ServicioExtra extra in listaExtras)
            {
                if (extra.Cantidad > 0)
                {
                    decimal subtotalExtra = extra.Subtotal;
                    totalGeneral += subtotalExtra;

                    ItemPresupuesto itemExtra = new ItemPresupuesto(
                        "Servicio Extra",
                        extra.Nombre,
                        extra.Cantidad,
                        extra.Precio,
                        subtotalExtra
                    );
                    itemsCalculados.Add(itemExtra);
                    ItemPresupuestoRepository.Instancia.Guardar(itemExtra);
                }
            }

            // F. Creación del Presupuesto de dominio
            int idGenerado = random.Next(1000, 9999);
            Presupuesto nuevoPresupuesto = new Presupuesto(
                idGenerado,
                cliente,
                salon,
                request.CantidadAdultos,
                request.CantidadNinos,
                request.Horas,
                itemsCalculados,
                totalGeneral
            );

            // G. Persistencia en los repositorios dedicados
            ClienteRepository.Instancia.Guardar(cliente);
            MenuNormalRepository.Instancia.Guardar(menuNormal);
            foreach (MenuEspecial especial in listaEspeciales)
            {
                MenuEspecialRepository.Instancia.Guardar(especial);
            }
            foreach (ServicioExtra extra in listaExtras)
            {
                ServicioExtraRepository.Instancia.Guardar(extra);
            }
            PresupuestoRepository.Instancia.Guardar(nuevoPresupuesto);

            // Mapeo inverso: Modelo de Dominio -> PresupuestoDto para la Vista
            List<ItemPresupuestoDto> itemsDto = new List<ItemPresupuestoDto>();
            foreach (ItemPresupuesto ip in itemsCalculados)
            {
                ItemPresupuestoDto ipDto = new ItemPresupuestoDto(ip.Categoria, ip.Descripcion, ip.Cantidad, ip.PrecioUnitario, ip.Subtotal);
                itemsDto.Add(ipDto);
            }

            ClienteDto clienteDtoRespuesta = new ClienteDto(cliente.Nombre, cliente.Telefono, cliente.Correo);
            SalonDto salonDtoRespuesta = new SalonDto(salon.Id, salon.Nombre, salon.PrecioBase, salon.PrecioPorHora);

            PresupuestoDto presupuestoDtoFinal = new PresupuestoDto(
                nuevoPresupuesto.Id,
                clienteDtoRespuesta,
                salonDtoRespuesta,
                nuevoPresupuesto.CantidadAdultos,
                nuevoPresupuesto.CantidadNinos,
                nuevoPresupuesto.Horas,
                itemsDto,
                nuevoPresupuesto.Total
            );

            return presupuestoDtoFinal;
        }

        // Obtener todos los presupuestos convertidos a DTO
        public List<PresupuestoDto> ObtenerTodos()
        {
            List<Presupuesto> listaDominio = PresupuestoRepository.Instancia.ObtenerTodos();
            List<PresupuestoDto> listaDto = new List<PresupuestoDto>();

            foreach (Presupuesto p in listaDominio)
            {
                ClienteDto cDto = new ClienteDto(p.Cliente.Nombre, p.Cliente.Telefono, p.Cliente.Correo);
                SalonDto sDto = new SalonDto(p.Salon.Id, p.Salon.Nombre, p.Salon.PrecioBase, p.Salon.PrecioPorHora);

                List<ItemPresupuestoDto> itemsDto = new List<ItemPresupuestoDto>();
                foreach (ItemPresupuesto ip in p.Items)
                {
                    ItemPresupuestoDto ipDto = new ItemPresupuestoDto(ip.Categoria, ip.Descripcion, ip.Cantidad, ip.PrecioUnitario, ip.Subtotal);
                    itemsDto.Add(ipDto);
                }

                PresupuestoDto pDto = new PresupuestoDto(p.Id, cDto, sDto, p.CantidadAdultos, p.CantidadNinos, p.Horas, itemsDto, p.Total);
                listaDto.Add(pDto);
            }

            return listaDto;
        }
    }
}
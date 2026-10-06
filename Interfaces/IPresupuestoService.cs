using System;
using System.Collections.Generic;
using System.Text;
using POOMeireRenzo.Dto;
using Menu = POOMeireRenzo.Model.Menu;

namespace POOMeireRenzo.Interfaces
{
    public interface IPresupuestoService
    {
        List<LugarDto> ObtenerLugares();
        List<MenuDto> ObtenerMenus();
        List<ServicioAdicionalDto> ObtenerServiciosAdicionales();

        PresupuestoDto CrearYGuardarPresupuesto(
            ClienteDto clienteDto,
            int lugarId,
            decimal duracionHoras,
            int cantidadAdultos,
            int cantidadNinos,
            List<ItemPresupuestoDto> itemsDto
        );
    }
}
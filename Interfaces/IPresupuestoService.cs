using System.Collections.Generic;
using POOMeireRenzo.Model;

namespace POOMeireRenzo.Interfaces
{
    public interface IPresupuestoService
    {
        (bool EsValido, string MensajeError) ValidarCliente(Cliente cliente);

        Presupuesto CalcularYCrearPresupuesto(
            Cliente cliente,
            Salon salonSeleccionado,
            decimal horas,
            int cantidadAdultos,
            int cantidadNinos,
            MenuNormal menuNormal,
            List<MenuEspecial> listaEspeciales,
            List<ServicioExtra> listaExtras
        );
    }
}
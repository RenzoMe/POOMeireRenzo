using POOMeireRenzo.Model;
using Menu = POOMeireRenzo.Model.Menu;

namespace POOMeireRenzo.Interfaces
{
    public interface IPresupuestoRepository
    {
        void GuardarCliente(Cliente cliente);
        Cliente ObtenerClientePorDocumento(string documento);

        void GuardarPresupuesto(Presupuesto presupuesto);
        List<Presupuesto> ObtenerPresupuestos();
        Presupuesto ObtenerPresupuestoPorId(int id);

        List<Lugar> ObtenerLugares();
        List<Menu> ObtenerMenus();
        List<ServicioAdicional> ObtenerServiciosAdicionales();
    }
}
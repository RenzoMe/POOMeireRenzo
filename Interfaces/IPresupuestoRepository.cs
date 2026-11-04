using System.Collections.Generic;
using POOMeireRenzo.Model;

namespace POOMeireRenzo.Interfaces
{
    public interface IPresupuestoRepository
    {
        void Guardar(Presupuesto presupuesto);
        List<Presupuesto> ObtenerTodos();
    }
}
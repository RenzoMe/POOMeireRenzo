using System.Collections.Generic;
using POOMeireRenzo.Model;

namespace POOMeireRenzo.Repository
{
    public class PresupuestoRepository
    {
        private static PresupuestoRepository? instancia;
        public static PresupuestoRepository Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new PresupuestoRepository();
                }
                return instancia;
            }
        }

        private List<Presupuesto> listaPresupuestos;

        private PresupuestoRepository()
        {
            this.listaPresupuestos = new List<Presupuesto>();
        }

        public void Guardar(Presupuesto presupuesto)
        {
            this.listaPresupuestos.Add(presupuesto);
        }

        public List<Presupuesto> ObtenerTodos()
        {
            return this.listaPresupuestos;
        }
    }
}
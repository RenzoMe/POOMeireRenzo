using System.Collections.Generic;
using POOMeireRenzo.Dto;

namespace POOMeireRenzo.Repository
{
    public class PresupuestoRepository
    {
        private static PresupuestoRepository? instancia;
        private readonly List<PresupuestoDto> listaPresupuestosGuardados;

        private PresupuestoRepository()
        {
            this.listaPresupuestosGuardados = new List<PresupuestoDto>();
        }

        public static PresupuestoRepository Instancia => instancia ??= new PresupuestoRepository();

        public void Guardar(PresupuestoDto presupuesto)
        {
            this.listaPresupuestosGuardados.Add(presupuesto);
        }

        public IEnumerable<PresupuestoDto> ObtenerTodos()
        {
            return this.listaPresupuestosGuardados.AsReadOnly();
        }
    }
}
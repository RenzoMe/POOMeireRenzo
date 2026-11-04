using System.Collections.Generic;
using POOMeireRenzo.Model;

namespace POOMeireRenzo.Repository
{
    public class ItemPresupuestoRepository
    {
        private static ItemPresupuestoRepository? instancia;
        public static ItemPresupuestoRepository Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ItemPresupuestoRepository();
                }
                return instancia;
            }
        }

        private List<ItemPresupuesto> listaItems;

        private ItemPresupuestoRepository()
        {
            this.listaItems = new List<ItemPresupuesto>();
        }

        public void Guardar(ItemPresupuesto item)
        {
            this.listaItems.Add(item);
        }

        public List<ItemPresupuesto> ObtenerTodos()
        {
            return this.listaItems;
        }
    }
}
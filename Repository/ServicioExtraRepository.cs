using System.Collections.Generic;
using POOMeireRenzo.Model;

namespace POOMeireRenzo.Repository
{
    public class ServicioExtraRepository
    {
        private static ServicioExtraRepository? instancia;
        public static ServicioExtraRepository Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ServicioExtraRepository();
                }
                return instancia;
            }
        }

        private List<ServicioExtra> listaExtras;

        private ServicioExtraRepository()
        {
            this.listaExtras = new List<ServicioExtra>();
        }

        public void Guardar(ServicioExtra extra)
        {
            this.listaExtras.Add(extra);
        }

        public List<ServicioExtra> ObtenerTodos()
        {
            return this.listaExtras;
        }
    }
}
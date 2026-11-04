using System.Collections.Generic;
using POOMeireRenzo.Model;

namespace POOMeireRenzo.Repository
{
    public class ClienteRepository
    {
        private static ClienteRepository? instancia;
        public static ClienteRepository Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ClienteRepository();
                }
                return instancia;
            }
        }

        private List<Cliente> listaClientes;

        private ClienteRepository()
        {
            this.listaClientes = new List<Cliente>();
        }

        public void Guardar(Cliente cliente)
        {
            this.listaClientes.Add(cliente);
        }

        public List<Cliente> ObtenerTodos()
        {
            return this.listaClientes;
        }
    }
}
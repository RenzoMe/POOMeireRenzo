using System.Collections.Generic;
using POOMeireRenzo.Model;

namespace POOMeireRenzo.Repository
{
    public class MenuEspecialRepository
    {
        private static MenuEspecialRepository? instancia;
        public static MenuEspecialRepository Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new MenuEspecialRepository();
                }
                return instancia;
            }
        }

        private List<MenuEspecial> listaMenuEspeciales;

        private MenuEspecialRepository()
        {
            this.listaMenuEspeciales = new List<MenuEspecial>();
        }

        public void Guardar(MenuEspecial menuEspecial)
        {
            this.listaMenuEspeciales.Add(menuEspecial);
        }

        public List<MenuEspecial> ObtenerTodos()
        {
            return this.listaMenuEspeciales;
        }
    }
}
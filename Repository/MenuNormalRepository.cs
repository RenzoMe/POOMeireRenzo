using POOMeireRenzo.Model;

namespace POOMeireRenzo.Repository
{
    public class MenuNormalRepository
    {
        private static MenuNormalRepository? instancia;
        public static MenuNormalRepository Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new MenuNormalRepository();
                }
                return instancia;
            }
        }

        private MenuNormal menuActual;

        private MenuNormalRepository()
        {
            // Menú normal por defecto
            this.menuActual = new MenuNormal("Asado con ensalada", 15000m, "Vino / Gaseosa", 5000m, "Flan casero", 4000m);
        }

        public MenuNormal ObtenerMenu()
        {
            return this.menuActual;
        }

        public void Guardar(MenuNormal menu)
        {
            this.menuActual = menu;
        }
    }
}
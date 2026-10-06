using POOMeireRenzo.Model;

namespace POOMeireRenzo.Dto
{
    public class MenuDto
    {
        private int id;
        private string nombre = string.Empty;
        private TipoMenu tipoMenu; 
        private decimal costoPorPersona;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public TipoMenu TipoMenu
        {
            get { return this.tipoMenu; }
            set { this.tipoMenu = value; }
        }

        public decimal CostoPorPersona
        {
            get { return this.costoPorPersona; }
            set { this.costoPorPersona = value; }
        }

        public MenuDto() { }

        public MenuDto(int id, string nombre, TipoMenu tipoMenu, decimal costoPorPersona)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipoMenu = tipoMenu;
            this.costoPorPersona = costoPorPersona;
        }
    }
}
namespace POOMeireRenzo.Dto
{
    public class MenuNormalDto
    {
        private string platoPrincipal = string.Empty;
        private decimal precioPlato;
        private string bebida = string.Empty;
        private decimal precioBebida;
        private string postre = string.Empty;
        private decimal precioPostre;

        public string PlatoPrincipal
        {
            get { return this.platoPrincipal; }
            set { this.platoPrincipal = value; }
        }

        public decimal PrecioPlato
        {
            get { return this.precioPlato; }
            set { this.precioPlato = value; }
        }

        public string Bebida
        {
            get { return this.bebida; }
            set { this.bebida = value; }
        }

        public decimal PrecioBebida
        {
            get { return this.precioBebida; }
            set { this.precioBebida = value; }
        }

        public string Postre
        {
            get { return this.postre; }
            set { this.postre = value; }
        }

        public decimal PrecioPostre
        {
            get { return this.precioPostre; }
            set { this.precioPostre = value; }
        }

        public MenuNormalDto() { }

        public MenuNormalDto(string platoPrincipal, decimal precioPlato, string bebida, decimal precioBebida, string postre, decimal precioPostre)
        {
            this.platoPrincipal = platoPrincipal;
            this.precioPlato = precioPlato;
            this.bebida = bebida;
            this.precioBebida = precioBebida;
            this.postre = postre;
            this.precioPostre = precioPostre;
        }
    }
}
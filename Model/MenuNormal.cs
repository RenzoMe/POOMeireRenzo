namespace POOMeireRenzo.Model
{
    public class MenuNormal
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

        public decimal CostoTotalPorPersona
        {
            get
            {
                return this.precioPlato + this.precioBebida + this.precioPostre;
            }
        }

        public MenuNormal() { }

        public MenuNormal(string plato, decimal pPlato, string bebida, decimal pBebida, string postre, decimal pPostre)
        {
            this.platoPrincipal = plato;
            this.precioPlato = pPlato;
            this.bebida = bebida;
            this.precioBebida = pBebida;
            this.postre = postre;
            this.precioPostre = pPostre;
        }
    }
}
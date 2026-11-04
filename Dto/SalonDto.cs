namespace POOMeireRenzo.Dto
{
    public class SalonDto
    {
        private int id;
        private string nombre = string.Empty;
        private decimal precioBase;
        private decimal precioPorHora;

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

        public decimal PrecioBase
        {
            get { return this.precioBase; }
            set { this.precioBase = value; }
        }

        public decimal PrecioPorHora
        {
            get { return this.precioPorHora; }
            set { this.precioPorHora = value; }
        }

        public SalonDto() { }

        public SalonDto(int id, string nombre, decimal precioBase, decimal precioPorHora)
        {
            this.id = id;
            this.nombre = nombre;
            this.precioBase = precioBase;
            this.precioPorHora = precioPorHora;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
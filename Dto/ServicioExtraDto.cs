namespace POOMeireRenzo.Dto
{
    public class ServicioExtraDto
    {
        private string nombre = string.Empty;
        private decimal precio;
        private int cantidad;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public decimal Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public ServicioExtraDto() { }

        public ServicioExtraDto(string nombre, decimal precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
    }
}
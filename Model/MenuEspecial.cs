namespace POOMeireRenzo.Model
{
    public class MenuEspecial
    {
        private string tipo = string.Empty; // Ej: Celíaco, Vegetariano, Diabético
        private string nombre = string.Empty;
        private decimal precio;
        private int cantidad;

        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

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

        public decimal Subtotal
        {
            get { return this.precio * this.cantidad; }
        }

        public MenuEspecial() { }

        public MenuEspecial(string tipo, string nombre, decimal precio, int cantidad)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
    }
}
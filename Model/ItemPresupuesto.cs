namespace POOMeireRenzo.Model
{
    public class ItemPresupuesto
    {
        private string categoria = string.Empty;
        private string descripcion = string.Empty;
        private int cantidad;
        private decimal precioUnitario;
        private decimal subtotal;

        public string Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public decimal PrecioUnitario
        {
            get { return this.precioUnitario; }
            set { this.precioUnitario = value; }
        }

        public decimal Subtotal
        {
            get { return this.subtotal; }
            set { this.subtotal = value; }
        }

        public ItemPresupuesto() { }

        public ItemPresupuesto(string categoria, string descripcion, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
            this.subtotal = subtotal;
        }
    }
}
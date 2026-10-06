namespace POOMeireRenzo.Dto
{
    public class ItemPresupuestoDto
    {
        private string tipo = string.Empty;
        private string descripcion = string.Empty;
        private int cantidad;
        private decimal precioUnitario;
        private decimal subtotal;

        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
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

        public ItemPresupuestoDto() { }

        public ItemPresupuestoDto(string tipo, string descripcion, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
            this.subtotal = subtotal;
        }
    }
}
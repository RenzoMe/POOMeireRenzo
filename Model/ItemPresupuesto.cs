namespace POOMeireRenzo.Model
{
    public class ItemPresupuesto
    {
        private int id;
        private string descripcion = string.Empty;
        private int cantidad;
        private decimal precioUnitario;
        private Menu? menu;
        private ServicioAdicional? servicioAdicional;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
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

        public Menu? Menu
        {
            get { return this.menu; }
            set { this.menu = value; }
        }

        public ServicioAdicional? ServicioAdicional
        {
            get { return this.servicioAdicional; }
            set { this.servicioAdicional = value; }
        }

        public ItemPresupuesto() { }

        public ItemPresupuesto(int id, Menu menu, int cantidad)
        {
            this.id = id;
            this.menu = menu;
            this.cantidad = cantidad;
            this.descripcion = menu != null ? menu.Nombre : string.Empty;
            this.precioUnitario = menu != null ? menu.CostoPorPersona : 0m;
        }

        public ItemPresupuesto(int id, ServicioAdicional servicioAdicional, int cantidad)
        {
            this.id = id;
            this.servicioAdicional = servicioAdicional;
            this.cantidad = cantidad;
            this.descripcion = servicioAdicional != null ? servicioAdicional.Nombre : string.Empty;
            this.precioUnitario = servicioAdicional != null ? servicioAdicional.MontoFijo : 0m;
        }

        public decimal CalcularSubtotal()
        {
            return this.cantidad * this.precioUnitario;
        }
    }
}
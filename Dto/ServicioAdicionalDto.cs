namespace POOMeireRenzo.Dto
{
    public class ServicioAdicionalDto
    {
        private int id;
        private string nombre = string.Empty;
        private decimal montoFijo;

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
        public decimal MontoFijo
        {
            get { return this.montoFijo; }
            set { this.montoFijo = value; }
        }

        public ServicioAdicionalDto() { }

        public ServicioAdicionalDto(int id, string nombre, decimal montoFijo)
        {
            this.id = id;
            this.nombre = nombre;
            this.montoFijo = montoFijo;
        }

        public override string ToString()
        {
            return $"{this.nombre} (${this.montoFijo:N0})";
        }
    }
}
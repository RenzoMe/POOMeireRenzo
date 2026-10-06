namespace POOMeireRenzo.Dto
{
    public class LugarDto
    {
        private int id;
        private string nombre = string.Empty;
        private decimal costoBase;

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
        public decimal CostoBase
        {
            get { return this.costoBase; }
            set { this.costoBase = value; }
        }

        public LugarDto() { }

        public LugarDto(int id, string nombre, decimal costoBase)
        {
            this.id = id;
            this.nombre = nombre;
            this.costoBase = costoBase;
        }

        public override string ToString()
        {
            return $"{this.nombre} (${this.costoBase:N0}/hora)";
        }
    }
}
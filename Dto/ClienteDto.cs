namespace POOMeireRenzo.Dto
{
    public class ClienteDto
    {
        private int id;
        private string nombre = string.Empty;
        private string documento = string.Empty;
        private string telefono = string.Empty;

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
        public string Documento
        {
            get { return this.documento; }
            set { this.documento = value; }
        }
        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public ClienteDto() { }

        public ClienteDto(string nombre, string documento, string telefono = "")
        {
            this.nombre = nombre;
            this.documento = documento;
            this.telefono = telefono;
        }

        public ClienteDto(int id, string nombre, string documento, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.documento = documento;
            this.telefono = telefono;
        }
    }
}
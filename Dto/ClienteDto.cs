namespace POOMeireRenzo.Dto
{
    public class ClienteDto
    {
        private string nombre = string.Empty;
        private string telefono = string.Empty;
        private string correo = string.Empty;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }

        private string documento = string.Empty;
        public string Documento
        {
            get { return this.documento; }
            set { this.documento = value; }
        }

        public ClienteDto() { }

        public ClienteDto(string nombre, string telefono, string correo)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}
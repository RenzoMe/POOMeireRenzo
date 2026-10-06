using System;
using System.Collections.Generic;
using System.Text;

namespace POOMeireRenzo.Model
{
    public class Cliente
    {
        private int id;
        private string nombre = string.Empty;
        private string tel = string.Empty;
        private string documento = string.Empty;

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
        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }
        public string Documento
        {
            get { return this.documento; }
            set { this.documento = value; }
        }

        public Cliente() { }

        public Cliente(int id, string nombre, string tel, string documento)
        {
            this.id = id;
            this.nombre = nombre;
            this.tel = tel;
            this.documento = documento;
        }
    }
}
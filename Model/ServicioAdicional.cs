using System;
using System.Collections.Generic;
using System.Text;
using POOMeireRenzo.Interfaces;


namespace POOMeireRenzo.Model
{
    public class ServicioAdicional
    {
        private int id;
        private string nombre;
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

        public ServicioAdicional() { }

        public ServicioAdicional(int id, string nombre, decimal montoFijo)
        {
            this.id = id;
            this.nombre = nombre;
            this.montoFijo = montoFijo;
        }
    }
}
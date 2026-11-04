using System.Collections.Generic;

namespace POOMeireRenzo.Model
{
    public class Presupuesto
    {
        private int id;
        private Cliente cliente = new Cliente();
        private Salon salon = new Salon();
        private int cantidadAdultos;
        private int cantidadNinos;
        private decimal horas;
        private List<ItemPresupuesto> items = new List<ItemPresupuesto>();
        private decimal total;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }

        public Salon Salon
        {
            get { return this.salon; }
            set { this.salon = value; }
        }

        public int CantidadAdultos
        {
            get { return this.cantidadAdultos; }
            set { this.cantidadAdultos = value; }
        }

        public int CantidadNinos
        {
            get { return this.cantidadNinos; }
            set { this.cantidadNinos = value; }
        }

        public decimal Horas
        {
            get { return this.horas; }
            set { this.horas = value; }
        }

        public List<ItemPresupuesto> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }

        public decimal Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        public Presupuesto() { }

        public Presupuesto(int id, Cliente cliente, Salon salon, int adultos, int ninos, decimal horas, List<ItemPresupuesto> items, decimal total)
        {
            this.id = id;
            this.cliente = cliente;
            this.salon = salon;
            this.cantidadAdultos = adultos;
            this.cantidadNinos = ninos;
            this.horas = horas;
            this.items = items;
            this.total = total;
        }
    }
}
using System;
using System.Collections.Generic;

namespace POOMeireRenzo.Model
{
    public class Presupuesto
    {
        private int id;
        private Cliente cliente;
        private Lugar lugar;
        private DateTime fecha;
        private EstadoPresupuesto estado;
        private decimal duracionHoras;
        private int cantidadAdultos;
        private int cantidadNinos;
        private List<ItemPresupuesto> items;

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

        public Lugar Lugar
        {
            get { return this.lugar; }
            set { this.lugar = value; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public EstadoPresupuesto Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public decimal DuracionHoras
        {
            get { return this.duracionHoras; }
            set { this.duracionHoras = value; }
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

        public List<ItemPresupuesto> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }

        public Presupuesto()
        {
            this.cliente = new Cliente();
            this.lugar = new Lugar();
            this.items = new List<ItemPresupuesto>();
            this.fecha = DateTime.Now;
            this.estado = EstadoPresupuesto.Pendiente;
        }

        public Presupuesto(int id, Cliente cliente, Lugar lugar, decimal duracionHoras, int cantidadAdultos, int cantidadNinos)
        {
            this.id = id;
            this.cliente = cliente;
            this.lugar = lugar;
            this.duracionHoras = duracionHoras;
            this.cantidadAdultos = cantidadAdultos;
            this.cantidadNinos = cantidadNinos;
            this.fecha = DateTime.Now;
            this.estado = EstadoPresupuesto.Pendiente;
            this.items = new List<ItemPresupuesto>();
        }

        public void AgregarItem(ItemPresupuesto item)
        {
            if (item != null)
            {
                this.items.Add(item);
            }
        }

        public decimal CalcularTotalFinal()
        {
            decimal totalFinal = 0m;

            if (this.lugar != null)
            {
                totalFinal += (this.lugar.CostoBase * this.duracionHoras);
            }

            foreach (ItemPresupuesto item in this.items)
            {
                totalFinal += item.CalcularSubtotal();
            }

            return totalFinal;
        }
    }
}
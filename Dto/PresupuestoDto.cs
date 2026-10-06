using System.Collections.Generic;
using POOMeireRenzo.Model;

namespace POOMeireRenzo.Dto
{
    public class PresupuestoDto
    {
        private int id;
        private ClienteDto cliente = new ClienteDto();
        private decimal total;
        private List<ItemPresupuestoDto> items = new List<ItemPresupuestoDto>();
        private EstadoPresupuesto estado = EstadoPresupuesto.Pendiente;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public ClienteDto Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }

        public decimal Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        public List<ItemPresupuestoDto> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }

        public EstadoPresupuesto Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public PresupuestoDto() { }

        public PresupuestoDto(int id, ClienteDto cliente, decimal total, List<ItemPresupuestoDto> items, EstadoPresupuesto estado = EstadoPresupuesto.Pendiente)
        {
            this.id = id;
            this.cliente = cliente;
            this.total = total;
            this.items = items;
            this.estado = estado;
        }
    }
}
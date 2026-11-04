using System.Collections.Generic;

namespace POOMeireRenzo.Dto
{
    public class PresupuestoDto
    {
        private int id;
        private ClienteDto cliente = new ClienteDto();
        private SalonDto salon = new SalonDto();
        private int cantidadAdultos;
        private int cantidadNinos;
        private decimal horas;
        private List<ItemPresupuestoDto> items = new List<ItemPresupuestoDto>();
        private decimal total;

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

        public SalonDto Salon
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

        public List<ItemPresupuestoDto> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }

        public decimal Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        public PresupuestoDto() { }

        public PresupuestoDto(int id, ClienteDto cliente, SalonDto salon, int adultos, int ninos, decimal horas, List<ItemPresupuestoDto> items, decimal total)
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
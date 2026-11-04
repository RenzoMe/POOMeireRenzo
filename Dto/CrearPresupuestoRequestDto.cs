using System.Collections.Generic;

namespace POOMeireRenzo.Dto
{
    public class CrearPresupuestoRequestDto
    {
        private ClienteDto cliente = new ClienteDto();
        private SalonDto salonSeleccionado = new SalonDto();
        private decimal horas;
        private int cantidadAdultos;
        private int cantidadNinos;
        private MenuNormalDto menuNormal = new MenuNormalDto();
        private List<MenuEspecialDto> listaEspeciales = new List<MenuEspecialDto>();
        private List<ServicioExtraDto> listaExtras = new List<ServicioExtraDto>();

        public ClienteDto Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }

        public SalonDto SalonSeleccionado
        {
            get { return this.salonSeleccionado; }
            set { this.salonSeleccionado = value; }
        }

        public decimal Horas
        {
            get { return this.horas; }
            set { this.horas = value; }
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

        public MenuNormalDto MenuNormal
        {
            get { return this.menuNormal; }
            set { this.menuNormal = value; }
        }

        public List<MenuEspecialDto> ListaEspeciales
        {
            get { return this.listaEspeciales; }
            set { this.listaEspeciales = value; }
        }

        public List<ServicioExtraDto> ListaExtras
        {
            get { return this.listaExtras; }
            set { this.listaExtras = value; }
        }

        public CrearPresupuestoRequestDto() { }
    }
}
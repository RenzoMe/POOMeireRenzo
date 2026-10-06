using System.Collections.Generic;

namespace POOMeireRenzo.Dto
{
    public class CalculoPresupuestoDto
    {
        private int lugarId;
        private decimal horas;
        private int cantidadAdultos;
        private int cantidadNinos;
        private int celiacos;
        private int vegetarianos;
        private int diabeticos;
        private List<ItemPresupuestoDto> extrasAgregados;
        private int totalInvitados;
        private int menusEstandarRestantes;
        private decimal totalEstimado;
        private bool esValido;
        private string mensajeError;
        private List<ItemPresupuestoDto> todosLosItemsCalculados;

        public int LugarId
        {
            get { return this.lugarId; }
            set { this.lugarId = value; }
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
        public int Celiacos
        {
            get { return this.celiacos; }
            set { this.celiacos = value; }
        }
        public int Vegetarianos
        {
            get { return this.vegetarianos; }
            set { this.vegetarianos = value; }
        }
        public int Diabeticos
        {
            get { return this.diabeticos; }
            set { this.diabeticos = value; }
        }
        public List<ItemPresupuestoDto> ExtrasAgregados
        {
            get { return this.extrasAgregados; }
            set { this.extrasAgregados = value; }
        }
        public int TotalInvitados
        {
            get { return this.totalInvitados; }
            set { this.totalInvitados = value; }
        }
        public int MenusEstandarRestantes
        {
            get { return this.menusEstandarRestantes; }
            set { this.menusEstandarRestantes = value; }
        }
        public decimal TotalEstimado
        {
            get { return this.totalEstimado; }
            set { this.totalEstimado = value; }
        }
        public bool EsValido
        {
            get { return this.esValido; }
            set { this.esValido = value; }
        }
        public string MensajeError
        {
            get { return this.mensajeError; }
            set { this.mensajeError = value; }
        }

        public List<ItemPresupuestoDto> TodosLosItemsCalculados
        {
            get { return this.todosLosItemsCalculados; }
            set { this.todosLosItemsCalculados = value; }
        }

        public CalculoPresupuestoDto()
        {
            this.extrasAgregados = new List<ItemPresupuestoDto>();
            this.todosLosItemsCalculados = new List<ItemPresupuestoDto>();
            this.mensajeError = string.Empty;
            this.esValido = true;
        }
    }
}
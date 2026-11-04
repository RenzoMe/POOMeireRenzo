using System;
using System.Collections.Generic;
using System.Windows.Forms;
using POOMeireRenzo.Dto;
using POOMeireRenzo.Services;

namespace POOMeireRenzo.View
{
    public partial class FormConsultaPresupuestos : Form
    {
        private readonly PresupuestoService presupuestoService;

        public FormConsultaPresupuestos()
        {
            InitializeComponent();
            this.presupuestoService = new PresupuestoService();
        }

        private void FormConsultaPresupuestos_Load(object sender, EventArgs e)
        {
            // Al cargar la ventana, mostramos todos los presupuestos existentes en el sistema
            this.CargarListaPresupuestos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.AbrirCreacionCliente();
        }

        private void crearCiente_Click(object sender, EventArgs e)
        {
            this.AbrirCreacionCliente();
        }

        private void AbrirCreacionCliente()
        {
            // Ocultamos temporalmente la consulta para abrir el flujo de creación (Pantalla 1: Cliente)
            this.Hide();

            using (FormCliente formCliente = new FormCliente())
            {
                formCliente.ShowDialog();
            }

            // Al volver, actualizamos la grilla para reflejar los nuevos presupuestos creados
            this.CargarListaPresupuestos();
            this.Show();
        }

        public void CargarListaPresupuestos()
        {
            // Obtenemos todos los presupuestos en formato DTO desde el servicio
            List<PresupuestoDto> listaPresupuestos = this.presupuestoService.ObtenerTodos();

            List<PresupuestoDto> fuenteVisual = new List<PresupuestoDto>();
            foreach (PresupuestoDto presupuesto in listaPresupuestos)
            {
                fuenteVisual.Add(presupuesto);
            }

            // Enlazamos la grilla para que se muestren todos los clientes y sus múltiples presupuestos
            dgvPresupuesto.DataSource = null;
            dgvPresupuesto.DataSource = fuenteVisual;
        }
    }
}
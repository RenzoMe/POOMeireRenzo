using System;
using System.Windows.Forms;
using POOMeireRenzo.Dto;
using POOMeireRenzo.Services;

namespace POOMeireRenzo.View
{
    public partial class FormCliente : Form
    {
        private readonly PresupuestoService presupuestoService;

        public FormCliente()
        {
            InitializeComponent();
            this.presupuestoService = new PresupuestoService();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // Método requerido por el diseñador visual
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Método requerido por el diseñador visual
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            // Método requerido por el diseñador visual
        }

        private void ButtonCliente_Click(object sender, EventArgs e)
        {
            // Método requerido por el diseñador visual
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            ClienteDto clienteDto = new ClienteDto(
                txtNombre.Text.Trim(),
                txtTelefono.Text.Trim(),
                txtCorreo.Text.Trim()
            );

            (bool EsValido, string MensajeError) resultadoValidacion = this.presupuestoService.ValidarCliente(clienteDto);

            if (!resultadoValidacion.EsValido)
            {
                MessageBox.Show(resultadoValidacion.MensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();

            FormPresupuesto formPresupuesto = new FormPresupuesto(clienteDto);
            formPresupuesto.ShowDialog();

            this.Close();
        }
    }
}
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

        private void ButtonCliente(object sender, EventArgs e)
        {
            ClienteDto clienteDto = new ClienteDto(
                Nombre.Text.Trim(),
                Documento.Text.Trim(),
                Telefono.Text.Trim()
            );

   
            var resultado = this.presupuestoService.ValidarCliente(clienteDto);

            if (!resultado.EsValido)
            {
                MessageBox.Show(resultado.MensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();

     
            using (FormPresupuesto formPresupuesto = new FormPresupuesto(clienteDto))
            {
                formPresupuesto.ShowDialog();
            }

            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Nombre_TextChanged(object sender, EventArgs e) { }
    }
}
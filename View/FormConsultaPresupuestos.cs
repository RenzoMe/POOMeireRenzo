using System;
using System.Linq;
using System.Windows.Forms;
using POOMeireRenzo.Repository;

namespace POOMeireRenzo.View
{
    public partial class FormConsultaPresupuestos : Form
    {
        public FormConsultaPresupuestos()
        {
            InitializeComponent();
        }

        private void FormConsultaPresupuestos_Load(object sender, EventArgs e)
        {
            AbrirCreacionCliente();
        }

   
        private void btnCrear_Click(object sender, EventArgs e)
        {
            AbrirCreacionCliente();
        }

        private void AbrirCreacionCliente()
        {
            this.Hide();

            using (FormCliente formCliente = new FormCliente())
            {
                formCliente.ShowDialog();
            }

            CargarListaPresupuestos();
            this.Show();
        }

        public void CargarListaPresupuestos()
        {
            var presupuestos = PresupuestoRepository.Instancia.ObtenerTodos();

            var listaReducida = presupuestos.Select(p => new
            {
                Cliente = p.Cliente.Nombre,
                Subtotal = "$ " + p.Total.ToString("N0")
            }).ToList();

            dgvPresupuesto.DataSource = null;
            dgvPresupuesto.DataSource = listaReducida;
        }

        private void crearCiente_Click(object sender, EventArgs e)
        {
            AbrirCreacionCliente();
        }
    }
}
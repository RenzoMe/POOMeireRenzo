using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using POOMeireRenzo.Dto;
using POOMeireRenzo.Services;

namespace POOMeireRenzo.View
{
    public partial class FormPresupuesto : Form
    {
        private readonly ClienteDto clienteActual;
        private readonly PresupuestoService presupuestoService;
        private BindingList<ServicioExtraDto> listaExtrasBinding;
        private BindingList<MenuEspecialDto> listaEspecialesBinding;

        public FormPresupuesto(ClienteDto cliente)
        {
            InitializeComponent();

            this.clienteActual = cliente;
            this.presupuestoService = new PresupuestoService();
            this.listaExtrasBinding = new BindingList<ServicioExtraDto>();
            this.listaEspecialesBinding = new BindingList<MenuEspecialDto>();

            this.Text = "Configuración de Presupuesto - Cliente: " + this.clienteActual.Nombre;

            this.CargarDatosIniciales();
        }

        private void button1_Click(object sender, EventArgs e) { }
        private void numNinos_ValueChanged(object sender, EventArgs e) { }
        private void btnGenerarPresupuestoYPdf_Click(object sender, EventArgs e)
        {
            this.btnGenerarPresupuesto_Click(sender, e);
        }

        private void CargarDatosIniciales()
        {
            // Solicitamos los salones al Servicio en forma de DTOs (Cero repositorios en la Vista)
            cmbSalones.DataSource = this.presupuestoService.ObtenerSalones();
            cmbSalones.DisplayMember = "Nombre";

            if (cmbTipoEspecial.Items.Count == 0)
            {
                cmbTipoEspecial.Items.Add("Celíaco");
                cmbTipoEspecial.Items.Add("Vegetariano");
                cmbTipoEspecial.Items.Add("Diabético");
                cmbTipoEspecial.SelectedIndex = 0;
            }

            dgvExtras.DataSource = this.listaExtrasBinding;
        }

        private void btnAgregarExtra_Click(object sender, EventArgs e)
        {
            string nombreExtra = txtNombreExtra.Text.Trim();
            string textoPrecioExtra = txtPrecioExtra.Text.Trim();
            int cantidadExtra = Convert.ToInt32(numCantExtra.Value);

            decimal precioExtra;
            bool esPrecioValido = decimal.TryParse(textoPrecioExtra, out precioExtra);

            if (string.IsNullOrWhiteSpace(nombreExtra) || !esPrecioValido || precioExtra <= 0 || cantidadExtra <= 0)
            {
                MessageBox.Show("Por favor, ingrese datos válidos para el servicio extra.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ServicioExtraDto nuevoExtra = new ServicioExtraDto(nombreExtra, precioExtra, cantidadExtra);
            this.listaExtrasBinding.Add(nuevoExtra);

            txtNombreExtra.Clear();
            txtPrecioExtra.Clear();
            numCantExtra.Value = 1;
        }

        private void btnAgregarEspecial_Click(object sender, EventArgs e)
        {
            string tipoEspecial = string.Empty;
            if (cmbTipoEspecial.SelectedItem != null)
            {
                tipoEspecial = cmbTipoEspecial.SelectedItem.ToString();
            }

            string nombreEspecial = txtNombreEspecial.Text.Trim();
            string textoPrecioEspecial = txtPrecioEspecial.Text.Trim();
            int cantidadEspecial = Convert.ToInt32(numCantEspecial.Value);

            decimal precioEspecial;
            bool esPrecioValido = decimal.TryParse(textoPrecioEspecial, out precioEspecial);

            if (string.IsNullOrWhiteSpace(tipoEspecial) || string.IsNullOrWhiteSpace(nombreEspecial) || !esPrecioValido || precioEspecial <= 0 || cantidadEspecial <= 0)
            {
                MessageBox.Show("Complete los datos del menú especial correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MenuEspecialDto menuEspecial = new MenuEspecialDto(tipoEspecial, nombreEspecial, precioEspecial, cantidadEspecial);
            this.listaEspecialesBinding.Add(menuEspecial);

            txtNombreEspecial.Clear();
            txtPrecioEspecial.Clear();
            numCantEspecial.Value = 1;
        }

        private void btnGenerarPresupuesto_Click(object sender, EventArgs e)
        {
            SalonDto salonSeleccionado = (SalonDto)cmbSalones.SelectedItem;
            decimal horas = numHoras.Value;
            int cantidadAdultos = Convert.ToInt32(numAdultos.Value);
            int cantidadNinos = Convert.ToInt32(numNinos.Value);

            string plato = txtPlatoPrincipal.Text.Trim();
            string bebida = txtBebida.Text.Trim();
            string postre = txtPostre.Text.Trim();

            decimal precioPlato;
            decimal precioBebida;
            decimal precioPostre;

            bool esPlatoValido = decimal.TryParse(txtPrecioPlato.Text.Trim(), out precioPlato);
            bool esBebidaValida = decimal.TryParse(txtPrecioBebida.Text.Trim(), out precioBebida);
            bool esPostreValido = decimal.TryParse(txtPrecioPostre.Text.Trim(), out precioPostre);

            if (string.IsNullOrWhiteSpace(plato) || string.IsNullOrWhiteSpace(bebida) || string.IsNullOrWhiteSpace(postre) || !esPlatoValido || !esBebidaValida || !esPostreValido)
            {
                MessageBox.Show("Complete todos los campos del menú normal con nombres y precios numéricos válidos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MenuNormalDto menuNormal = new MenuNormalDto(plato, precioPlato, bebida, precioBebida, postre, precioPostre);

            List<MenuEspecialDto> listaEspeciales = this.listaEspecialesBinding.ToList();
            List<ServicioExtraDto> listaExtras = this.listaExtrasBinding.ToList();

            // Empaquetamos todo en el Request DTO
            CrearPresupuestoRequestDto request = new CrearPresupuestoRequestDto();
            request.Cliente = this.clienteActual;
            request.SalonSeleccionado = salonSeleccionado;
            request.Horas = horas;
            request.CantidadAdultos = cantidadAdultos;
            request.CantidadNinos = cantidadNinos;
            request.MenuNormal = menuNormal;
            request.ListaEspeciales = listaEspeciales;
            request.ListaExtras = listaExtras;

            try
            {
                PresupuestoDto presupuestoCreado = this.presupuestoService.CalcularYCrearPresupuesto(request);

                dgvExtras.DataSource = null;
                dgvExtras.DataSource = presupuestoCreado.Items;

                lblTotalFinal.Text = "TOTAL GENERAL: $ " + presupuestoCreado.Total.ToString("N2");

                MessageBox.Show("¡Presupuesto calculado, generado y guardado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
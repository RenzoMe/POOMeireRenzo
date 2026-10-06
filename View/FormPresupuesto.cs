using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using POOMeireRenzo.Dto;
using POOMeireRenzo.Services;

namespace POOMeireRenzo.View
{
    public partial class FormPresupuesto : Form
    {
        private readonly ClienteDto clienteDto;
        private readonly PresupuestoService presupuestoService;
        private readonly PdfReportService pdfReportService;
        private BindingList<ItemPresupuestoDto> listaExtrasAgregados;

        public FormPresupuesto(ClienteDto cliente)
        {
            InitializeComponent();

            this.clienteDto = cliente;
            this.presupuestoService = new PresupuestoService();
            this.pdfReportService = new PdfReportService();
            this.listaExtrasAgregados = new BindingList<ItemPresupuestoDto>();

            this.Text = "Configuración de Presupuesto - Cliente: " + this.clienteDto.Nombre;

            this.CargarDatosIniciales();
            this.EngancharEventos();
            this.RecalcularVista();
        }

        private void CargarDatosIniciales()
        {
            cmbLugares.DataSource = this.presupuestoService.ObtenerLugares();
            cmbExtras.DataSource = this.presupuestoService.ObtenerServiciosAdicionales();

            dgvExtras.DataSource = this.listaExtrasAgregados;
            dgvExtras.ReadOnly = true;
            dgvExtras.AllowUserToAddRows = false;
            dgvExtras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void EngancharEventos()
        {
            btnAgregarExtra.Click -= btnAgregarExtra_Click;
            btnAgregarExtra.Click += btnAgregarExtra_Click;

            btnGenerarPresupuestoYPdf.Click -= btnGenerarPresupuestoYPdf_Click;
            btnGenerarPresupuestoYPdf.Click += btnGenerarPresupuestoYPdf_Click;

            numAdultos.ValueChanged += delegate { RecalcularVista(); };
            numNinos.ValueChanged += delegate { RecalcularVista(); };
            numCeliaco.ValueChanged += delegate { RecalcularVista(); };
            numVegetariano.ValueChanged += delegate { RecalcularVista(); };
            numDiabetico.ValueChanged += delegate { RecalcularVista(); };
            numHoras.ValueChanged += delegate { RecalcularVista(); };
            cmbLugares.SelectedIndexChanged += delegate { RecalcularVista(); };
        }

        private void RecalcularVista()
        {
            CalculoPresupuestoDto inputDto = new CalculoPresupuestoDto
            {
                Horas = numHoras.Value,
                CantidadAdultos = Convert.ToInt32(numAdultos.Value),
                CantidadNinos = Convert.ToInt32(numNinos.Value),
                Celiacos = Convert.ToInt32(numCeliaco.Value),
                Vegetarianos = Convert.ToInt32(numVegetariano.Value),
                Diabeticos = Convert.ToInt32(numDiabetico.Value),
                ExtrasAgregados = this.listaExtrasAgregados.ToList()
            };

            LugarDto? lugarSeleccionado = cmbLugares.SelectedItem as LugarDto;
            CalculoPresupuestoDto resultado = this.presupuestoService.ProcesarCalculo(inputDto, lugarSeleccionado);

            if (!resultado.EsValido)
            {
                MessageBox.Show(resultado.MensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblTotalInvitados.Text = "Total de Invitados: " + resultado.TotalInvitados.ToString();
            lblTotalProvisorio.Text = "TOTAL ESTIMADO: $ " + resultado.TotalEstimado.ToString("N2");
        }

        private void btnAgregarExtra_Click(object? sender, EventArgs e)
        {
            ServicioAdicionalDto? servicio = cmbExtras.SelectedItem as ServicioAdicionalDto;
            if (servicio != null && numCantExtra.Value > 0)
            {
                int cant = Convert.ToInt32(numCantExtra.Value);
                ItemPresupuestoDto? existente = this.listaExtrasAgregados
                    .FirstOrDefault(x => x.Descripcion.Equals(servicio.Nombre, StringComparison.OrdinalIgnoreCase));

                if (existente != null)
                {
                    existente.Cantidad += cant;
                    existente.Subtotal = existente.Cantidad * servicio.MontoFijo;
                }
                else
                {
                    this.listaExtrasAgregados.Add(new ItemPresupuestoDto("Servicio Extra", servicio.Nombre, cant, servicio.MontoFijo, servicio.MontoFijo * cant));
                }

                this.listaExtrasAgregados.ResetBindings();
                this.RecalcularVista();
            }
        }

        private void btnGenerarPresupuestoYPdf_Click(object? sender, EventArgs e)
        {
            CalculoPresupuestoDto inputDto = new CalculoPresupuestoDto
            {
                Horas = numHoras.Value,
                CantidadAdultos = Convert.ToInt32(numAdultos.Value),
                CantidadNinos = Convert.ToInt32(numNinos.Value),
                Celiacos = Convert.ToInt32(numCeliaco.Value),
                Vegetarianos = Convert.ToInt32(numVegetariano.Value),
                Diabeticos = Convert.ToInt32(numDiabetico.Value),
                ExtrasAgregados = this.listaExtrasAgregados.ToList()
            };

            LugarDto? lugarSeleccionado = cmbLugares.SelectedItem as LugarDto;
            CalculoPresupuestoDto resultado = this.presupuestoService.ProcesarCalculo(inputDto, lugarSeleccionado);

            if (resultado.TotalInvitados <= 0)
            {
                MessageBox.Show("Ingrese al menos un invitado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PresupuestoDto guardado = this.presupuestoService.GuardarPresupuesto(this.clienteDto, resultado);

            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                FileName = "Presupuesto_Nro_" + guardado.Id.ToString() + ".pdf"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pdfReportService.GenerarPdfPresupuesto(guardado, dialog.FileName);
                MessageBox.Show("¡Presupuesto guardado y PDF generado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void numNinos_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
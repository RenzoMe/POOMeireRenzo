namespace POOMeireRenzo.View
{
    partial class FormPresupuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbLugares = new ComboBox();
            numHoras = new NumericUpDown();
            numNinos = new NumericUpDown();
            numAdultos = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAgregarExtra = new Button();
            dgvExtras = new DataGridView();
            lblTotalProvisorio = new Label();
            btnGenerarPresupuestoYPdf = new Button();
            lblTotalInvitados = new Label();
            numCeliaco = new NumericUpDown();
            numVegetariano = new NumericUpDown();
            label7 = new Label();
            numDiabetico = new NumericUpDown();
            label8 = new Label();
            cmbExtras = new ComboBox();
            numCantExtra = new NumericUpDown();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numHoras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNinos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdultos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCeliaco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVegetariano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiabetico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantExtra).BeginInit();
            SuspendLayout();
            // 
            // cmbLugares
            // 
            cmbLugares.FormattingEnabled = true;
            cmbLugares.Location = new Point(54, 55);
            cmbLugares.Name = "cmbLugares";
            cmbLugares.Size = new Size(121, 23);
            cmbLugares.TabIndex = 0;
            // 
            // numHoras
            // 
            numHoras.Location = new Point(55, 118);
            numHoras.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numHoras.Name = "numHoras";
            numHoras.Size = new Size(120, 23);
            numHoras.TabIndex = 1;
            numHoras.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numNinos
            // 
            numNinos.Location = new Point(55, 250);
            numNinos.Name = "numNinos";
            numNinos.Size = new Size(120, 23);
            numNinos.TabIndex = 2;
            numNinos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numNinos.ValueChanged += numNinos_ValueChanged;
            // 
            // numAdultos
            // 
            numAdultos.Location = new Point(55, 184);
            numAdultos.Name = "numAdultos";
            numAdultos.Size = new Size(120, 23);
            numAdultos.TabIndex = 3;
            numAdultos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 25);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 4;
            label1.Text = "Selecciona un salón:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 91);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "Cantidad de horas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 156);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 6;
            label3.Text = "Cantidad de adultos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 220);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 7;
            label4.Text = "Cantidad de niños:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 25);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 10;
            label5.Text = "Añade menú celiaco:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 91);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 13;
            label6.Text = "Cantidad de extras:";
            // 
            // btnAgregarExtra
            // 
            btnAgregarExtra.Location = new Point(375, 156);
            btnAgregarExtra.Name = "btnAgregarExtra";
            btnAgregarExtra.Size = new Size(130, 23);
            btnAgregarExtra.TabIndex = 15;
            btnAgregarExtra.Text = "Agregar Extra";
            btnAgregarExtra.UseVisualStyleBackColor = true;
            btnAgregarExtra.Click += btnAgregarExtra_Click;
            // 
            // dgvExtras
            // 
            dgvExtras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtras.Location = new Point(376, 186);
            dgvExtras.Name = "dgvExtras";
            dgvExtras.Size = new Size(604, 252);
            dgvExtras.TabIndex = 16;
            // 
            // lblTotalProvisorio
            // 
            lblTotalProvisorio.AutoSize = true;
            lblTotalProvisorio.Location = new Point(191, 350);
            lblTotalProvisorio.Name = "lblTotalProvisorio";
            lblTotalProvisorio.Size = new Size(68, 15);
            lblTotalProvisorio.TabIndex = 17;
            lblTotalProvisorio.Text = "Sub Total: $";
            // 
            // btnGenerarPresupuestoYPdf
            // 
            btnGenerarPresupuestoYPdf.Location = new Point(131, 377);
            btnGenerarPresupuestoYPdf.Name = "btnGenerarPresupuestoYPdf";
            btnGenerarPresupuestoYPdf.Size = new Size(204, 23);
            btnGenerarPresupuestoYPdf.TabIndex = 18;
            btnGenerarPresupuestoYPdf.Text = "Confirmar, guardar y emitir PDF";
            btnGenerarPresupuestoYPdf.UseVisualStyleBackColor = true;
            btnGenerarPresupuestoYPdf.Click += btnGenerarPresupuestoYPdf_Click;
            // 
            // lblTotalInvitados
            // 
            lblTotalInvitados.AutoSize = true;
            lblTotalInvitados.Location = new Point(73, 295);
            lblTotalInvitados.Name = "lblTotalInvitados";
            lblTotalInvitados.Size = new Size(0, 15);
            lblTotalInvitados.TabIndex = 19;
            // 
            // numCeliaco
            // 
            numCeliaco.Location = new Point(228, 55);
            numCeliaco.Name = "numCeliaco";
            numCeliaco.Size = new Size(120, 23);
            numCeliaco.TabIndex = 20;
            // 
            // numVegetariano
            // 
            numVegetariano.Location = new Point(228, 121);
            numVegetariano.Name = "numVegetariano";
            numVegetariano.Size = new Size(120, 23);
            numVegetariano.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 91);
            label7.Name = "label7";
            label7.Size = new Size(143, 15);
            label7.TabIndex = 21;
            label7.Text = "Añade menú vegetariano:";
            // 
            // numDiabetico
            // 
            numDiabetico.Location = new Point(228, 186);
            numDiabetico.Name = "numDiabetico";
            numDiabetico.Size = new Size(120, 23);
            numDiabetico.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(228, 156);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 23;
            label8.Text = "Añade menú diabetico:";
            // 
            // cmbExtras
            // 
            cmbExtras.FormattingEnabled = true;
            cmbExtras.Location = new Point(375, 54);
            cmbExtras.Name = "cmbExtras";
            cmbExtras.Size = new Size(121, 23);
            cmbExtras.TabIndex = 25;
            // 
            // numCantExtra
            // 
            numCantExtra.Location = new Point(376, 118);
            numCantExtra.Name = "numCantExtra";
            numCantExtra.Size = new Size(120, 23);
            numCantExtra.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(375, 25);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 27;
            label9.Text = "Tipo de extras:";
            // 
            // FormPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(label9);
            Controls.Add(numCantExtra);
            Controls.Add(cmbExtras);
            Controls.Add(numDiabetico);
            Controls.Add(label8);
            Controls.Add(numVegetariano);
            Controls.Add(label7);
            Controls.Add(numCeliaco);
            Controls.Add(lblTotalInvitados);
            Controls.Add(btnGenerarPresupuestoYPdf);
            Controls.Add(lblTotalProvisorio);
            Controls.Add(dgvExtras);
            Controls.Add(btnAgregarExtra);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numAdultos);
            Controls.Add(numNinos);
            Controls.Add(numHoras);
            Controls.Add(cmbLugares);
            Name = "FormPresupuesto";
            Text = "FormPresupuesto";
            ((System.ComponentModel.ISupportInitialize)numHoras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNinos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdultos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCeliaco).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVegetariano).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiabetico).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantExtra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbLugares;
        private NumericUpDown numHoras;
        private NumericUpDown numNinos;
        private NumericUpDown numAdultos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAgregarExtra;
        private DataGridView dgvExtras;
        private Label lblTotalProvisorio;
        private Button btnGenerarPresupuestoYPdf;
        private Label lblTotalInvitados;
        private NumericUpDown numCeliaco;
        private NumericUpDown numVegetariano;
        private Label label7;
        private NumericUpDown numDiabetico;
        private Label label8;
        private ComboBox cmbExtras;
        private NumericUpDown numCantExtra;
        private Label label9;
    }
}
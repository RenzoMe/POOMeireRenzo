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
            cmbSalones = new ComboBox();
            numHoras = new NumericUpDown();
            numNinos = new NumericUpDown();
            numAdultos = new NumericUpDown();
            salones = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTotalFinal = new Label();
            btnGenerarPresupuestoYPdf = new Button();
            lblTotalInvitados = new Label();
            label7 = new Label();
            label8 = new Label();
            txtPlatoPrincipal = new TextBox();
            txtBebida = new TextBox();
            txtPostre = new TextBox();
            txtPrecioPostre = new TextBox();
            txtPrecioBebida = new TextBox();
            txtPrecioPlato = new TextBox();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            label6 = new Label();
            MenusEspeciales = new GroupBox();
            button1 = new Button();
            label14 = new Label();
            numCantEspecial = new NumericUpDown();
            txtPrecioEspecial = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label9 = new Label();
            txtNombreEspecial = new TextBox();
            cmbTipoEspecial = new ComboBox();
            label15 = new Label();
            groupBox1 = new GroupBox();
            dgvExtras = new DataGridView();
            button2 = new Button();
            label16 = new Label();
            numCantExtra = new NumericUpDown();
            txtPrecioExtra = new TextBox();
            label17 = new Label();
            label18 = new Label();
            txtNombreExtra = new TextBox();
            dgvEspeciales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numHoras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNinos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdultos).BeginInit();
            MenusEspeciales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantEspecial).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantExtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEspeciales).BeginInit();
            SuspendLayout();
            // 
            // cmbSalones
            // 
            cmbSalones.FormattingEnabled = true;
            cmbSalones.Location = new Point(179, 55);
            cmbSalones.Name = "cmbSalones";
            cmbSalones.Size = new Size(121, 23);
            cmbSalones.TabIndex = 0;
            // 
            // numHoras
            // 
            numHoras.Location = new Point(180, 118);
            numHoras.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numHoras.Name = "numHoras";
            numHoras.Size = new Size(120, 23);
            numHoras.TabIndex = 1;
            numHoras.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numNinos
            // 
            numNinos.Location = new Point(180, 250);
            numNinos.Name = "numNinos";
            numNinos.Size = new Size(120, 23);
            numNinos.TabIndex = 2;
            numNinos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numNinos.ValueChanged += numNinos_ValueChanged;
            // 
            // numAdultos
            // 
            numAdultos.Location = new Point(180, 184);
            numAdultos.Name = "numAdultos";
            numAdultos.Size = new Size(120, 23);
            numAdultos.TabIndex = 3;
            numAdultos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // salones
            // 
            salones.AutoSize = true;
            salones.Location = new Point(179, 25);
            salones.Name = "salones";
            salones.Size = new Size(105, 15);
            salones.TabIndex = 4;
            salones.Text = "Nombre del Salón:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 91);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "Cantidad de horas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 156);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 6;
            label3.Text = "Cantidad de adultos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 220);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 7;
            label4.Text = "Cantidad de niños:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 324);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 10;
            label5.Text = "Platillo Principal:";
            // 
            // lblTotalFinal
            // 
            lblTotalFinal.AutoSize = true;
            lblTotalFinal.Location = new Point(179, 628);
            lblTotalFinal.Name = "lblTotalFinal";
            lblTotalFinal.Size = new Size(68, 15);
            lblTotalFinal.TabIndex = 17;
            lblTotalFinal.Text = "Sub Total: $";
            // 
            // btnGenerarPresupuestoYPdf
            // 
            btnGenerarPresupuestoYPdf.Location = new Point(119, 655);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 390);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 21;
            label7.Text = "Bebida:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 455);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 23;
            label8.Text = "Postre:";
            // 
            // txtPlatoPrincipal
            // 
            txtPlatoPrincipal.Location = new Point(119, 354);
            txtPlatoPrincipal.Name = "txtPlatoPrincipal";
            txtPlatoPrincipal.Size = new Size(100, 23);
            txtPlatoPrincipal.TabIndex = 28;
            // 
            // txtBebida
            // 
            txtBebida.Location = new Point(119, 416);
            txtBebida.Name = "txtBebida";
            txtBebida.Size = new Size(100, 23);
            txtBebida.TabIndex = 29;
            // 
            // txtPostre
            // 
            txtPostre.Location = new Point(119, 483);
            txtPostre.Name = "txtPostre";
            txtPostre.Size = new Size(100, 23);
            txtPostre.TabIndex = 30;
            // 
            // txtPrecioPostre
            // 
            txtPrecioPostre.Location = new Point(247, 483);
            txtPrecioPostre.Name = "txtPrecioPostre";
            txtPrecioPostre.Size = new Size(100, 23);
            txtPrecioPostre.TabIndex = 36;
            // 
            // txtPrecioBebida
            // 
            txtPrecioBebida.Location = new Point(247, 416);
            txtPrecioBebida.Name = "txtPrecioBebida";
            txtPrecioBebida.Size = new Size(100, 23);
            txtPrecioBebida.TabIndex = 35;
            // 
            // txtPrecioPlato
            // 
            txtPrecioPlato.Location = new Point(247, 354);
            txtPrecioPlato.Name = "txtPrecioPlato";
            txtPrecioPlato.Size = new Size(100, 23);
            txtPrecioPlato.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 455);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 33;
            label1.Text = "Precio Postre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(247, 390);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 32;
            label10.Text = "Precio Bebida:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(247, 324);
            label11.Name = "label11";
            label11.Size = new Size(82, 15);
            label11.TabIndex = 31;
            label11.Text = "Precio Platillo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 368);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 37;
            label6.Text = "Platillo Especial:";
            // 
            // MenusEspeciales
            // 
            MenusEspeciales.Controls.Add(dgvEspeciales);
            MenusEspeciales.Controls.Add(button1);
            MenusEspeciales.Controls.Add(label14);
            MenusEspeciales.Controls.Add(numCantEspecial);
            MenusEspeciales.Controls.Add(txtPrecioEspecial);
            MenusEspeciales.Controls.Add(label13);
            MenusEspeciales.Controls.Add(label12);
            MenusEspeciales.Controls.Add(label9);
            MenusEspeciales.Controls.Add(txtNombreEspecial);
            MenusEspeciales.Controls.Add(cmbTipoEspecial);
            MenusEspeciales.Location = new Point(473, 386);
            MenusEspeciales.Name = "MenusEspeciales";
            MenusEspeciales.Size = new Size(711, 348);
            MenusEspeciales.TabIndex = 38;
            MenusEspeciales.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(15, 310);
            button1.Name = "button1";
            button1.Size = new Size(163, 23);
            button1.TabIndex = 8;
            button1.Text = "Agregar menú especial";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 235);
            label14.Name = "label14";
            label14.Size = new Size(102, 15);
            label14.TabIndex = 7;
            label14.Text = "Cantidad platillos:";
            // 
            // numCantEspecial
            // 
            numCantEspecial.Location = new Point(15, 271);
            numCantEspecial.Name = "numCantEspecial";
            numCantEspecial.Size = new Size(120, 23);
            numCantEspecial.TabIndex = 6;
            // 
            // txtPrecioEspecial
            // 
            txtPrecioEspecial.Location = new Point(15, 194);
            txtPrecioEspecial.Name = "txtPrecioEspecial";
            txtPrecioEspecial.Size = new Size(100, 23);
            txtPrecioEspecial.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 165);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 4;
            label13.Text = "Precio:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 83);
            label12.Name = "label12";
            label12.Size = new Size(112, 15);
            label12.TabIndex = 3;
            label12.Text = "Nombre del platillo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 20);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 2;
            label9.Text = "Seleccione el tipo de especial:";
            // 
            // txtNombreEspecial
            // 
            txtNombreEspecial.Location = new Point(15, 127);
            txtNombreEspecial.Name = "txtNombreEspecial";
            txtNombreEspecial.Size = new Size(100, 23);
            txtNombreEspecial.TabIndex = 1;
            // 
            // cmbTipoEspecial
            // 
            cmbTipoEspecial.FormattingEnabled = true;
            cmbTipoEspecial.Items.AddRange(new object[] { "Celiaco", "Vegetariano", "Diabetico" });
            cmbTipoEspecial.Location = new Point(6, 45);
            cmbTipoEspecial.Name = "cmbTipoEspecial";
            cmbTipoEspecial.Size = new Size(121, 23);
            cmbTipoEspecial.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(473, 25);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 39;
            label15.Text = "Servicio Extra:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvExtras);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(numCantExtra);
            groupBox1.Controls.Add(txtPrecioExtra);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(txtNombreExtra);
            groupBox1.Location = new Point(473, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 312);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            // 
            // dgvExtras
            // 
            dgvExtras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtras.Location = new Point(185, 30);
            dgvExtras.Name = "dgvExtras";
            dgvExtras.Size = new Size(504, 245);
            dgvExtras.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(6, 252);
            button2.Name = "button2";
            button2.Size = new Size(163, 23);
            button2.TabIndex = 8;
            button2.Text = "Agregar extra";
            button2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 177);
            label16.Name = "label16";
            label16.Size = new Size(107, 15);
            label16.TabIndex = 7;
            label16.Text = "Cantidad de extras:";
            // 
            // numCantExtra
            // 
            numCantExtra.Location = new Point(15, 207);
            numCantExtra.Name = "numCantExtra";
            numCantExtra.Size = new Size(120, 23);
            numCantExtra.TabIndex = 6;
            // 
            // txtPrecioExtra
            // 
            txtPrecioExtra.Location = new Point(15, 126);
            txtPrecioExtra.Name = "txtPrecioExtra";
            txtPrecioExtra.Size = new Size(100, 23);
            txtPrecioExtra.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 95);
            label17.Name = "label17";
            label17.Size = new Size(43, 15);
            label17.TabIndex = 4;
            label17.Text = "Precio:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 20);
            label18.Name = "label18";
            label18.Size = new Size(101, 15);
            label18.TabIndex = 3;
            label18.Text = "Nombre del extra:";
            // 
            // txtNombreExtra
            // 
            txtNombreExtra.Location = new Point(15, 48);
            txtNombreExtra.Name = "txtNombreExtra";
            txtNombreExtra.Size = new Size(100, 23);
            txtNombreExtra.TabIndex = 1;
            // 
            // dgvEspeciales
            // 
            dgvEspeciales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspeciales.Location = new Point(185, 22);
            dgvEspeciales.Name = "dgvEspeciales";
            dgvEspeciales.Size = new Size(504, 311);
            dgvEspeciales.TabIndex = 9;
            // 
            // FormPresupuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 754);
            Controls.Add(groupBox1);
            Controls.Add(label15);
            Controls.Add(MenusEspeciales);
            Controls.Add(label6);
            Controls.Add(txtPrecioPostre);
            Controls.Add(txtPrecioBebida);
            Controls.Add(txtPrecioPlato);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(txtPostre);
            Controls.Add(txtBebida);
            Controls.Add(txtPlatoPrincipal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblTotalInvitados);
            Controls.Add(btnGenerarPresupuestoYPdf);
            Controls.Add(lblTotalFinal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(salones);
            Controls.Add(numAdultos);
            Controls.Add(numNinos);
            Controls.Add(numHoras);
            Controls.Add(cmbSalones);
            Name = "FormPresupuesto";
            Text = "FormPresupuesto";
            ((System.ComponentModel.ISupportInitialize)numHoras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNinos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdultos).EndInit();
            MenusEspeciales.ResumeLayout(false);
            MenusEspeciales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantEspecial).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantExtra).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEspeciales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSalones;
        private NumericUpDown numHoras;
        private NumericUpDown numNinos;
        private NumericUpDown numAdultos;
        private Label salones;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTotalFinal;
        private Button btnGenerarPresupuestoYPdf;
        private Label lblTotalInvitados;
        private Label label7;
        private Label label8;
        private TextBox txtPlatoPrincipal;
        private TextBox txtBebida;
        private TextBox txtPostre;
        private TextBox txtPrecioPostre;
        private TextBox txtPrecioBebida;
        private TextBox txtPrecioPlato;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label6;
        private GroupBox MenusEspeciales;
        private ComboBox cmbTipoEspecial;
        private TextBox txtNombreEspecial;
        private Label label9;
        private Label label12;
        private Label label13;
        private TextBox txtPrecioEspecial;
        private NumericUpDown numCantEspecial;
        private Label label14;
        private Button button1;
        private Label label15;
        private GroupBox groupBox1;
        private Button button2;
        private Label label16;
        private NumericUpDown numCantExtra;
        private TextBox txtPrecioExtra;
        private Label label17;
        private Label label18;
        private TextBox txtNombreExtra;
        private DataGridView dgvExtras;
        private DataGridView dgvEspeciales;
    }
}
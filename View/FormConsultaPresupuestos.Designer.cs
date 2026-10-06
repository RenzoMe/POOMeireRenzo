namespace POOMeireRenzo.View
{
    partial class FormConsultaPresupuestos
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
            TextoVerPresupuestos = new Label();
            dgvPresupuesto = new DataGridView();
            textoCrearCliente = new Label();
            crearCiente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPresupuesto).BeginInit();
            SuspendLayout();
            // 
            // TextoVerPresupuestos
            // 
            TextoVerPresupuestos.AutoSize = true;
            TextoVerPresupuestos.Location = new Point(114, 89);
            TextoVerPresupuestos.Name = "TextoVerPresupuestos";
            TextoVerPresupuestos.Size = new Size(99, 15);
            TextoVerPresupuestos.TabIndex = 0;
            TextoVerPresupuestos.Text = "Ver presupuestos:";
            // 
            // dgvPresupuesto
            // 
            dgvPresupuesto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresupuesto.Location = new Point(12, 163);
            dgvPresupuesto.Name = "dgvPresupuesto";
            dgvPresupuesto.Size = new Size(321, 254);
            dgvPresupuesto.TabIndex = 2;
            // 
            // textoCrearCliente
            // 
            textoCrearCliente.AutoSize = true;
            textoCrearCliente.Location = new Point(508, 89);
            textoCrearCliente.Name = "textoCrearCliente";
            textoCrearCliente.Size = new Size(112, 15);
            textoCrearCliente.TabIndex = 3;
            textoCrearCliente.Text = "Crear nuevo cliente:";
            // 
            // crearCiente
            // 
            crearCiente.Location = new Point(528, 119);
            crearCiente.Name = "crearCiente";
            crearCiente.Size = new Size(75, 23);
            crearCiente.TabIndex = 4;
            crearCiente.Text = "crear cliente";
            crearCiente.UseVisualStyleBackColor = true;
            crearCiente.Click += crearCiente_Click;
            // 
            // FormConsultaPresupuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(crearCiente);
            Controls.Add(textoCrearCliente);
            Controls.Add(dgvPresupuesto);
            Controls.Add(TextoVerPresupuestos);
            Name = "FormConsultaPresupuestos";
            Text = "FormConsultaPresupuestos";
            Load += FormConsultaPresupuestos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPresupuesto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextoVerPresupuestos;
        private DataGridView dgvPresupuesto;
        private Label textoCrearCliente;
        private Button crearCiente;
    }
}
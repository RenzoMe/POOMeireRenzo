namespace POOMeireRenzo.View
{
    partial class FormCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtCorreo = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            btnContinuar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(295, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre completo:";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(295, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(100, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += Nombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(295, 145);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new System.Drawing.Point(295, 178);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(100, 23);
            txtCorreo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(295, 221);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(295, 252);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(100, 23);
            txtTelefono.TabIndex = 5;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new System.Drawing.Point(308, 295);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new System.Drawing.Size(75, 23);
            btnContinuar.TabIndex = 6;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnContinuar);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnContinuar;
    }
}
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
            label1 = new Label();
            Nombre = new TextBox();
            label2 = new Label();
            Documento = new TextBox();
            label3 = new Label();
            Telefono = new TextBox();
            buttonCliente = new Button();
            SuspendLayout();
       
            label1.AutoSize = true;
            label1.Location = new Point(295, 68);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre completo:";
            label1.Click += label1_Click;
          
            Nombre.Location = new Point(295, 104);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(100, 23);
            Nombre.TabIndex = 1;
            Nombre.TextChanged += Nombre_TextChanged;
       
            label2.AutoSize = true;
            label2.Location = new Point(295, 145);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Documento:";
          
            Documento.Location = new Point(295, 178);
            Documento.Name = "Documento";
            Documento.Size = new Size(100, 23);
            Documento.TabIndex = 3;
           
            label3.AutoSize = true;
            label3.Location = new Point(295, 221);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefono:";
         
            Telefono.Location = new Point(295, 252);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(100, 23);
            Telefono.TabIndex = 5;
           
            buttonCliente.Location = new Point(308, 295);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(75, 23);
            buttonCliente.TabIndex = 6;
            buttonCliente.Text = "Continuar";
            buttonCliente.UseVisualStyleBackColor = true;
            buttonCliente.Click += ButtonCliente;
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCliente);
            Controls.Add(Telefono);
            Controls.Add(label3);
            Controls.Add(Documento);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(label1);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Nombre;
        private Label label2;
        private TextBox Documento;
        private Label label3;
        private TextBox Telefono;
        private Button buttonCliente;
    }
}
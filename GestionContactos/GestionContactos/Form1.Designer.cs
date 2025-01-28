namespace GestionContactos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAñadContac = new Button();
            btnEliminarContacto = new Button();
            btnModificarTLF = new Button();
            SuspendLayout();
            // 
            // btnAñadContac
            // 
            btnAñadContac.Location = new Point(51, 59);
            btnAñadContac.Name = "btnAñadContac";
            btnAñadContac.Size = new Size(121, 59);
            btnAñadContac.TabIndex = 0;
            btnAñadContac.Text = "Añadir Contacto";
            btnAñadContac.UseVisualStyleBackColor = true;
            btnAñadContac.Click += btnAñadContac_Click;
            // 
            // btnEliminarContacto
            // 
            btnEliminarContacto.Location = new Point(225, 59);
            btnEliminarContacto.Name = "btnEliminarContacto";
            btnEliminarContacto.Size = new Size(114, 59);
            btnEliminarContacto.TabIndex = 1;
            btnEliminarContacto.Text = "Eliminar Contacto";
            btnEliminarContacto.UseVisualStyleBackColor = true;
            btnEliminarContacto.Click += btnEliminarContacto_Click;
            // 
            // btnModificarTLF
            // 
            btnModificarTLF.Location = new Point(51, 159);
            btnModificarTLF.Name = "btnModificarTLF";
            btnModificarTLF.Size = new Size(121, 54);
            btnModificarTLF.TabIndex = 2;
            btnModificarTLF.Text = "Modificar telefono";
            btnModificarTLF.UseVisualStyleBackColor = true;
            btnModificarTLF.Click += btnModificarTLF_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarTLF);
            Controls.Add(btnEliminarContacto);
            Controls.Add(btnAñadContac);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAñadContac;
        private Button btnEliminarContacto;
        private Button btnModificarTLF;
    }
}

namespace Biblioteca
{
    partial class VentanaPrincipal
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonVerLibros = new System.Windows.Forms.Button();
            this.buttonVerSocios = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonGestionarPrestamos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.ImageKey = "(none)";
            this.buttonVolver.Location = new System.Drawing.Point(59, 526);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(158, 41);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVerLibros
            // 
            this.buttonVerLibros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVerLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerLibros.Location = new System.Drawing.Point(331, 125);
            this.buttonVerLibros.Name = "buttonVerLibros";
            this.buttonVerLibros.Size = new System.Drawing.Size(158, 135);
            this.buttonVerLibros.TabIndex = 2;
            this.buttonVerLibros.Text = "Ver Lista de Libros";
            this.buttonVerLibros.UseVisualStyleBackColor = true;
            this.buttonVerLibros.Click += new System.EventHandler(this.buttonVerLibros_Click);
            // 
            // buttonVerSocios
            // 
            this.buttonVerSocios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVerSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerSocios.Location = new System.Drawing.Point(59, 125);
            this.buttonVerSocios.Name = "buttonVerSocios";
            this.buttonVerSocios.Size = new System.Drawing.Size(158, 135);
            this.buttonVerSocios.TabIndex = 1;
            this.buttonVerSocios.Text = "Ver Lista de Socios";
            this.buttonVerSocios.UseVisualStyleBackColor = true;
            this.buttonVerSocios.Click += new System.EventHandler(this.buttonVerSocios_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(610, 513);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(158, 41);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonGestionarPrestamos
            // 
            this.buttonGestionarPrestamos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGestionarPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestionarPrestamos.Location = new System.Drawing.Point(610, 125);
            this.buttonGestionarPrestamos.Name = "buttonGestionarPrestamos";
            this.buttonGestionarPrestamos.Size = new System.Drawing.Size(158, 135);
            this.buttonGestionarPrestamos.TabIndex = 3;
            this.buttonGestionarPrestamos.Text = "Gestionar Prestamos";
            this.buttonGestionarPrestamos.UseVisualStyleBackColor = true;
            this.buttonGestionarPrestamos.Click += new System.EventHandler(this.buttonGestionarPrestamos_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Biblioteca.Properties.Resources.BibliotecaVicentedeCarvalho;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonVolver;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGestionarPrestamos);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonVerSocios);
            this.Controls.Add(this.buttonVerLibros);
            this.Controls.Add(this.buttonVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonVerLibros;
        private System.Windows.Forms.Button buttonVerSocios;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonGestionarPrestamos;
    }
}
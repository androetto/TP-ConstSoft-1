namespace TP_ConstSoft_1
{
    partial class FrmDetalleAlumno
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtBoxNombre = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblLegajo = new System.Windows.Forms.Label();
            this.LblCarrera = new System.Windows.Forms.Label();
            this.TxtBoxApellido = new System.Windows.Forms.TextBox();
            this.TxtBoxLegajo = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtBoxCarrera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(17, 20);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtBoxNombre
            // 
            this.TxtBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxNombre.Location = new System.Drawing.Point(78, 13);
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxNombre.TabIndex = 0;
            this.TxtBoxNombre.UseWaitCursor = true;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(17, 53);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido";
            // 
            // LblLegajo
            // 
            this.LblLegajo.AutoSize = true;
            this.LblLegajo.Location = new System.Drawing.Point(20, 86);
            this.LblLegajo.Name = "LblLegajo";
            this.LblLegajo.Size = new System.Drawing.Size(39, 13);
            this.LblLegajo.TabIndex = 3;
            this.LblLegajo.Text = "Legajo";
            // 
            // LblCarrera
            // 
            this.LblCarrera.AutoSize = true;
            this.LblCarrera.Location = new System.Drawing.Point(19, 119);
            this.LblCarrera.Name = "LblCarrera";
            this.LblCarrera.Size = new System.Drawing.Size(41, 13);
            this.LblCarrera.TabIndex = 4;
            this.LblCarrera.Text = "Carrera";
            // 
            // TxtBoxApellido
            // 
            this.TxtBoxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxApellido.Location = new System.Drawing.Point(78, 48);
            this.TxtBoxApellido.Name = "TxtBoxApellido";
            this.TxtBoxApellido.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxApellido.TabIndex = 1;
            // 
            // TxtBoxLegajo
            // 
            this.TxtBoxLegajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxLegajo.Location = new System.Drawing.Point(78, 83);
            this.TxtBoxLegajo.Name = "TxtBoxLegajo";
            this.TxtBoxLegajo.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxLegajo.TabIndex = 2;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(13, 165);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(121, 165);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtBoxCarrera
            // 
            this.TxtBoxCarrera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxCarrera.Location = new System.Drawing.Point(78, 116);
            this.TxtBoxCarrera.Name = "TxtBoxCarrera";
            this.TxtBoxCarrera.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxCarrera.TabIndex = 3;
            // 
            // FrmDetalleAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 200);
            this.Controls.Add(this.TxtBoxCarrera);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtBoxLegajo);
            this.Controls.Add(this.TxtBoxApellido);
            this.Controls.Add(this.LblCarrera);
            this.Controls.Add(this.LblLegajo);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.TxtBoxNombre);
            this.Controls.Add(this.LblNombre);
            this.Name = "FrmDetalleAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregar";
            this.Load += new System.EventHandler(this.FrmDetalleAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtBoxNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblLegajo;
        private System.Windows.Forms.Label LblCarrera;
        private System.Windows.Forms.TextBox TxtBoxApellido;
        private System.Windows.Forms.TextBox TxtBoxLegajo;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtBoxCarrera;
    }
}
namespace WindowsFormsApp2
{
    partial class frmRegistroPersona
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fecha_na = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "No Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 481);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo Electronico";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(96, 442);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(285, 22);
            this.txtDocumento.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(96, 208);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(285, 22);
            this.txtApellidos.TabIndex = 7;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "Apellidos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 550);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Genero";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(96, 511);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(285, 22);
            this.txtCorreo.TabIndex = 20;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(96, 137);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(285, 22);
            this.txtNombres.TabIndex = 21;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGenero.Location = new System.Drawing.Point(221, 553);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(160, 24);
            this.cmbGenero.TabIndex = 22;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(268, 604);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(115, 34);
            this.btnSiguiente.TabIndex = 23;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(96, 368);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoDocumento.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tipo de Documento";
            // 
            // fecha_na
            // 
            this.fecha_na.Location = new System.Drawing.Point(96, 298);
            this.fecha_na.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fecha_na.Name = "fecha_na";
            this.fecha_na.Size = new System.Drawing.Size(265, 22);
            this.fecha_na.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 252);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 27);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fecha de Nacimiento";
            // 
            // frmRegistroPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 652);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fecha_na);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegistroPersona";
            this.Text = "i";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fecha_na;
        private System.Windows.Forms.Label label8;
    }
}


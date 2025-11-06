namespace MnayaRRHH.Vistas
{
    partial class BuscarCandidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCandidato));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupDatosPersonales = new System.Windows.Forms.GroupBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.campoDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.campoFechaAlta = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            this.campoLocalidad = new System.Windows.Forms.TextBox();
            this.campoCp = new System.Windows.Forms.TextBox();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.campoFechaNacimiento = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda de candidatos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de candidatos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // groupDatosPersonales
            // 
            this.groupDatosPersonales.Controls.Add(this.campoNombre);
            this.groupDatosPersonales.Controls.Add(this.campoApellidos);
            this.groupDatosPersonales.Controls.Add(this.campoFechaNacimiento);
            this.groupDatosPersonales.Controls.Add(this.campoDireccion);
            this.groupDatosPersonales.Controls.Add(this.campoCp);
            this.groupDatosPersonales.Controls.Add(this.campoLocalidad);
            this.groupDatosPersonales.Controls.Add(this.campoTelefono);
            this.groupDatosPersonales.Controls.Add(this.campoEmail);
            this.groupDatosPersonales.Controls.Add(this.campoFechaAlta);
            this.groupDatosPersonales.Controls.Add(this.pictureFoto);
            this.groupDatosPersonales.Controls.Add(this.label13);
            this.groupDatosPersonales.Controls.Add(this.label12);
            this.groupDatosPersonales.Controls.Add(this.label11);
            this.groupDatosPersonales.Controls.Add(this.label10);
            this.groupDatosPersonales.Controls.Add(this.label9);
            this.groupDatosPersonales.Controls.Add(this.label8);
            this.groupDatosPersonales.Controls.Add(this.label7);
            this.groupDatosPersonales.Controls.Add(this.label6);
            this.groupDatosPersonales.Controls.Add(this.label5);
            this.groupDatosPersonales.Controls.Add(this.label4);
            this.groupDatosPersonales.ForeColor = System.Drawing.Color.Firebrick;
            this.groupDatosPersonales.Location = new System.Drawing.Point(102, 192);
            this.groupDatosPersonales.Name = "groupDatosPersonales";
            this.groupDatosPersonales.Size = new System.Drawing.Size(884, 347);
            this.groupDatosPersonales.TabIndex = 3;
            this.groupDatosPersonales.TabStop = false;
            this.groupDatosPersonales.Text = "DATOS PERSONALES";
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Seleccione",
            "Administración",
            "Almacén"});
            this.comboTipo.Location = new System.Drawing.Point(175, 98);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(148, 21);
            this.comboTipo.TabIndex = 4;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // campoDni
            // 
            this.campoDni.Enabled = false;
            this.campoDni.Location = new System.Drawing.Point(175, 142);
            this.campoDni.Name = "campoDni";
            this.campoDni.Size = new System.Drawing.Size(148, 20);
            this.campoDni.TabIndex = 5;
            this.campoDni.Tag = "DNI";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(360, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha de alta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Localidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "CP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Dirección";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Fecha de nacimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Apellidos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(607, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Foto";
            // 
            // pictureFoto
            // 
            this.pictureFoto.Location = new System.Drawing.Point(610, 76);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(163, 178);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFoto.TabIndex = 10;
            this.pictureFoto.TabStop = false;
            // 
            // campoFechaAlta
            // 
            this.campoFechaAlta.Enabled = false;
            this.campoFechaAlta.Location = new System.Drawing.Point(258, 303);
            this.campoFechaAlta.Name = "campoFechaAlta";
            this.campoFechaAlta.Size = new System.Drawing.Size(143, 20);
            this.campoFechaAlta.TabIndex = 11;
            // 
            // campoEmail
            // 
            this.campoEmail.Enabled = false;
            this.campoEmail.Location = new System.Drawing.Point(258, 266);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(237, 20);
            this.campoEmail.TabIndex = 12;
            // 
            // campoTelefono
            // 
            this.campoTelefono.Enabled = false;
            this.campoTelefono.Location = new System.Drawing.Point(258, 234);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(143, 20);
            this.campoTelefono.TabIndex = 13;
            // 
            // campoLocalidad
            // 
            this.campoLocalidad.Enabled = false;
            this.campoLocalidad.Location = new System.Drawing.Point(258, 201);
            this.campoLocalidad.Name = "campoLocalidad";
            this.campoLocalidad.Size = new System.Drawing.Size(143, 20);
            this.campoLocalidad.TabIndex = 14;
            // 
            // campoCp
            // 
            this.campoCp.Enabled = false;
            this.campoCp.Location = new System.Drawing.Point(258, 167);
            this.campoCp.Name = "campoCp";
            this.campoCp.Size = new System.Drawing.Size(88, 20);
            this.campoCp.TabIndex = 15;
            // 
            // campoDireccion
            // 
            this.campoDireccion.Enabled = false;
            this.campoDireccion.Location = new System.Drawing.Point(258, 134);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(237, 20);
            this.campoDireccion.TabIndex = 16;
            // 
            // campoFechaNacimiento
            // 
            this.campoFechaNacimiento.Enabled = false;
            this.campoFechaNacimiento.Location = new System.Drawing.Point(258, 101);
            this.campoFechaNacimiento.Name = "campoFechaNacimiento";
            this.campoFechaNacimiento.Size = new System.Drawing.Size(143, 20);
            this.campoFechaNacimiento.TabIndex = 17;
            // 
            // campoApellidos
            // 
            this.campoApellidos.Enabled = false;
            this.campoApellidos.Location = new System.Drawing.Point(258, 67);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(237, 20);
            this.campoApellidos.TabIndex = 18;
            // 
            // campoNombre
            // 
            this.campoNombre.Enabled = false;
            this.campoNombre.Location = new System.Drawing.Point(258, 37);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(143, 20);
            this.campoNombre.TabIndex = 19;
            this.campoNombre.TextChanged += new System.EventHandler(this.campoNombre_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(239, 570);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(176, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Enabled = false;
            this.btnEnviarEmail.Location = new System.Drawing.Point(487, 570);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(176, 23);
            this.btnEnviarEmail.TabIndex = 8;
            this.btnEnviarEmail.Text = "Enviar email";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            // 
            // btnPdf
            // 
            this.btnPdf.Enabled = false;
            this.btnPdf.Location = new System.Drawing.Point(736, 570);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(176, 23);
            this.btnPdf.TabIndex = 9;
            this.btnPdf.Text = "Ficha PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // BuscarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 631);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.campoDni);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.groupDatosPersonales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 670);
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "BuscarCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Candidatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupDatosPersonales.ResumeLayout(false);
            this.groupDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupDatosPersonales;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.TextBox campoDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoFechaNacimiento;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.TextBox campoCp;
        private System.Windows.Forms.TextBox campoLocalidad;
        private System.Windows.Forms.TextBox campoTelefono;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoFechaAlta;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnPdf;
    }
}
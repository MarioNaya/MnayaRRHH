namespace MnayaRRHH.Vistas
{
    partial class AltaAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAdministracion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPersonales = new System.Windows.Forms.GroupBox();
            this.campoFoto = new System.Windows.Forms.TextBox();
            this.comboLocalidad = new System.Windows.Forms.ComboBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            this.campoCp = new System.Windows.Forms.TextBox();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.campoDni = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.datePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupComplementarios = new System.Windows.Forms.GroupBox();
            this.groupInternet = new System.Windows.Forms.GroupBox();
            this.checkInternetAvanzado = new System.Windows.Forms.CheckBox();
            this.checkInternetMedio = new System.Windows.Forms.CheckBox();
            this.checkInternetUsuario = new System.Windows.Forms.CheckBox();
            this.groupCalculo = new System.Windows.Forms.GroupBox();
            this.checkCalculoAvanzado = new System.Windows.Forms.CheckBox();
            this.checkCalculoMedio = new System.Windows.Forms.CheckBox();
            this.checkCalculoUsuario = new System.Windows.Forms.CheckBox();
            this.campoObservaciones = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupTextos = new System.Windows.Forms.GroupBox();
            this.checkTextosAvanzado = new System.Windows.Forms.CheckBox();
            this.checkTextosMedio = new System.Windows.Forms.CheckBox();
            this.checkTextosUsuario = new System.Windows.Forms.CheckBox();
            this.comboEstudios = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupPersonales.SuspendLayout();
            this.groupComplementarios.SuspendLayout();
            this.groupInternet.SuspendLayout();
            this.groupCalculo.SuspendLayout();
            this.groupTextos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de candidatos para puestos de administración";
            // 
            // groupPersonales
            // 
            this.groupPersonales.Controls.Add(this.campoFoto);
            this.groupPersonales.Controls.Add(this.comboLocalidad);
            this.groupPersonales.Controls.Add(this.campoEmail);
            this.groupPersonales.Controls.Add(this.campoTelefono);
            this.groupPersonales.Controls.Add(this.campoCp);
            this.groupPersonales.Controls.Add(this.campoDireccion);
            this.groupPersonales.Controls.Add(this.campoDni);
            this.groupPersonales.Controls.Add(this.campoApellidos);
            this.groupPersonales.Controls.Add(this.campoNombre);
            this.groupPersonales.Controls.Add(this.btnFoto);
            this.groupPersonales.Controls.Add(this.datePickerNacimiento);
            this.groupPersonales.Controls.Add(this.label11);
            this.groupPersonales.Controls.Add(this.label10);
            this.groupPersonales.Controls.Add(this.label9);
            this.groupPersonales.Controls.Add(this.label8);
            this.groupPersonales.Controls.Add(this.label7);
            this.groupPersonales.Controls.Add(this.label6);
            this.groupPersonales.Controls.Add(this.label5);
            this.groupPersonales.Controls.Add(this.label4);
            this.groupPersonales.Controls.Add(this.label3);
            this.groupPersonales.Controls.Add(this.label2);
            this.groupPersonales.ForeColor = System.Drawing.Color.Firebrick;
            this.groupPersonales.Location = new System.Drawing.Point(36, 90);
            this.groupPersonales.Name = "groupPersonales";
            this.groupPersonales.Size = new System.Drawing.Size(495, 437);
            this.groupPersonales.TabIndex = 1;
            this.groupPersonales.TabStop = false;
            this.groupPersonales.Text = "DATOS PERSONALES";
            // 
            // campoFoto
            // 
            this.campoFoto.Enabled = false;
            this.campoFoto.Location = new System.Drawing.Point(226, 382);
            this.campoFoto.Name = "campoFoto";
            this.campoFoto.Size = new System.Drawing.Size(231, 20);
            this.campoFoto.TabIndex = 21;
            this.campoFoto.Tag = "FOTO";
            // 
            // comboLocalidad
            // 
            this.comboLocalidad.FormattingEnabled = true;
            this.comboLocalidad.Location = new System.Drawing.Point(136, 264);
            this.comboLocalidad.Name = "comboLocalidad";
            this.comboLocalidad.Size = new System.Drawing.Size(149, 21);
            this.comboLocalidad.TabIndex = 20;
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(136, 344);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(321, 20);
            this.campoEmail.TabIndex = 19;
            this.campoEmail.Tag = "EMAIL";
            // 
            // campoTelefono
            // 
            this.campoTelefono.Location = new System.Drawing.Point(136, 304);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(149, 20);
            this.campoTelefono.TabIndex = 18;
            this.campoTelefono.Tag = "TELÉFONO";
            // 
            // campoCp
            // 
            this.campoCp.Location = new System.Drawing.Point(136, 223);
            this.campoCp.Name = "campoCp";
            this.campoCp.Size = new System.Drawing.Size(112, 20);
            this.campoCp.TabIndex = 16;
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(136, 179);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(321, 20);
            this.campoDireccion.TabIndex = 15;
            this.campoDireccion.Tag = "DIRECCIÓN";
            // 
            // campoDni
            // 
            this.campoDni.Location = new System.Drawing.Point(136, 104);
            this.campoDni.Name = "campoDni";
            this.campoDni.Size = new System.Drawing.Size(112, 20);
            this.campoDni.TabIndex = 14;
            this.campoDni.Tag = "DNI";
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(136, 67);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(200, 20);
            this.campoApellidos.TabIndex = 13;
            this.campoApellidos.Tag = "APELLIDOS";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(136, 33);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(200, 20);
            this.campoNombre.TabIndex = 12;
            this.campoNombre.Tag = "NOMBRE";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(136, 380);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 11;
            this.btnFoto.Text = "Anexar foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // datePickerNacimiento
            // 
            this.datePickerNacimiento.Location = new System.Drawing.Point(136, 142);
            this.datePickerNacimiento.Name = "datePickerNacimiento";
            this.datePickerNacimiento.Size = new System.Drawing.Size(200, 20);
            this.datePickerNacimiento.TabIndex = 10;
            this.datePickerNacimiento.Tag = "FECHA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Foto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Localidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "CP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "F. de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // groupComplementarios
            // 
            this.groupComplementarios.Controls.Add(this.groupInternet);
            this.groupComplementarios.Controls.Add(this.groupCalculo);
            this.groupComplementarios.Controls.Add(this.campoObservaciones);
            this.groupComplementarios.Controls.Add(this.label14);
            this.groupComplementarios.Controls.Add(this.groupTextos);
            this.groupComplementarios.Controls.Add(this.comboEstudios);
            this.groupComplementarios.Controls.Add(this.label13);
            this.groupComplementarios.Controls.Add(this.label12);
            this.groupComplementarios.ForeColor = System.Drawing.Color.Firebrick;
            this.groupComplementarios.Location = new System.Drawing.Point(547, 90);
            this.groupComplementarios.Name = "groupComplementarios";
            this.groupComplementarios.Size = new System.Drawing.Size(498, 437);
            this.groupComplementarios.TabIndex = 2;
            this.groupComplementarios.TabStop = false;
            this.groupComplementarios.Text = "DATOS COMPLEMENTARIOS";
            // 
            // groupInternet
            // 
            this.groupInternet.Controls.Add(this.checkInternetAvanzado);
            this.groupInternet.Controls.Add(this.checkInternetMedio);
            this.groupInternet.Controls.Add(this.checkInternetUsuario);
            this.groupInternet.ForeColor = System.Drawing.Color.Firebrick;
            this.groupInternet.Location = new System.Drawing.Point(30, 239);
            this.groupInternet.Name = "groupInternet";
            this.groupInternet.Size = new System.Drawing.Size(440, 44);
            this.groupInternet.TabIndex = 4;
            this.groupInternet.TabStop = false;
            this.groupInternet.Text = "Internet";
            // 
            // checkInternetAvanzado
            // 
            this.checkInternetAvanzado.AutoSize = true;
            this.checkInternetAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInternetAvanzado.Location = new System.Drawing.Point(324, 19);
            this.checkInternetAvanzado.Name = "checkInternetAvanzado";
            this.checkInternetAvanzado.Size = new System.Drawing.Size(79, 19);
            this.checkInternetAvanzado.TabIndex = 2;
            this.checkInternetAvanzado.Text = "Avanzado";
            this.checkInternetAvanzado.UseVisualStyleBackColor = true;
            // 
            // checkInternetMedio
            // 
            this.checkInternetMedio.AutoSize = true;
            this.checkInternetMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInternetMedio.Location = new System.Drawing.Point(175, 19);
            this.checkInternetMedio.Name = "checkInternetMedio";
            this.checkInternetMedio.Size = new System.Drawing.Size(61, 19);
            this.checkInternetMedio.TabIndex = 1;
            this.checkInternetMedio.Text = "Medio";
            this.checkInternetMedio.UseVisualStyleBackColor = true;
            // 
            // checkInternetUsuario
            // 
            this.checkInternetUsuario.AutoSize = true;
            this.checkInternetUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInternetUsuario.Location = new System.Drawing.Point(27, 19);
            this.checkInternetUsuario.Name = "checkInternetUsuario";
            this.checkInternetUsuario.Size = new System.Drawing.Size(69, 19);
            this.checkInternetUsuario.TabIndex = 0;
            this.checkInternetUsuario.Text = "Usuario";
            this.checkInternetUsuario.UseVisualStyleBackColor = true;
            // 
            // groupCalculo
            // 
            this.groupCalculo.Controls.Add(this.checkCalculoAvanzado);
            this.groupCalculo.Controls.Add(this.checkCalculoMedio);
            this.groupCalculo.Controls.Add(this.checkCalculoUsuario);
            this.groupCalculo.ForeColor = System.Drawing.Color.Firebrick;
            this.groupCalculo.Location = new System.Drawing.Point(30, 177);
            this.groupCalculo.Name = "groupCalculo";
            this.groupCalculo.Size = new System.Drawing.Size(440, 44);
            this.groupCalculo.TabIndex = 7;
            this.groupCalculo.TabStop = false;
            this.groupCalculo.Text = "Hoja de cálculo";
            // 
            // checkCalculoAvanzado
            // 
            this.checkCalculoAvanzado.AutoSize = true;
            this.checkCalculoAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCalculoAvanzado.Location = new System.Drawing.Point(324, 19);
            this.checkCalculoAvanzado.Name = "checkCalculoAvanzado";
            this.checkCalculoAvanzado.Size = new System.Drawing.Size(79, 19);
            this.checkCalculoAvanzado.TabIndex = 2;
            this.checkCalculoAvanzado.Text = "Avanzado";
            this.checkCalculoAvanzado.UseVisualStyleBackColor = true;
            // 
            // checkCalculoMedio
            // 
            this.checkCalculoMedio.AutoSize = true;
            this.checkCalculoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCalculoMedio.Location = new System.Drawing.Point(175, 19);
            this.checkCalculoMedio.Name = "checkCalculoMedio";
            this.checkCalculoMedio.Size = new System.Drawing.Size(61, 19);
            this.checkCalculoMedio.TabIndex = 1;
            this.checkCalculoMedio.Text = "Medio";
            this.checkCalculoMedio.UseVisualStyleBackColor = true;
            // 
            // checkCalculoUsuario
            // 
            this.checkCalculoUsuario.AutoSize = true;
            this.checkCalculoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCalculoUsuario.Location = new System.Drawing.Point(27, 19);
            this.checkCalculoUsuario.Name = "checkCalculoUsuario";
            this.checkCalculoUsuario.Size = new System.Drawing.Size(69, 19);
            this.checkCalculoUsuario.TabIndex = 0;
            this.checkCalculoUsuario.Text = "Usuario";
            this.checkCalculoUsuario.UseVisualStyleBackColor = true;
            // 
            // campoObservaciones
            // 
            this.campoObservaciones.Location = new System.Drawing.Point(30, 334);
            this.campoObservaciones.Multiline = true;
            this.campoObservaciones.Name = "campoObservaciones";
            this.campoObservaciones.Size = new System.Drawing.Size(440, 68);
            this.campoObservaciones.TabIndex = 6;
            this.campoObservaciones.Tag = "OBSERVACIONES";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Observaciones";
            // 
            // groupTextos
            // 
            this.groupTextos.Controls.Add(this.checkTextosAvanzado);
            this.groupTextos.Controls.Add(this.checkTextosMedio);
            this.groupTextos.Controls.Add(this.checkTextosUsuario);
            this.groupTextos.ForeColor = System.Drawing.Color.Firebrick;
            this.groupTextos.Location = new System.Drawing.Point(30, 116);
            this.groupTextos.Name = "groupTextos";
            this.groupTextos.Size = new System.Drawing.Size(440, 44);
            this.groupTextos.TabIndex = 3;
            this.groupTextos.TabStop = false;
            this.groupTextos.Text = "Tratamiento de textos";
            // 
            // checkTextosAvanzado
            // 
            this.checkTextosAvanzado.AutoSize = true;
            this.checkTextosAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTextosAvanzado.Location = new System.Drawing.Point(324, 19);
            this.checkTextosAvanzado.Name = "checkTextosAvanzado";
            this.checkTextosAvanzado.Size = new System.Drawing.Size(79, 19);
            this.checkTextosAvanzado.TabIndex = 2;
            this.checkTextosAvanzado.Text = "Avanzado";
            this.checkTextosAvanzado.UseVisualStyleBackColor = true;
            // 
            // checkTextosMedio
            // 
            this.checkTextosMedio.AutoSize = true;
            this.checkTextosMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTextosMedio.Location = new System.Drawing.Point(175, 19);
            this.checkTextosMedio.Name = "checkTextosMedio";
            this.checkTextosMedio.Size = new System.Drawing.Size(61, 19);
            this.checkTextosMedio.TabIndex = 1;
            this.checkTextosMedio.Text = "Medio";
            this.checkTextosMedio.UseVisualStyleBackColor = true;
            // 
            // checkTextosUsuario
            // 
            this.checkTextosUsuario.AutoSize = true;
            this.checkTextosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTextosUsuario.Location = new System.Drawing.Point(27, 19);
            this.checkTextosUsuario.Name = "checkTextosUsuario";
            this.checkTextosUsuario.Size = new System.Drawing.Size(69, 19);
            this.checkTextosUsuario.TabIndex = 0;
            this.checkTextosUsuario.Text = "Usuario";
            this.checkTextosUsuario.UseVisualStyleBackColor = true;
            // 
            // comboEstudios
            // 
            this.comboEstudios.FormattingEnabled = true;
            this.comboEstudios.Location = new System.Drawing.Point(165, 33);
            this.comboEstudios.Name = "comboEstudios";
            this.comboEstudios.Size = new System.Drawing.Size(174, 21);
            this.comboEstudios.TabIndex = 2;
            this.comboEstudios.Tag = "ESTUDIOS FINALIZADOS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nivel informática";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Estudios finalizados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "REGISTRAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AltaAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupComplementarios);
            this.Controls.Add(this.groupPersonales);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 670);
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "AltaAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaAdministracion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupPersonales.ResumeLayout(false);
            this.groupPersonales.PerformLayout();
            this.groupComplementarios.ResumeLayout(false);
            this.groupComplementarios.PerformLayout();
            this.groupInternet.ResumeLayout(false);
            this.groupInternet.PerformLayout();
            this.groupCalculo.ResumeLayout(false);
            this.groupCalculo.PerformLayout();
            this.groupTextos.ResumeLayout(false);
            this.groupTextos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupPersonales;
        private System.Windows.Forms.GroupBox groupComplementarios;
        private System.Windows.Forms.DateTimePicker datePickerNacimiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoFoto;
        private System.Windows.Forms.ComboBox comboLocalidad;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoTelefono;
        private System.Windows.Forms.TextBox campoCp;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.TextBox campoDni;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.TextBox campoObservaciones;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupTextos;
        private System.Windows.Forms.CheckBox checkTextosAvanzado;
        private System.Windows.Forms.CheckBox checkTextosMedio;
        private System.Windows.Forms.CheckBox checkTextosUsuario;
        private System.Windows.Forms.ComboBox comboEstudios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupInternet;
        private System.Windows.Forms.CheckBox checkInternetAvanzado;
        private System.Windows.Forms.CheckBox checkInternetMedio;
        private System.Windows.Forms.CheckBox checkInternetUsuario;
        private System.Windows.Forms.GroupBox groupCalculo;
        private System.Windows.Forms.CheckBox checkCalculoAvanzado;
        private System.Windows.Forms.CheckBox checkCalculoMedio;
        private System.Windows.Forms.CheckBox checkCalculoUsuario;
        private System.Windows.Forms.Button button1;
    }
}
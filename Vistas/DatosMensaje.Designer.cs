namespace MnayaRRHH.Vistas
{
    partial class DatosMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosMensaje));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaCita = new System.Windows.Forms.DateTimePicker();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.labelAviso = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha y hora de convocatoria";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-1, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 23);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especifique fecha y hora de convocatoria para entrevista de trabajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora";
            // 
            // fechaCita
            // 
            this.fechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCita.Location = new System.Drawing.Point(183, 127);
            this.fechaCita.Name = "fechaCita";
            this.fechaCita.Size = new System.Drawing.Size(200, 20);
            this.fechaCita.TabIndex = 5;
            // 
            // comboHora
            // 
            this.comboHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Items.AddRange(new object[] {
            "Seleccione",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00"});
            this.comboHora.Location = new System.Drawing.Point(183, 167);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(72, 21);
            this.comboHora.TabIndex = 6;
            this.comboHora.SelectedIndexChanged += new System.EventHandler(this.comboHora_SelectedIndexChanged);
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.ForeColor = System.Drawing.Color.Red;
            this.labelAviso.Location = new System.Drawing.Point(276, 170);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(135, 13);
            this.labelAviso.TabIndex = 7;
            this.labelAviso.Text = "Debe seleccionar una hora";
            this.labelAviso.Visible = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(202, 228);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(139, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar Correo";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // DatosMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.comboHora);
            this.Controls.Add(this.fechaCita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "DatosMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosMensaje";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaCita;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.Button btnEnviar;
    }
}
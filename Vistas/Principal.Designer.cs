namespace MnayaRRHH.Vistas
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelip = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.layoutBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAltaAdmin = new System.Windows.Forms.Button();
            this.btnAltaAlmacen = new System.Windows.Forms.Button();
            this.btnListaCandidatos = new System.Windows.Forms.Button();
            this.btnBuscaCandidatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelAlmacen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaAlmacen = new System.Windows.Forms.DataGridView();
            this.tablaAdmin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.layoutBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.IndianRed;
            this.labelNombre.Location = new System.Drawing.Point(67, 44);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(35, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "label1";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.ForeColor = System.Drawing.Color.IndianRed;
            this.labelFecha.Location = new System.Drawing.Point(67, 72);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(35, 13);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "label2";
            // 
            // labelip
            // 
            this.labelip.AutoSize = true;
            this.labelip.ForeColor = System.Drawing.Color.IndianRed;
            this.labelip.Location = new System.Drawing.Point(67, 101);
            this.labelip.Name = "labelip";
            this.labelip.Size = new System.Drawing.Size(35, 13);
            this.labelip.TabIndex = 2;
            this.labelip.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MnayaRRHH.Properties.Resources.logotalento;
            this.pictureBox1.Location = new System.Drawing.Point(1018, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // layoutBotones
            // 
            this.layoutBotones.Controls.Add(this.btnAltaAdmin);
            this.layoutBotones.Controls.Add(this.btnAltaAlmacen);
            this.layoutBotones.Controls.Add(this.btnListaCandidatos);
            this.layoutBotones.Controls.Add(this.btnBuscaCandidatos);
            this.layoutBotones.Location = new System.Drawing.Point(114, 174);
            this.layoutBotones.Name = "layoutBotones";
            this.layoutBotones.Size = new System.Drawing.Size(955, 107);
            this.layoutBotones.TabIndex = 4;
            // 
            // btnAltaAdmin
            // 
            this.btnAltaAdmin.BackColor = System.Drawing.Color.IndianRed;
            this.btnAltaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAltaAdmin.Location = new System.Drawing.Point(3, 3);
            this.btnAltaAdmin.Name = "btnAltaAdmin";
            this.btnAltaAdmin.Size = new System.Drawing.Size(189, 97);
            this.btnAltaAdmin.TabIndex = 0;
            this.btnAltaAdmin.Text = "Alta de candidatos para administración";
            this.btnAltaAdmin.UseVisualStyleBackColor = false;
            // 
            // btnAltaAlmacen
            // 
            this.btnAltaAlmacen.BackColor = System.Drawing.Color.IndianRed;
            this.btnAltaAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnAltaAlmacen.Location = new System.Drawing.Point(255, 3);
            this.btnAltaAlmacen.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.btnAltaAlmacen.Name = "btnAltaAlmacen";
            this.btnAltaAlmacen.Size = new System.Drawing.Size(189, 97);
            this.btnAltaAlmacen.TabIndex = 1;
            this.btnAltaAlmacen.Text = "Alta de candidatos para almacén";
            this.btnAltaAlmacen.UseVisualStyleBackColor = false;
            // 
            // btnListaCandidatos
            // 
            this.btnListaCandidatos.BackColor = System.Drawing.Color.IndianRed;
            this.btnListaCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCandidatos.ForeColor = System.Drawing.Color.White;
            this.btnListaCandidatos.Location = new System.Drawing.Point(507, 3);
            this.btnListaCandidatos.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.btnListaCandidatos.Name = "btnListaCandidatos";
            this.btnListaCandidatos.Size = new System.Drawing.Size(189, 97);
            this.btnListaCandidatos.TabIndex = 2;
            this.btnListaCandidatos.Text = "Listados de candidatos";
            this.btnListaCandidatos.UseVisualStyleBackColor = false;
            // 
            // btnBuscaCandidatos
            // 
            this.btnBuscaCandidatos.BackColor = System.Drawing.Color.IndianRed;
            this.btnBuscaCandidatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCandidatos.ForeColor = System.Drawing.Color.White;
            this.btnBuscaCandidatos.Location = new System.Drawing.Point(759, 3);
            this.btnBuscaCandidatos.Margin = new System.Windows.Forms.Padding(60, 3, 3, 3);
            this.btnBuscaCandidatos.Name = "btnBuscaCandidatos";
            this.btnBuscaCandidatos.Size = new System.Drawing.Size(189, 97);
            this.btnBuscaCandidatos.TabIndex = 3;
            this.btnBuscaCandidatos.Text = "Buscar candidatos";
            this.btnBuscaCandidatos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Candidatos Administración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(755, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Candidatos Almacén";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(275, 363);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(69, 73);
            this.labelAdmin.TabIndex = 7;
            this.labelAdmin.Text = "0";
            // 
            // labelAlmacen
            // 
            this.labelAlmacen.AutoSize = true;
            this.labelAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlmacen.Location = new System.Drawing.Point(805, 363);
            this.labelAlmacen.Name = "labelAlmacen";
            this.labelAlmacen.Size = new System.Drawing.Size(69, 73);
            this.labelAlmacen.TabIndex = 8;
            this.labelAlmacen.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Últimos Candidatos Registrados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(722, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Últimos Candidatos Registrados";
            // 
            // tablaAlmacen
            // 
            this.tablaAlmacen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tablaAlmacen.AllowUserToAddRows = false;
            this.tablaAlmacen.AllowUserToDeleteRows = false;
            this.tablaAlmacen.AllowUserToResizeColumns = false;
            this.tablaAlmacen.AllowUserToResizeRows = false;
            this.tablaAlmacen.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaAlmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaAlmacen.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaAlmacen.Enabled = false;
            this.tablaAlmacen.EnableHeadersVisualStyles = false;
            this.tablaAlmacen.Location = new System.Drawing.Point(659, 536);
            this.tablaAlmacen.Name = "tablaAlmacen";
            this.tablaAlmacen.ReadOnly = true;
            this.tablaAlmacen.RowHeadersVisible = false;
            this.tablaAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaAlmacen.Size = new System.Drawing.Size(403, 86);
            this.tablaAlmacen.TabIndex = 12;
            // 
            // tablaAdmin
            // 
            this.tablaAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tablaAdmin.AllowUserToAddRows = false;
            this.tablaAdmin.AllowUserToDeleteRows = false;
            this.tablaAdmin.AllowUserToResizeColumns = false;
            this.tablaAdmin.AllowUserToResizeRows = false;
            this.tablaAdmin.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaAdmin.DefaultCellStyle = dataGridViewCellStyle4;
            this.tablaAdmin.Enabled = false;
            this.tablaAdmin.EnableHeadersVisualStyles = false;
            this.tablaAdmin.Location = new System.Drawing.Point(117, 536);
            this.tablaAdmin.Name = "tablaAdmin";
            this.tablaAdmin.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaAdmin.RowHeadersVisible = false;
            this.tablaAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaAdmin.Size = new System.Drawing.Size(403, 86);
            this.tablaAdmin.TabIndex = 13;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 686);
            this.Controls.Add(this.tablaAdmin);
            this.Controls.Add(this.tablaAlmacen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAlmacen);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.layoutBotones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelip);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 725);
            this.MinimumSize = new System.Drawing.Size(1200, 725);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RRHH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.layoutBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel layoutBotones;
        private System.Windows.Forms.Button btnAltaAdmin;
        private System.Windows.Forms.Button btnAltaAlmacen;
        private System.Windows.Forms.Button btnListaCandidatos;
        private System.Windows.Forms.Button btnBuscaCandidatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelAlmacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaAlmacen;
        private System.Windows.Forms.DataGridView tablaAdmin;
    }
}
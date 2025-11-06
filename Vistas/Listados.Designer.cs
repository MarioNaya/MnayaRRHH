namespace MnayaRRHH.Vistas
{
    partial class Listados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listados));
            this.label1 = new System.Windows.Forms.Label();
            this.groupAdmin = new System.Windows.Forms.GroupBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.groupInternet = new System.Windows.Forms.GroupBox();
            this.radioInternetAvanzado = new System.Windows.Forms.RadioButton();
            this.radioInternetMedio = new System.Windows.Forms.RadioButton();
            this.radioInternetUsuario = new System.Windows.Forms.RadioButton();
            this.radioInternetTodos = new System.Windows.Forms.RadioButton();
            this.groupCalculo = new System.Windows.Forms.GroupBox();
            this.radioCalculoAvanzado = new System.Windows.Forms.RadioButton();
            this.radioCalculoMedio = new System.Windows.Forms.RadioButton();
            this.radioCalculoUsuario = new System.Windows.Forms.RadioButton();
            this.radioCalculoTodos = new System.Windows.Forms.RadioButton();
            this.GroupTextos = new System.Windows.Forms.GroupBox();
            this.radioTextosAvanzado = new System.Windows.Forms.RadioButton();
            this.radioTextosMedio = new System.Windows.Forms.RadioButton();
            this.radioTextosUsuario = new System.Windows.Forms.RadioButton();
            this.radioTextosTodos = new System.Windows.Forms.RadioButton();
            this.comboAdminEstudios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupAlmacen = new System.Windows.Forms.GroupBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboAlmacenEstudios = new System.Windows.Forms.ComboBox();
            this.groupCarnets = new System.Windows.Forms.GroupBox();
            this.groupFiltroAlmacen = new System.Windows.Forms.Panel();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupAdmin.SuspendLayout();
            this.groupInternet.SuspendLayout();
            this.groupCalculo.SuspendLayout();
            this.GroupTextos.SuspendLayout();
            this.groupAlmacen.SuspendLayout();
            this.groupCarnets.SuspendLayout();
            this.groupFiltroAlmacen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de candidatos";
            // 
            // groupAdmin
            // 
            this.groupAdmin.Controls.Add(this.btnAdmin);
            this.groupAdmin.Controls.Add(this.groupInternet);
            this.groupAdmin.Controls.Add(this.groupCalculo);
            this.groupAdmin.Controls.Add(this.GroupTextos);
            this.groupAdmin.Controls.Add(this.comboAdminEstudios);
            this.groupAdmin.Controls.Add(this.label2);
            this.groupAdmin.Location = new System.Drawing.Point(51, 79);
            this.groupAdmin.Name = "groupAdmin";
            this.groupAdmin.Size = new System.Drawing.Size(452, 266);
            this.groupAdmin.TabIndex = 1;
            this.groupAdmin.TabStop = false;
            this.groupAdmin.Text = "Filtros Administración";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(156, 225);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(120, 23);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Mostrar listado";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // groupInternet
            // 
            this.groupInternet.Controls.Add(this.radioInternetAvanzado);
            this.groupInternet.Controls.Add(this.radioInternetMedio);
            this.groupInternet.Controls.Add(this.radioInternetUsuario);
            this.groupInternet.Controls.Add(this.radioInternetTodos);
            this.groupInternet.ForeColor = System.Drawing.Color.Firebrick;
            this.groupInternet.Location = new System.Drawing.Point(30, 164);
            this.groupInternet.Name = "groupInternet";
            this.groupInternet.Size = new System.Drawing.Size(384, 44);
            this.groupInternet.TabIndex = 4;
            this.groupInternet.TabStop = false;
            this.groupInternet.Text = "Internet";
            // 
            // radioInternetAvanzado
            // 
            this.radioInternetAvanzado.AutoSize = true;
            this.radioInternetAvanzado.Location = new System.Drawing.Point(281, 19);
            this.radioInternetAvanzado.Name = "radioInternetAvanzado";
            this.radioInternetAvanzado.Size = new System.Drawing.Size(73, 17);
            this.radioInternetAvanzado.TabIndex = 3;
            this.radioInternetAvanzado.TabStop = true;
            this.radioInternetAvanzado.Text = "Avanzado";
            this.radioInternetAvanzado.UseVisualStyleBackColor = true;
            // 
            // radioInternetMedio
            // 
            this.radioInternetMedio.AutoSize = true;
            this.radioInternetMedio.Location = new System.Drawing.Point(203, 19);
            this.radioInternetMedio.Name = "radioInternetMedio";
            this.radioInternetMedio.Size = new System.Drawing.Size(54, 17);
            this.radioInternetMedio.TabIndex = 2;
            this.radioInternetMedio.TabStop = true;
            this.radioInternetMedio.Text = "Medio";
            this.radioInternetMedio.UseVisualStyleBackColor = true;
            // 
            // radioInternetUsuario
            // 
            this.radioInternetUsuario.AutoSize = true;
            this.radioInternetUsuario.Location = new System.Drawing.Point(116, 19);
            this.radioInternetUsuario.Name = "radioInternetUsuario";
            this.radioInternetUsuario.Size = new System.Drawing.Size(61, 17);
            this.radioInternetUsuario.TabIndex = 1;
            this.radioInternetUsuario.TabStop = true;
            this.radioInternetUsuario.Text = "Usuario";
            this.radioInternetUsuario.UseVisualStyleBackColor = true;
            // 
            // radioInternetTodos
            // 
            this.radioInternetTodos.AutoSize = true;
            this.radioInternetTodos.Location = new System.Drawing.Point(41, 19);
            this.radioInternetTodos.Name = "radioInternetTodos";
            this.radioInternetTodos.Size = new System.Drawing.Size(55, 17);
            this.radioInternetTodos.TabIndex = 0;
            this.radioInternetTodos.TabStop = true;
            this.radioInternetTodos.Text = "Todos";
            this.radioInternetTodos.UseVisualStyleBackColor = true;
            // 
            // groupCalculo
            // 
            this.groupCalculo.Controls.Add(this.radioCalculoAvanzado);
            this.groupCalculo.Controls.Add(this.radioCalculoMedio);
            this.groupCalculo.Controls.Add(this.radioCalculoUsuario);
            this.groupCalculo.Controls.Add(this.radioCalculoTodos);
            this.groupCalculo.ForeColor = System.Drawing.Color.Firebrick;
            this.groupCalculo.Location = new System.Drawing.Point(30, 114);
            this.groupCalculo.Name = "groupCalculo";
            this.groupCalculo.Size = new System.Drawing.Size(384, 44);
            this.groupCalculo.TabIndex = 3;
            this.groupCalculo.TabStop = false;
            this.groupCalculo.Text = "Hoja de cálculo";
            // 
            // radioCalculoAvanzado
            // 
            this.radioCalculoAvanzado.AutoSize = true;
            this.radioCalculoAvanzado.Location = new System.Drawing.Point(281, 19);
            this.radioCalculoAvanzado.Name = "radioCalculoAvanzado";
            this.radioCalculoAvanzado.Size = new System.Drawing.Size(73, 17);
            this.radioCalculoAvanzado.TabIndex = 3;
            this.radioCalculoAvanzado.TabStop = true;
            this.radioCalculoAvanzado.Text = "Avanzado";
            this.radioCalculoAvanzado.UseVisualStyleBackColor = true;
            // 
            // radioCalculoMedio
            // 
            this.radioCalculoMedio.AutoSize = true;
            this.radioCalculoMedio.Location = new System.Drawing.Point(203, 19);
            this.radioCalculoMedio.Name = "radioCalculoMedio";
            this.radioCalculoMedio.Size = new System.Drawing.Size(54, 17);
            this.radioCalculoMedio.TabIndex = 2;
            this.radioCalculoMedio.TabStop = true;
            this.radioCalculoMedio.Text = "Medio";
            this.radioCalculoMedio.UseVisualStyleBackColor = true;
            // 
            // radioCalculoUsuario
            // 
            this.radioCalculoUsuario.AutoSize = true;
            this.radioCalculoUsuario.Location = new System.Drawing.Point(116, 19);
            this.radioCalculoUsuario.Name = "radioCalculoUsuario";
            this.radioCalculoUsuario.Size = new System.Drawing.Size(61, 17);
            this.radioCalculoUsuario.TabIndex = 1;
            this.radioCalculoUsuario.TabStop = true;
            this.radioCalculoUsuario.Text = "Usuario";
            this.radioCalculoUsuario.UseVisualStyleBackColor = true;
            // 
            // radioCalculoTodos
            // 
            this.radioCalculoTodos.AutoSize = true;
            this.radioCalculoTodos.Location = new System.Drawing.Point(41, 19);
            this.radioCalculoTodos.Name = "radioCalculoTodos";
            this.radioCalculoTodos.Size = new System.Drawing.Size(55, 17);
            this.radioCalculoTodos.TabIndex = 0;
            this.radioCalculoTodos.TabStop = true;
            this.radioCalculoTodos.Text = "Todos";
            this.radioCalculoTodos.UseVisualStyleBackColor = true;
            // 
            // GroupTextos
            // 
            this.GroupTextos.Controls.Add(this.radioTextosAvanzado);
            this.GroupTextos.Controls.Add(this.radioTextosMedio);
            this.GroupTextos.Controls.Add(this.radioTextosUsuario);
            this.GroupTextos.Controls.Add(this.radioTextosTodos);
            this.GroupTextos.ForeColor = System.Drawing.Color.Firebrick;
            this.GroupTextos.Location = new System.Drawing.Point(30, 64);
            this.GroupTextos.Name = "GroupTextos";
            this.GroupTextos.Size = new System.Drawing.Size(384, 44);
            this.GroupTextos.TabIndex = 2;
            this.GroupTextos.TabStop = false;
            this.GroupTextos.Text = "Tratamiento de textos";
            // 
            // radioTextosAvanzado
            // 
            this.radioTextosAvanzado.AutoSize = true;
            this.radioTextosAvanzado.Location = new System.Drawing.Point(281, 19);
            this.radioTextosAvanzado.Name = "radioTextosAvanzado";
            this.radioTextosAvanzado.Size = new System.Drawing.Size(73, 17);
            this.radioTextosAvanzado.TabIndex = 3;
            this.radioTextosAvanzado.TabStop = true;
            this.radioTextosAvanzado.Text = "Avanzado";
            this.radioTextosAvanzado.UseVisualStyleBackColor = true;
            // 
            // radioTextosMedio
            // 
            this.radioTextosMedio.AutoSize = true;
            this.radioTextosMedio.Location = new System.Drawing.Point(203, 19);
            this.radioTextosMedio.Name = "radioTextosMedio";
            this.radioTextosMedio.Size = new System.Drawing.Size(54, 17);
            this.radioTextosMedio.TabIndex = 2;
            this.radioTextosMedio.TabStop = true;
            this.radioTextosMedio.Text = "Medio";
            this.radioTextosMedio.UseVisualStyleBackColor = true;
            // 
            // radioTextosUsuario
            // 
            this.radioTextosUsuario.AutoSize = true;
            this.radioTextosUsuario.Location = new System.Drawing.Point(116, 19);
            this.radioTextosUsuario.Name = "radioTextosUsuario";
            this.radioTextosUsuario.Size = new System.Drawing.Size(61, 17);
            this.radioTextosUsuario.TabIndex = 1;
            this.radioTextosUsuario.TabStop = true;
            this.radioTextosUsuario.Text = "Usuario";
            this.radioTextosUsuario.UseVisualStyleBackColor = true;
            // 
            // radioTextosTodos
            // 
            this.radioTextosTodos.AutoSize = true;
            this.radioTextosTodos.Location = new System.Drawing.Point(41, 19);
            this.radioTextosTodos.Name = "radioTextosTodos";
            this.radioTextosTodos.Size = new System.Drawing.Size(55, 17);
            this.radioTextosTodos.TabIndex = 0;
            this.radioTextosTodos.TabStop = true;
            this.radioTextosTodos.Text = "Todos";
            this.radioTextosTodos.UseVisualStyleBackColor = true;
            // 
            // comboAdminEstudios
            // 
            this.comboAdminEstudios.FormattingEnabled = true;
            this.comboAdminEstudios.Location = new System.Drawing.Point(156, 28);
            this.comboAdminEstudios.Name = "comboAdminEstudios";
            this.comboAdminEstudios.Size = new System.Drawing.Size(210, 21);
            this.comboAdminEstudios.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estudios finalizados";
            // 
            // groupAlmacen
            // 
            this.groupAlmacen.Controls.Add(this.btnAlmacen);
            this.groupAlmacen.Controls.Add(this.groupFiltroAlmacen);
            this.groupAlmacen.Controls.Add(this.groupCarnets);
            this.groupAlmacen.Controls.Add(this.comboAlmacenEstudios);
            this.groupAlmacen.Controls.Add(this.label3);
            this.groupAlmacen.Location = new System.Drawing.Point(577, 79);
            this.groupAlmacen.Name = "groupAlmacen";
            this.groupAlmacen.Size = new System.Drawing.Size(452, 266);
            this.groupAlmacen.TabIndex = 2;
            this.groupAlmacen.TabStop = false;
            this.groupAlmacen.Text = "Filtros almacén";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(165, 36);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(162, 21);
            this.comboTipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Estudios finalizados";
            // 
            // comboAlmacenEstudios
            // 
            this.comboAlmacenEstudios.FormattingEnabled = true;
            this.comboAlmacenEstudios.Location = new System.Drawing.Point(165, 28);
            this.comboAlmacenEstudios.Name = "comboAlmacenEstudios";
            this.comboAlmacenEstudios.Size = new System.Drawing.Size(210, 21);
            this.comboAlmacenEstudios.TabIndex = 2;
            // 
            // groupCarnets
            // 
            this.groupCarnets.Controls.Add(this.checkBox3);
            this.groupCarnets.Controls.Add(this.checkBox2);
            this.groupCarnets.Controls.Add(this.checkBox1);
            this.groupCarnets.ForeColor = System.Drawing.Color.Firebrick;
            this.groupCarnets.Location = new System.Drawing.Point(36, 123);
            this.groupCarnets.Name = "groupCarnets";
            this.groupCarnets.Size = new System.Drawing.Size(365, 67);
            this.groupCarnets.TabIndex = 3;
            this.groupCarnets.TabStop = false;
            this.groupCarnets.Text = "CARNETS";
            // 
            // groupFiltroAlmacen
            // 
            this.groupFiltroAlmacen.Controls.Add(this.radioButton14);
            this.groupFiltroAlmacen.Controls.Add(this.radioButton13);
            this.groupFiltroAlmacen.Location = new System.Drawing.Point(36, 73);
            this.groupFiltroAlmacen.Name = "groupFiltroAlmacen";
            this.groupFiltroAlmacen.Size = new System.Drawing.Size(252, 42);
            this.groupFiltroAlmacen.TabIndex = 4;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(13, 14);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(55, 17);
            this.radioButton13.TabIndex = 0;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Todos";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(123, 14);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(50, 17);
            this.radioButton14.TabIndex = 0;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "Filtrar";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Carnet de conducir";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(135, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Carnet de carretilla";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(259, 31);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(110, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Carnet de Camión";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Location = new System.Drawing.Point(165, 225);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(120, 23);
            this.btnAlmacen.TabIndex = 6;
            this.btnAlmacen.Text = "Mostrar listado";
            this.btnAlmacen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(51, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(978, 228);
            this.dataGridView1.TabIndex = 4;
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.groupAlmacen);
            this.Controls.Add(this.groupAdmin);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Listados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados";
            this.groupAdmin.ResumeLayout(false);
            this.groupAdmin.PerformLayout();
            this.groupInternet.ResumeLayout(false);
            this.groupInternet.PerformLayout();
            this.groupCalculo.ResumeLayout(false);
            this.groupCalculo.PerformLayout();
            this.GroupTextos.ResumeLayout(false);
            this.GroupTextos.PerformLayout();
            this.groupAlmacen.ResumeLayout(false);
            this.groupAlmacen.PerformLayout();
            this.groupCarnets.ResumeLayout(false);
            this.groupCarnets.PerformLayout();
            this.groupFiltroAlmacen.ResumeLayout(false);
            this.groupFiltroAlmacen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupAdmin;
        private System.Windows.Forms.ComboBox comboAdminEstudios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupAlmacen;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.GroupBox groupInternet;
        private System.Windows.Forms.RadioButton radioInternetAvanzado;
        private System.Windows.Forms.RadioButton radioInternetMedio;
        private System.Windows.Forms.RadioButton radioInternetUsuario;
        private System.Windows.Forms.RadioButton radioInternetTodos;
        private System.Windows.Forms.GroupBox groupCalculo;
        private System.Windows.Forms.RadioButton radioCalculoAvanzado;
        private System.Windows.Forms.RadioButton radioCalculoMedio;
        private System.Windows.Forms.RadioButton radioCalculoUsuario;
        private System.Windows.Forms.RadioButton radioCalculoTodos;
        private System.Windows.Forms.GroupBox GroupTextos;
        private System.Windows.Forms.RadioButton radioTextosAvanzado;
        private System.Windows.Forms.RadioButton radioTextosMedio;
        private System.Windows.Forms.RadioButton radioTextosUsuario;
        private System.Windows.Forms.RadioButton radioTextosTodos;
        private System.Windows.Forms.Panel groupFiltroAlmacen;
        private System.Windows.Forms.GroupBox groupCarnets;
        private System.Windows.Forms.ComboBox comboAlmacenEstudios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
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
            this.groupTextos = new System.Windows.Forms.GroupBox();
            this.radioTextosAvanzado = new System.Windows.Forms.RadioButton();
            this.radioTextosMedio = new System.Windows.Forms.RadioButton();
            this.radioTextosUsuario = new System.Windows.Forms.RadioButton();
            this.radioTextosTodos = new System.Windows.Forms.RadioButton();
            this.comboAdminEstudios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupAlmacen = new System.Windows.Forms.GroupBox();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.groupFiltroAlmacen = new System.Windows.Forms.Panel();
            this.radioAlmacenFiltrar = new System.Windows.Forms.RadioButton();
            this.radioAlmacenTodos = new System.Windows.Forms.RadioButton();
            this.groupCarnets = new System.Windows.Forms.GroupBox();
            this.checkConducir = new System.Windows.Forms.CheckBox();
            this.checkCarretilla = new System.Windows.Forms.CheckBox();
            this.checkCamion = new System.Windows.Forms.CheckBox();
            this.comboAlmacenEstudios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.tablaCandidatos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupAdmin.SuspendLayout();
            this.groupInternet.SuspendLayout();
            this.groupCalculo.SuspendLayout();
            this.groupTextos.SuspendLayout();
            this.groupAlmacen.SuspendLayout();
            this.groupFiltroAlmacen.SuspendLayout();
            this.groupCarnets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCandidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupAdmin.Controls.Add(this.groupTextos);
            this.groupAdmin.Controls.Add(this.comboAdminEstudios);
            this.groupAdmin.Controls.Add(this.label2);
            this.groupAdmin.Enabled = false;
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
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
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
            // groupTextos
            // 
            this.groupTextos.Controls.Add(this.radioTextosAvanzado);
            this.groupTextos.Controls.Add(this.radioTextosMedio);
            this.groupTextos.Controls.Add(this.radioTextosUsuario);
            this.groupTextos.Controls.Add(this.radioTextosTodos);
            this.groupTextos.ForeColor = System.Drawing.Color.Firebrick;
            this.groupTextos.Location = new System.Drawing.Point(30, 64);
            this.groupTextos.Name = "groupTextos";
            this.groupTextos.Size = new System.Drawing.Size(384, 44);
            this.groupTextos.TabIndex = 2;
            this.groupTextos.TabStop = false;
            this.groupTextos.Text = "Tratamiento de textos";
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
            this.comboAdminEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAdminEstudios.FormattingEnabled = true;
            this.comboAdminEstudios.Items.AddRange(new object[] {
            "Seleccione",
            "ESO",
            "Grado Medio",
            "Bachillerato",
            "Grado Superior",
            "Universitarios"});
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
            this.groupAlmacen.Enabled = false;
            this.groupAlmacen.Location = new System.Drawing.Point(577, 79);
            this.groupAlmacen.Name = "groupAlmacen";
            this.groupAlmacen.Size = new System.Drawing.Size(452, 266);
            this.groupAlmacen.TabIndex = 2;
            this.groupAlmacen.TabStop = false;
            this.groupAlmacen.Text = "Filtros almacén";
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Location = new System.Drawing.Point(165, 225);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(120, 23);
            this.btnAlmacen.TabIndex = 6;
            this.btnAlmacen.Text = "Mostrar listado";
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // groupFiltroAlmacen
            // 
            this.groupFiltroAlmacen.Controls.Add(this.radioAlmacenFiltrar);
            this.groupFiltroAlmacen.Controls.Add(this.radioAlmacenTodos);
            this.groupFiltroAlmacen.Location = new System.Drawing.Point(36, 73);
            this.groupFiltroAlmacen.Name = "groupFiltroAlmacen";
            this.groupFiltroAlmacen.Size = new System.Drawing.Size(252, 42);
            this.groupFiltroAlmacen.TabIndex = 4;
            // 
            // radioAlmacenFiltrar
            // 
            this.radioAlmacenFiltrar.AutoSize = true;
            this.radioAlmacenFiltrar.Location = new System.Drawing.Point(123, 14);
            this.radioAlmacenFiltrar.Name = "radioAlmacenFiltrar";
            this.radioAlmacenFiltrar.Size = new System.Drawing.Size(50, 17);
            this.radioAlmacenFiltrar.TabIndex = 0;
            this.radioAlmacenFiltrar.TabStop = true;
            this.radioAlmacenFiltrar.Text = "Filtrar";
            this.radioAlmacenFiltrar.UseVisualStyleBackColor = true;
            this.radioAlmacenFiltrar.CheckedChanged += new System.EventHandler(this.radioAlmacenFiltrar_CheckedChanged);
            // 
            // radioAlmacenTodos
            // 
            this.radioAlmacenTodos.AutoSize = true;
            this.radioAlmacenTodos.Location = new System.Drawing.Point(13, 14);
            this.radioAlmacenTodos.Name = "radioAlmacenTodos";
            this.radioAlmacenTodos.Size = new System.Drawing.Size(55, 17);
            this.radioAlmacenTodos.TabIndex = 0;
            this.radioAlmacenTodos.TabStop = true;
            this.radioAlmacenTodos.Text = "Todos";
            this.radioAlmacenTodos.UseVisualStyleBackColor = true;
            this.radioAlmacenTodos.CheckedChanged += new System.EventHandler(this.radioAlmacenTodos_CheckedChanged);
            // 
            // groupCarnets
            // 
            this.groupCarnets.Controls.Add(this.checkConducir);
            this.groupCarnets.Controls.Add(this.checkCarretilla);
            this.groupCarnets.Controls.Add(this.checkCamion);
            this.groupCarnets.Enabled = false;
            this.groupCarnets.ForeColor = System.Drawing.Color.Firebrick;
            this.groupCarnets.Location = new System.Drawing.Point(36, 123);
            this.groupCarnets.Name = "groupCarnets";
            this.groupCarnets.Size = new System.Drawing.Size(365, 67);
            this.groupCarnets.TabIndex = 3;
            this.groupCarnets.TabStop = false;
            this.groupCarnets.Text = "CARNETS";
            // 
            // checkConducir
            // 
            this.checkConducir.AutoSize = true;
            this.checkConducir.Location = new System.Drawing.Point(13, 31);
            this.checkConducir.Name = "checkConducir";
            this.checkConducir.Size = new System.Drawing.Size(116, 17);
            this.checkConducir.TabIndex = 0;
            this.checkConducir.Text = "Carnet de conducir";
            this.checkConducir.UseVisualStyleBackColor = true;
            // 
            // checkCarretilla
            // 
            this.checkCarretilla.AutoSize = true;
            this.checkCarretilla.Location = new System.Drawing.Point(135, 31);
            this.checkCarretilla.Name = "checkCarretilla";
            this.checkCarretilla.Size = new System.Drawing.Size(114, 17);
            this.checkCarretilla.TabIndex = 0;
            this.checkCarretilla.Text = "Carnet de carretilla";
            this.checkCarretilla.UseVisualStyleBackColor = true;
            // 
            // checkCamion
            // 
            this.checkCamion.AutoSize = true;
            this.checkCamion.Location = new System.Drawing.Point(259, 31);
            this.checkCamion.Name = "checkCamion";
            this.checkCamion.Size = new System.Drawing.Size(110, 17);
            this.checkCamion.TabIndex = 0;
            this.checkCamion.Text = "Carnet de Camión";
            this.checkCamion.UseVisualStyleBackColor = true;
            // 
            // comboAlmacenEstudios
            // 
            this.comboAlmacenEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlmacenEstudios.FormattingEnabled = true;
            this.comboAlmacenEstudios.Items.AddRange(new object[] {
            "Seleccione",
            "ESO",
            "Grado Medio",
            "Bachillerato",
            "Grado Superior",
            "Universitarios"});
            this.comboAlmacenEstudios.Location = new System.Drawing.Point(165, 28);
            this.comboAlmacenEstudios.Name = "comboAlmacenEstudios";
            this.comboAlmacenEstudios.Size = new System.Drawing.Size(210, 21);
            this.comboAlmacenEstudios.TabIndex = 2;
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
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Seleccione",
            "Administración",
            "Almacén"});
            this.comboTipo.Location = new System.Drawing.Point(165, 36);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(162, 21);
            this.comboTipo.TabIndex = 3;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // tablaCandidatos
            // 
            this.tablaCandidatos.AllowUserToAddRows = false;
            this.tablaCandidatos.AllowUserToDeleteRows = false;
            this.tablaCandidatos.AllowUserToResizeColumns = false;
            this.tablaCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCandidatos.BackgroundColor = System.Drawing.Color.White;
            this.tablaCandidatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCandidatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCandidatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaCandidatos.GridColor = System.Drawing.SystemColors.Control;
            this.tablaCandidatos.Location = new System.Drawing.Point(51, 398);
            this.tablaCandidatos.Name = "tablaCandidatos";
            this.tablaCandidatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaCandidatos.RowHeadersVisible = false;
            this.tablaCandidatos.Size = new System.Drawing.Size(978, 228);
            this.tablaCandidatos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MnayaRRHH.Properties.Resources.excelIcon;
            this.pictureBox1.Location = new System.Drawing.Point(984, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tablaCandidatos);
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
            this.groupTextos.ResumeLayout(false);
            this.groupTextos.PerformLayout();
            this.groupAlmacen.ResumeLayout(false);
            this.groupAlmacen.PerformLayout();
            this.groupFiltroAlmacen.ResumeLayout(false);
            this.groupFiltroAlmacen.PerformLayout();
            this.groupCarnets.ResumeLayout(false);
            this.groupCarnets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCandidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupTextos;
        private System.Windows.Forms.RadioButton radioTextosAvanzado;
        private System.Windows.Forms.RadioButton radioTextosMedio;
        private System.Windows.Forms.RadioButton radioTextosUsuario;
        private System.Windows.Forms.RadioButton radioTextosTodos;
        private System.Windows.Forms.Panel groupFiltroAlmacen;
        private System.Windows.Forms.GroupBox groupCarnets;
        private System.Windows.Forms.ComboBox comboAlmacenEstudios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioAlmacenFiltrar;
        private System.Windows.Forms.RadioButton radioAlmacenTodos;
        private System.Windows.Forms.CheckBox checkCamion;
        private System.Windows.Forms.CheckBox checkCarretilla;
        private System.Windows.Forms.CheckBox checkConducir;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.DataGridView tablaCandidatos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
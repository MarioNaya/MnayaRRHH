namespace MnayaRRHH
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupLogin = new System.Windows.Forms.GroupBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.picturePass = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.campoUser = new System.Windows.Forms.TextBox();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MnayaRRHH.Properties.Resources.imglogin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MnayaRRHH.Properties.Resources.logotalento;
            this.pictureBox2.Location = new System.Drawing.Point(651, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupLogin
            // 
            this.groupLogin.Controls.Add(this.btnEntrar);
            this.groupLogin.Controls.Add(this.picturePass);
            this.groupLogin.Controls.Add(this.pictureUser);
            this.groupLogin.Controls.Add(this.campoUser);
            this.groupLogin.Controls.Add(this.campoPass);
            this.groupLogin.Controls.Add(this.label2);
            this.groupLogin.Controls.Add(this.label1);
            this.groupLogin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupLogin.Location = new System.Drawing.Point(555, 102);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Size = new System.Drawing.Size(283, 264);
            this.groupLogin.TabIndex = 2;
            this.groupLogin.TabStop = false;
            this.groupLogin.Text = "ACCEDER";
            this.groupLogin.Enter += new System.EventHandler(this.groupLogin_Enter);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(70, 185);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(151, 46);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // picturePass
            // 
            this.picturePass.Image = global::MnayaRRHH.Properties.Resources.pass;
            this.picturePass.Location = new System.Drawing.Point(225, 120);
            this.picturePass.Name = "picturePass";
            this.picturePass.Size = new System.Drawing.Size(41, 45);
            this.picturePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePass.TabIndex = 5;
            this.picturePass.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.Image = global::MnayaRRHH.Properties.Resources.user;
            this.pictureUser.Location = new System.Drawing.Point(225, 57);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(41, 45);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 4;
            this.pictureUser.TabStop = false;
            // 
            // campoUser
            // 
            this.campoUser.Location = new System.Drawing.Point(110, 68);
            this.campoUser.Name = "campoUser";
            this.campoUser.Size = new System.Drawing.Size(100, 20);
            this.campoUser.TabIndex = 2;
            this.campoUser.Tag = "USUARIO";
            this.campoUser.Enter += new System.EventHandler(this.campoUser_Enter);
            this.campoUser.Leave += new System.EventHandler(this.campoUser_Leave);
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(110, 131);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(100, 20);
            this.campoPass.TabIndex = 3;
            this.campoPass.Tag = "CONTRASEÑA";
            this.campoPass.UseSystemPasswordChar = true;
            this.campoPass.Enter += new System.EventHandler(this.campoPass_Enter);
            this.campoPass.Leave += new System.EventHandler(this.campoPass_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 391);
            this.Controls.Add(this.groupLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 430);
            this.MinimumSize = new System.Drawing.Size(880, 430);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox picturePass;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.TextBox campoUser;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnayaRRHH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pictureUser.Visible = false;
            picturePass.Visible = false;
            this.ActiveControl = btnEntrar;
        }

        private void campoUser_Enter(object sender, EventArgs e)
        {
            pictureUser.Visible = true;
        }

        private void campoPass_Enter(object sender, EventArgs e)
        {
            picturePass.Visible = true;
        }

        private void campoPass_Leave(object sender, EventArgs e)
        {
            picturePass.Visible = false;
        }

        private void campoUser_Leave(object sender, EventArgs e)
        {
            pictureUser.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }
    }
}

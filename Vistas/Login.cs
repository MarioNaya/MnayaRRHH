using MnayaRRHH.bbdd;
using MnayaRRHH.Utilidades;
using MnayaRRHH.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
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
            campoPass.Text = "admin";
            campoUser.Text = "admin";
        }

        private void campoUser_Enter(object sender, EventArgs e)
        {
            pictureUser.Visible = true;
            campoUser.BackColor = Color.White;
        }

        private void campoPass_Enter(object sender, EventArgs e)
        {
            picturePass.Visible = true;
            campoPass.BackColor = Color.White;
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
            Entrar();
        }

        private void campoUser_TextChanged(object sender, EventArgs e)
        {

        }

        public static string nombre, apellidos, ip;

        public void Entrar()
        {
            if (Validaciones.GroupCampoVacio(groupLogin))
            {
                if (Consultas.Acceder(campoUser.Text, campoPass.Text))
                {
                    nombre = Consultas.RescataDatosUserLogado(campoUser.Text).Nombre;
                    apellidos = Consultas.RescataDatosUserLogado(campoUser.Text).Apellidos;
                    ip = DatosConexion.RescatarIpLocal();
                    Principal p = new Principal();
                    p.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error de identificación. Inténtelo de nuevo.","LOGIN",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    GestionFormularios.ReseteaFormulario(groupLogin);
                }
            }
        }
    }
}

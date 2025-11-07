using MnayaRRHH.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnayaRRHH.Vistas
{
    public partial class DatosMensaje : Form
    {
        public DatosMensaje()
        {
            InitializeComponent();
            comboHora.SelectedIndex = 0;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (comboHora.SelectedIndex == 0)
            {
                labelAviso.Visible = true;
            }
            else
            {
                string correo = Email.CrearMensaje(fechaCita.Value.ToShortDateString(),comboHora.SelectedItem.ToString());
                if (Email.EnvioCorreo(BuscarCandidato.email, correo))
                {
                    MessageBox.Show("Correo enviado correctamente","Envío de correo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al enviar el correo. Inténtelo de nuevo", "Envío de correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelAviso.Visible = false;
        }
    }
}
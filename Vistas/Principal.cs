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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            label1.Text = $"Bienvenid@, {Login.nombre} {Login.apellidos}";
            label2.Text = $"Acceso: {DateTime.Now}";
            label3.Text = $"Ip de conexión: {Login.ip}";
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

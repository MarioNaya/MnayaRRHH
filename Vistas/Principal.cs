using MnayaRRHH.bbdd;
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
            labelNombre.Text = $"Bienvenid@, {Login.nombre} {Login.apellidos}";
            labelFecha.Text = $"Acceso: {DateTime.Now}";
            labelip.Text = $"Ip de conexión: {Login.ip}";
            string[] totalRegistros = Consultas.CuentaCandidatos();
            labelAdmin.Text = totalRegistros[0];
            labelAlmacen.Text = totalRegistros[1];
            tablaAdmin.DataSource = Consultas.VerUltimoscandidatosAdmin();
            tablaAlmacen.DataSource = Consultas.VerUltimoscandidatosAlmacen();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

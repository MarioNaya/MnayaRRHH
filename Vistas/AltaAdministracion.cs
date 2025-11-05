using MnayaRRHH.bbdd;
using MnayaRRHH.Model;
using MnayaRRHH.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnayaRRHH.Vistas
{
    public partial class AltaAdministracion : Form
    {
        public AltaAdministracion()
        {
            InitializeComponent();
            comboLocalidad.SelectedIndex = 0;
            comboEstudios.SelectedIndex = 0;
        }

        private void AltaAdministracion_Load(object sender, EventArgs e)
        {
            datePickerNacimiento.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarCandidato();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            selector.Filter = ("Archivos de imagen|*.jpg;*.jpeg;*.png");
            if (selector.ShowDialog() == DialogResult.OK)
            {
                campoFoto.Text = selector.FileName;
            }
            campoFoto.BackColor = Color.White;
        }

        /// <summary>
        /// Función que valida los campos del formulario y registra un nuevo candidato en la base de datos
        /// </summary>
        public void RegistrarCandidato()
        {
            if (!Validaciones.GroupCampoVacio(groupPersonales))
            {
                return;
            }

            if (!Validaciones.GroupCampoVacio(groupComplementarios))
            {
                return;
            }

            if (!Validaciones.ValidarRadioSeleccionado(groupTextos))
            {
                return;
            }

            if (!Validaciones.ValidarRadioSeleccionado(groupCalculo))
            {
                return;
            }

            if (!Validaciones.ValidarRadioSeleccionado(groupInternet))
            {
                return;
            }

            if (!Validaciones.DniValido(campoDni.Text))
            {
                return;
            }

            if (!Validaciones.ValidarRegex(Validaciones.regexCP, campoCp.Text, campoCp.Tag.ToString()))
            {
                return;
            }

            if (!Validaciones.ValidarRegex(Validaciones.regexMovil, campoTelefono.Text, campoTelefono.Tag.ToString()))
            {
                return;
            }

            if (!Validaciones.ValidarRegex(Validaciones.regexEmail, campoEmail.Text, campoEmail.Tag.ToString()))
            {
                return;
            }

            if (!Validaciones.ValidarRegex(Validaciones.regexFoto, campoFoto.Text, campoFoto.Tag.ToString()))
            {
                return;
            }

            if (!Validaciones.PesoFotoValido(campoFoto.Text))
            {
                return;
            }

            if (!Consultas.BuscarDniAdmin(campoDni.Text))
            {
                CandidatoAdministracion c = new CandidatoAdministracion(
                    campoNombre.Text,
                    campoApellidos.Text,
                    campoDni.Text,
                    campoDireccion.Text,
                    campoEmail.Text,
                    comboEstudios.SelectedItem.ToString(),
                    File.ReadAllBytes(campoFoto.Text),
                    comboLocalidad.SelectedItem.ToString(),
                    campoObservaciones.Text,
                    Login.nombre + " " + Login.apellidos,
                    int.Parse(campoCp.Text),
                    int.Parse(campoTelefono.Text),
                    DateTime.Now,
                    datePickerNacimiento.Value,
                    Validaciones.RecuperarValoresRadio(groupCalculo),
                    Validaciones.RecuperarValoresRadio(groupInternet),
                    Validaciones.RecuperarValoresRadio(groupTextos));



                if (Consultas.RegistrarCandidatoAdmin(c))
                {
                    MessageBox.Show("Candidato registrado con éxito.", "Registro candidato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Validaciones.ResetearFormulario(groupPersonales);
                    Validaciones.ResetearFormulario(groupComplementarios);
                    Validaciones.ResetearFormulario(groupTextos);
                    Validaciones.ResetearFormulario(groupCalculo);
                    Validaciones.ResetearFormulario(groupInternet);
                }
                else
                {
                    MessageBox.Show("Error al registrar el candidato.", "Registro candidato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El DNI ya está registrado en la base de datos.", "Registro candidato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void groupPersonales_Enter(object sender, EventArgs e)
        {
            Validaciones.Foco(groupPersonales);
            Validaciones.AsignarSoloNumeros(groupPersonales);
        }

        private void groupComplementarios_Enter(object sender, EventArgs e)
        {
            Validaciones.Foco(groupComplementarios);
        }
    }
}

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
    public partial class BuscarCandidato : Form
    {
        public BuscarCandidato()
        {
            InitializeComponent();
            comboTipo.SelectedIndex = 0;
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipo.SelectedIndex != 0)
            {
                campoDni.Enabled = true;
                btnBuscar.Enabled = true;
                Validaciones.ResetearFormulario(groupDatosPersonales);
                pictureFoto.Image = null;
                campoDni.Text = "";
            }
            else
            {
                campoDni.Enabled = false;
                btnBuscar.Enabled = false;
                Validaciones.ResetearFormulario(groupDatosPersonales);
                pictureFoto.Image = null;
                campoDni.Text = "";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarCandidato();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConfirmarEliminacionCandidato();
        }

        private void campoNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(campoNombre.Text))
            {
                btnEliminar.Enabled = true;
                btnEnviarEmail.Enabled = true;
                btnPdf.Enabled = true;

            }
            else
            {
                btnEliminar.Enabled = false;
                btnEnviarEmail.Enabled = false;
                btnPdf.Enabled = false;
            }
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            DatosMensaje dm = new DatosMensaje();
            dm.ShowDialog();
        }

        public static string email;
        string dniCandidato, tabla;

        public void MostrarCandidato()
        {
            Candidato c;

            if (string.IsNullOrEmpty(campoDni.Text))
            {
                MessageBox.Show($"Introduzca algún valor en el campo {campoDni.Tag}",
                                "Validación de campo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (comboTipo.SelectedIndex == 1)
            {
                if (Consultas.BuscarDniAdmin(campoDni.Text))
                {
                    dniCandidato = campoDni.Text;
                    tabla = "candidatoadministracion";
                    c = Consultas.RescatarDatosCandidato(dniCandidato, tabla);
                    RellenarFormulario(c);
                    email = campoEmail.Text;
                }
                else
                {
                    MessageBox.Show("El candidato no existe en Administración",
                                  "Búsqueda de candidato",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    campoDni.Text = string.Empty;
                }
            }
            else if (comboTipo.SelectedIndex == 2)
            {
                if (Consultas.BuscarDniAlmacen(campoDni.Text))
                {
                    dniCandidato = campoDni.Text;
                    tabla = "candidatoalmacen";
                    c = Consultas.RescatarDatosCandidato(dniCandidato, tabla);
                    RellenarFormulario(c);
                    email = campoEmail.Text;
                }
                else
                {
                    MessageBox.Show("El candidato no existe en Almacén",
                                  "Búsqueda de candidato",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    campoDni.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de candidato válido",
                               "Validación",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void RellenarFormulario(Candidato c)
        {
            campoNombre.Text = c.Nombre;
            campoApellidos.Text = c.Apellidos;
            campoFechaNacimiento.Text = c.FechaNaciemiento.ToShortDateString();
            campoDireccion.Text = c.Direccion;
            campoCp.Text = c.Cp.ToString();
            campoLocalidad.Text = c.Localidad;
            campoTelefono.Text = c.Tlfno.ToString();
            campoEmail.Text = c.Email;
            campoFechaAlta.Text = c.FechaAlta.ToShortDateString();

            if (c.Foto != null && c.Foto.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(c.Foto))
                {
                    pictureFoto.Image = System.Drawing.Image.FromStream(ms);
                }
            }
        }
        public void ConfirmarEliminacionCandidato()
        {

            DialogResult resultado = MessageBox.Show("¿Desea eliminar el candidato de la base de datos?", 
                "Eliminación de candidatos", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information);

            if (resultado == DialogResult.OK)
            {
                if (Consultas.EliminarCandidato(dniCandidato, tabla))
                {
                    MessageBox.Show("Candidato eliminado con éxito.", 
                        "Eliminación de candidatos", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    Validaciones.ResetearFormulario(groupDatosPersonales);
                    pictureFoto.Image = null;
                }
                else
                {
                    MessageBox.Show("Error en el proceso de eliminación. No se ha eliminado ningún candidato. Inténtelo de nuevo.", 
                        "Eliminación de candidatos", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.", 
                    "Eliminación de candidatos", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }


        }
    }
}

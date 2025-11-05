using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnayaRRHH.Utilidades
{
    internal class Validaciones
    {
        /// <summary>
        /// Recorre GroupBox en búsqueda de algún control que esté vació
        /// </summary>
        /// <param name="grp">name del GroupBox a recorrer</param>
        /// <returns>true si no hay campos vacíos, false si hay algún campo vacío</returns>
        public static bool GroupCampoVacio(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        MessageBox.Show($"El campo {c.Tag} es obligatorio.", "Validacion de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        c.BackColor = Color.Red;
                        return false;
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox cmb = (ComboBox) c;
                    if (cmb.SelectedIndex == 0)
                    {
                        MessageBox.Show($"El campo {c.Tag} es obligatorio.", "Validacion de campo", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Expresiones regulares para validaciones
        /// </summary>
        public static Regex regexEmail = new Regex(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$");
        public static Regex regexCP = new Regex(@"^(0[1-9]|[1-4]\d|5[0-2])\d{3}$");
        public static Regex regexMovil = new Regex(@"^[67]\d{8}$");
        public static Regex regexFoto = new Regex(@"\.(jpg|jpeg|png)$", RegexOptions.IgnoreCase);

        /// <summary>
        /// Valida un texto contra una expresión regular
        /// </summary>
        /// <param name="regex">Expresión regular</param>
        /// <param name="texto">String a comprobar</param>
        /// <param name="tag">Etiqueta de aviso para usuario</param>
        /// <returns></returns>
        public static bool ValidarRegex(Regex regex, string texto, string tag)
        {
            if (!regex.IsMatch(texto))
            {
                MessageBox.Show($"El campo {tag} no es válido.","Validacion de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool DniValido(string dni)
        {

            dni = dni.Trim().ToUpper();

            if (!System.Text.RegularExpressions.Regex.IsMatch(dni, @"^\d{8}[TRWAGMYFPDXBNJZSQVHLCKE]$"))
            {
                MessageBox.Show("El DNI introducido no es válido.", "Validacion de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                

            int numero = int.Parse(dni.Substring(0, 8));
            char letra = dni[8];

            const string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            char letraCorrecta = letras[numero % 23];

            if (letra == letraCorrecta)
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }

        public static bool PesoFotoValido(string ruta)
        {
            const int maxPesoBytes = 2 * 1024 * 1024; // 2 MB
            var fileInfo = new System.IO.FileInfo(ruta);
            if (fileInfo.Length > maxPesoBytes)
            {
                MessageBox.Show("El tamaño de la foto no debe superar los 2 MB.","Tamaño de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static string[] RecuperarValoresCheck(GroupBox grp)
        {
            string[] valores = new string[grp.Controls.Count];

            for (int i = 0; i < grp.Controls.Count; i++)
            {
                CheckBox chk = (CheckBox)grp.Controls[i];
                valores[i] = chk.Checked ? "SI" : "NO";
            }
            return valores;
        }

        public static string RecuperarValoresRadio(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                RadioButton rdo = (RadioButton)c;
                if (rdo.Checked)
                {
                    return rdo.Tag.ToString();
                }
            }
            return string.Empty;
        }

        public static void ResetearFormulario(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
                else if (c is ComboBox)
                {
                    ComboBox cmb = (ComboBox)c;
                    cmb.SelectedIndex = 0;
                }
                else if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    chk.Checked = false;
                }
                else if (c is RadioButton)
                {
                    RadioButton rdo = (RadioButton)c;
                    rdo.Checked = false;
                }
            }
        }

        public static bool ValidarRadioSeleccionado(GroupBox grp)
        {
            bool algunoSeleccionado = false;
            foreach (Control c in grp.Controls)
            {
                RadioButton rdo = (RadioButton)c;
                if (rdo.Checked)
                {
                    algunoSeleccionado = true;
                    return true;
                }
            }
            if (!algunoSeleccionado)
            {
                MessageBox.Show($"Debe seleccionar una opción para {grp.Tag}.", "Validacion de campo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}

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

        /// <summary>
        /// Valida formato de DNI con operación para comprobar que la letra es correcta respecto a la numeración
        /// </summary>
        /// <param name="dni">string del DNI</param>
        /// <returns>true si el formato es correcto y false si es incorrecto</returns>
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

        /// <summary>
        /// Comprobación de que la foto de perfil subida por el usuario no supere los 2mb
        /// </summary>
        /// <param name="ruta">path del archivo cargado</param>
        /// <returns>true si el peso es inferior a 2mb y false si es superior</returns>
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

        /// <summary>
        /// Asigna y recupera el valor de los checks dentro de un groupbox
        /// </summary>
        /// <param name="grp">groupbox contenedor de los checks</param>
        /// <returns>SI=> si el check está marcado // NO => si el check no está marcado</returns>
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

        /// <summary>
        /// Recupera valores de los radios dentro de un groupbox en función de la propieda .Tag asignada a cada radio
        /// </summary>
        /// <param name="grp">groupbox contenedor de los radios</param>
        /// <returns>string del tag del radio seleccionado</returns>
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

        /// <summary>
        /// Recupera el valor del item seleccionado de un combo y lo devuelve como string. Discrimina el índice 0 como item no válido.
        /// </summary>
        /// <param name="combo">Combo del que se va a rescatar el valor</param>
        /// <returns>string del valor del item seleccionado</returns>
        public static string RecuperarValorCombo(ComboBox combo)
        {
            if (combo.SelectedIndex != 0)
            {
                string resultado = combo.SelectedItem.ToString();
                return resultado;
            }
            return "";
        }

        /// <summary>
        /// Devuelve todos los controles dentro de un groupbox a su estado original. Contempla textbox, combobox, radios y checks.
        /// </summary>
        /// <param name="grp">groupbox contenedor de los controles que va a recorrer</param>
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

        /// <summary>
        /// comprueba que al menos un radio dentro de un groupbox ha sido seleccionado.
        /// </summary>
        /// <param name="grp">groupbox contenedor de los radios</param>
        /// <returns></returns>
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

        /// <summary>
        /// Asigna backcolor blanco a los textbox dentro de un groupbox cuando tienen el foco
        /// </summary>
        /// <param name="grp">groupbox contenedor</param>
        public static void Foco (GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    c.Enter += delegate (object sender, EventArgs e)
                    {
                        c.BackColor = Color.White;
                    };
                }
            }
        }

        /// <summary>
        /// Impide que en textbox para finalidad de contener int se pueda teclear nada que no sean números enteros.
        /// </summary>
        /// <param name="grp">groupbox contenedor</param>
        public static void AsignarSoloNumeros(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Tag.ToString()=="CÓDIGO POSTAL" || c.Tag.ToString() == "TELÉFONO")
                    {
                        c.KeyPress += delegate (object o, KeyPressEventArgs e)
                        {
                            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                            {
                                e.Handled = true;
                                MessageBox.Show($"El campo {c.Tag} solo acepta valores numéricos","Validación de campos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        };
                    }
                }
            }
        }
    }
}

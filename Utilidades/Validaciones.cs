using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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
                        MessageBox.Show($"El campo {c.Tag} es obligatorio.");
                        c.BackColor = Color.Red;
                        return false;
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox cmb = (ComboBox) c;
                    if (cmb.SelectedIndex == 0)
                    {
                        MessageBox.Show($"El campo {c.Tag} es obligatorio.") ;
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

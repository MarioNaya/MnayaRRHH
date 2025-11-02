using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnayaRRHH.Utilidades
{
    internal class GestionFormularios
    {
        /// <summary>
        /// Vaciado de formularios contenidos en un GroupBox
        /// </summary>
        /// <param name="grp">name del GroupBox a recorrer</param>
        public static void ReseteaFormulario(GroupBox grp)
        {
            foreach (Control control in grp.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }

                if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.SelectedIndex = 0;
                }
            }
        }
    }
}

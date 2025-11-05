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
    public partial class AltaAdministracion : Form
    {
        public AltaAdministracion()
        {
            InitializeComponent();
        }

        private void AltaAdministracion_Load(object sender, EventArgs e)
        {
            datePickerNacimiento.MaxDate = DateTime.Now.AddYears(-18);
        }
    }
}

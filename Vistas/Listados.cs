using MnayaRRHH.bbdd;
using MnayaRRHH.Utilidades;
using Spire.Xls;
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
    public partial class Listados : Form
    {
        public Listados()
        {
            InitializeComponent();

            comboAdminEstudios.SelectedIndex = 0;
            comboAlmacenEstudios.SelectedIndex = 0;
            comboTipo.SelectedIndex = 0;

            radioTextosTodos.Tag = "";
            radioTextosUsuario.Tag = " AND nivelInformaticaTexto = 'Usuario'";
            radioTextosMedio.Tag = " AND nivelInformaticaTexto = 'Medio' ";
            radioTextosAvanzado.Tag = " AND nivelInformaticaTexto = 'Avanzado'";

            radioCalculoTodos.Tag = "";
            radioCalculoUsuario.Tag = " AND nivelInformaticaHojaCalculo = 'Usuario'";
            radioCalculoMedio.Tag = " AND nivelInformaticaHojaCalculo = 'Medio'";
            radioCalculoAvanzado.Tag = " AND nivelInformaticaHojaCalculo = 'Avanzado'";

            radioInternetTodos.Tag = "";
            radioInternetUsuario.Tag = " AND nivelInformaticaInternet = 'Usuario'";
            radioInternetMedio.Tag = " AND nivelInformaticaInternet = 'Medio'";
            radioInternetAvanzado.Tag = " AND nivelInformaticaInternet = 'Avanzado'";
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            tablaCandidatos.DataSource = Consultas.VerCandidatosAdministracion(ConstruccionCondicionAdmin());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ExportarXls();
        }
        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            tablaCandidatos.DataSource = Consultas.VerCandidatosAlmacen(ConstruccionCondicionAlmacen());
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipo.SelectedIndex != 0)
            {
                string indice = comboTipo.SelectedItem.ToString();
                Validaciones.ResetearFormulario(groupAdmin);
                Validaciones.ResetearFormulario(groupAlmacen);
                Validaciones.ResetearFormulario(groupTextos);
                Validaciones.ResetearFormulario(groupCalculo);
                Validaciones.ResetearFormulario(groupInternet);
                Validaciones.ResetearFormulario(groupCarnets);
                switch (indice)
                {
                    case "Almacén":
                        groupAlmacen.Enabled = true;
                        groupAdmin.Enabled = false;
                        break;
                    case "Administración":
                        groupAdmin.Enabled=true;
                        groupAlmacen.Enabled = false;
                        break;
                    default:
                        groupAdmin.Enabled = false;
                        groupAlmacen.Enabled = false;
                        break;
                }
            }
            else
            {
                groupAdmin.Enabled = false;
                groupAlmacen.Enabled = false;
                Validaciones.ResetearFormulario(groupAdmin);
                Validaciones.ResetearFormulario(groupAlmacen);
                Validaciones.ResetearFormulario(groupTextos);
                Validaciones.ResetearFormulario(groupCalculo);
                Validaciones.ResetearFormulario(groupInternet);
                Validaciones.ResetearFormulario(groupCarnets);
            }
        }

        public string ConstruccionCondicionAdmin()
        {
            string condicion = "";

            if (comboAdminEstudios.SelectedIndex != 0)
            {
                condicion += $" AND nivelEstudios = '{Validaciones.RecuperarValorCombo(comboAdminEstudios)}'";
            }
            condicion += Validaciones.RecuperarValoresRadio(groupTextos);
            condicion += Validaciones.RecuperarValoresRadio(groupCalculo);
            condicion += Validaciones.RecuperarValoresRadio(groupInternet);

            return condicion;
        }

        public string ConstruccionCondicionAlmacen()
        {
            string condicion = "";
            if (comboAlmacenEstudios.SelectedIndex != 0)
            {
                condicion += $" AND nivelEstudios = '{Validaciones.RecuperarValorCombo(comboAlmacenEstudios)}'";
            }
            condicion += $" AND carnetConducir = '{Validaciones.RecuperarValoresCheck(groupCarnets)[0]}'";
            condicion += $" AND carnetCarretilla = '{Validaciones.RecuperarValoresCheck(groupCarnets)[1]}'";
            condicion += $" AND carnetCamion = '{Validaciones.RecuperarValoresCheck(groupCarnets)[2]}'";
            return condicion;
        }

        public void ExportarXls()
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xlsx)|*.xlsx";

            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Workbook workbook = new Workbook();
                Worksheet sheet = workbook.Worksheets[0];
                sheet.Range["A1"].Text = "Informe de candidatos";
                sheet.Range["A2"].Text = DateTime.Now.ToString();

                sheet.InsertDataTable((DataTable)this.tablaCandidatos.DataSource, true, 4, 1, -1, -1);

                sheet.AllocatedRange.AutoFitColumns();
                sheet.AllocatedRange.AutoFitRows();

                workbook.SaveToFile(fichero.FileName, ExcelVersion.Version2016);

                System.Diagnostics.Process.Start(fichero.FileName);
            }
        }

        private void radioAlmacenTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAlmacenTodos.Checked)
            {
                groupCarnets.Enabled = false;
                Validaciones.ResetearFormulario(groupCarnets);
            }
        }

        private void radioAlmacenFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAlmacenFiltrar.Checked)
            {
                groupCarnets.Enabled = true;
                Validaciones.ResetearFormulario(groupCarnets);
            }
        }
    }
}

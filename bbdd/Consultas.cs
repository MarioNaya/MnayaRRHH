using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MnayaRRHH.bbdd
{
    internal class Consultas
    {
        public static readonly string url = Conexion.GetConnectionString();

        public static bool Acceder(string user, string pass)
        {

            string consulta = "SELECT usuario, contrasenya FROM usuarios WHERE usuario=?user AND contrasenya=?pass";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?user", user);
                        cmd.Parameters.AddWithValue("?pass", pass);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

            return false;
        }
    }
}

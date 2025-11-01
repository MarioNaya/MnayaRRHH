using MnayaRRHH.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public static Usuario RescataDatosUserLogado(string user)
        {
            string consulta = "SELECT nombre, apellidos FROM usuarios WHERE usuario=?user";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?user", user);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Usuario u = new Usuario(
                                reader["nombre"].ToString(),
                                reader["apellidos"].ToString()
                                );

                                return u;
                            }
                            else
                            {
                                return null;
                            }

                        }
                    }
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}

using MnayaRRHH.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable VerUltimoscandidatosAdmin()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add("NOMBRE");
            dt.Columns.Add("APELLIDOS");
            dt.Columns.Add("DNI");
            dt.Columns.Add("TELEFONO");

            string consulta = "SELECT nombre, apellidos, dni, telefono FROM candidatoadministracion ORDER BY fechaAlta DESC LIMIT 3";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dr = dt.NewRow();
                                dr["NOMBRE"] = reader.GetString(0);
                                dr["APELLIDOS"] = reader.GetString(1);
                                dr["DNI"] = reader.GetString(2);
                                dr["TELEFONO"] = reader.GetInt32(3);

                                dt.Rows.Add(dr);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public static DataTable VerUltimoscandidatosAlmacen()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add("NOMBRE");
            dt.Columns.Add("APELLIDOS");
            dt.Columns.Add("DNI");
            dt.Columns.Add("TELEFONO");

            string consulta = "SELECT nombre, apellidos, dni, telefono FROM candidatoalmacen ORDER BY fechaAlta DESC LIMIT 3";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dr = dt.NewRow();
                                dr["NOMBRE"] = reader.GetString(0);
                                dr["APELLIDOS"] = reader.GetString(1);
                                dr["DNI"] = reader.GetString(2);
                                dr["TELEFONO"] = reader.GetInt32(3);

                                dt.Rows.Add(dr);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public static string CuentaCandidatos(string tabla)
        {
            string consulta = $"SELECT COUNT(*) FROM {tabla}";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        if (cmd.ExecuteScalar() != null)
                        {
                            string numero = Convert.ToString(cmd.ExecuteScalar());
                            return numero;
                        }
                        else
                        {
                            return "0";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
    }
}

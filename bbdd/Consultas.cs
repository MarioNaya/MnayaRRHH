using MnayaRRHH.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MnayaRRHH.bbdd
{
    internal class Consultas
    {
        public static readonly string url = Conexion.GetConnectionString();

        /// <summary>
        /// Función de consulta a bbdd para comprobar coincidencia de usuario y contraseña
        /// en el login
        /// </summary>
        /// <param name="user">string</param>
        /// <param name="pass">string</param>
        /// <returns>true si existe</returns>
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

        /// <summary>
        /// Recuperamos en consulta a bbdd, el nombre y apellidos del usuario logado
        /// a través de objeto.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Objeto Usuario con nombre y apellidos</returns>
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
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// Recuperamos los 3 últimos registros por fecha de alta en la tabla de
        /// candidatosadministracion
        /// </summary>
        /// <returns>Tabla con 3 registros</returns>
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

        /// <summary>
        /// Recuperamos los 3 últimos registros por fecha de alta en la tabla de
        /// candidatosalmacen
        /// </summary>
        /// <returns>Tabla con 3 registros</returns>
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

        /// <summary>
        /// Recuperamos en una única consulta el número de registros en las tablas de administración
        /// y alamacén
        /// </summary>
        /// <returns>Array, posición 0: administración, posición 1: almacén</returns>
        public static string[] CuentaCandidatos()
        {
            string consulta = @"SELECT 
                        (SELECT COUNT(*) FROM candidatoadministracion) as administracion,
                        (SELECT COUNT(*) FROM candidatoalmacen) as almacen";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string[] resultado = new string[2];
                                resultado[0] = reader.GetInt32("administracion").ToString();
                                resultado[1] = reader.GetInt32("almacen").ToString();
                                return resultado;
                            }
                            else
                            {
                                return new string[] { "0", "0" };
                            }
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

        public static bool BuscarDniAlmacen(string dni)
        {
            string consulta = "SELECT dni FROM candidatoalmacen WHERE dni=?dni";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?dni", dni);
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
                return false;
            }
        }

        public static bool BuscarDniAdmin(string dni)
        {
            string consulta = "SELECT dni FROM candidatoadministracion WHERE dni=?dni";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?dni", dni);
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
                return false;
            }
        }

        public static bool RegistrarCandidatoAdmin(CandidatoAdministracion candidato)
        {
            string consulta = "INSERT INTO candidatoadministracion " +
                            "(nombre, apellidos, dni, fechaNacimiento, direccion, cp, localidad, telefono, email, " +
                            "foto, nivelEstudios, nivelInformaticaTexto, nivelInformaticaHojaCalculo, nivelInformaticaInternet, " +
                            "observaciones, fechaAlta, registrador) " +
                            "VALUES " +
                            "(?nombre, ?apellidos, ?dni, ?fechaNacimiento, ?direccion, ?cp, ?localidad, ?telefono, ?email, ?foto, " +
                            "?nivelEstudios, ?nivelInformaticaTexto, ?nivelInformaticaHojaCalculo, ?nivelInformaticaInternet, " +
                            "?observaciones, ?fechaAlta, ?registrador)";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?nombre", candidato.Nombre);
                        cmd.Parameters.AddWithValue("?apellidos", candidato.Apellidos);
                        cmd.Parameters.AddWithValue("?dni", candidato.Dni);
                        cmd.Parameters.AddWithValue("?fechaNacimiento", candidato.FechaNaciemiento);
                        cmd.Parameters.AddWithValue("?direccion", candidato.Direccion);
                        cmd.Parameters.AddWithValue("?cp", candidato.Cp);
                        cmd.Parameters.AddWithValue("?localidad", candidato.Localidad);
                        cmd.Parameters.AddWithValue("?telefono", candidato.Tlfno);
                        cmd.Parameters.AddWithValue("?email", candidato.Email);
                        cmd.Parameters.AddWithValue("?foto", candidato.Foto);
                        cmd.Parameters.AddWithValue("?nivelEstudios", candidato.EstudiosFinalizados);
                        cmd.Parameters.AddWithValue("?nivelInformaticaTexto", candidato.NivelInformaticaTexto);
                        cmd.Parameters.AddWithValue("?nivelInformaticaHojaCalculo", candidato.NivelInformaticaCalculo);
                        cmd.Parameters.AddWithValue("?nivelInformaticaInternet", candidato.NivelInformaticaInternet);
                        cmd.Parameters.AddWithValue("?observaciones", candidato.Observaciones);
                        cmd.Parameters.AddWithValue("?fechaAlta", candidato.FechaAlta);
                        cmd.Parameters.AddWithValue("?registrador", candidato.UsuariosRegistrador);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool RegistrarCandidatoAlmacen(CandidatoAlmacen candidato)
        {
            string consulta = "INSERT INTO candidatoalmacen " +
                            "(nombre, apellidos, dni, fechaNacimiento, direccion, cp, localidad, telefono, email, " +
                            "foto, nivelEstudios, carnetConducir, carnetCarretilla, carnetCamion, " +
                            "observaciones, fechaAlta, registrador) " +
                            "VALUES " +
                            "(?nombre, ?apellidos, ?dni, ?fechaNacimiento, ?direccion, ?cp, ?localidad, ?telefono, ?email, ?foto, " +
                            "?nivelEstudios, ?carnetConducir, ?carnetCarretilla, ?carnetCamion, " +
                            "?observaciones, ?fechaAlta, ?registrador)";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(url))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("?nombre", candidato.Nombre);
                        cmd.Parameters.AddWithValue("?apellidos", candidato.Apellidos);
                        cmd.Parameters.AddWithValue("?dni", candidato.Dni);
                        cmd.Parameters.AddWithValue("?fechaNacimiento", candidato.FechaNaciemiento);
                        cmd.Parameters.AddWithValue("?direccion", candidato.Direccion);
                        cmd.Parameters.AddWithValue("?cp", candidato.Cp);
                        cmd.Parameters.AddWithValue("?localidad", candidato.Localidad);
                        cmd.Parameters.AddWithValue("?telefono", candidato.Tlfno);
                        cmd.Parameters.AddWithValue("?email", candidato.Email);
                        cmd.Parameters.AddWithValue("?foto", candidato.Foto);
                        cmd.Parameters.AddWithValue("?nivelEstudios", candidato.EstudiosFinalizados);
                        cmd.Parameters.AddWithValue("?carnetConducir", candidato.CarnetConducir);
                        cmd.Parameters.AddWithValue("?carnetCarretilla", candidato.CarnetCarretilla);
                        cmd.Parameters.AddWithValue("?carnetCamion", candidato.CarnetCamion);
                        cmd.Parameters.AddWithValue("?observaciones", candidato.Observaciones);
                        cmd.Parameters.AddWithValue("?fechaAlta", candidato.FechaAlta);
                        cmd.Parameters.AddWithValue("?registrador", candidato.UsuariosRegistrador);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static DataTable VerCandidatosAdministracion(string condicion)
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add("NOMBRE");
            dt.Columns.Add("APELLIDOS");
            dt.Columns.Add("DNI");
            dt.Columns.Add("TELEFONO");
            dt.Columns.Add("EMAIL");
            dt.Columns.Add("ESTUDIOS");
            dt.Columns.Add("TRAT. TEXTO");
            dt.Columns.Add("HOJA CALCULO");
            dt.Columns.Add("INTERNET");

            string consulta = $"SELECT nombre, apellidos, dni, telefono, email, nivelEstudios, nivelInformaticaTexto, " +
                $"nivelInformaticaHojaCalculo, nivelInformaticaInternet  FROM candidatoadministracion WHERE 1{condicion}";

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
                            dr["EMAIL"] = reader.GetString(4);
                            dr["ESTUDIOS"] = reader.GetString(5);
                            dr["TRAT. TEXTO"] = reader.GetString(6);
                            dr["HOJA CALCULO"] = reader.GetString(7);
                            dr["INTERNET"] = reader.GetString(8);

                            dt.Rows.Add(dr);
                        }
                    }
                }
            }

            return dt;
        }

        public static DataTable VerCandidatosAlmacen(string condicion)
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add("NOMBRE");
            dt.Columns.Add("APELLIDOS");
            dt.Columns.Add("DNI");
            dt.Columns.Add("TELEFONO");
            dt.Columns.Add("EMAIL");
            dt.Columns.Add("ESTUDIOS");
            dt.Columns.Add("CARNET CONDUCIR");
            dt.Columns.Add("CARNET CARRETILLA");
            dt.Columns.Add("CARNET CAMION");

            string consulta = $"SELECT nombre, apellidos, dni, telefono, email, nivelEstudios, carnetConducir, " +
                $"carnetCarretilla, carnetCamion  FROM candidatoalmacen WHERE 1{condicion}";

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
                            dr["EMAIL"] = reader.GetString(4);
                            dr["ESTUDIOS"] = reader.GetString(5);
                            dr["CARNET CONDUCIR"] = reader.GetString(6);
                            dr["CARNET CARRETILLA"] = reader.GetString(7);
                            dr["CARNET CAMION"] = reader.GetString(8);

                            dt.Rows.Add(dr);
                        }
                    }
                }
            }

            return dt;
        }

        public static Candidato RescatarDatosCandidato(string dni, string tabla)
        {
            string consulta = "SELECT nombre, apellidos, fechaNacimiento, direccion, cp, localidad, telefono, email, foto, fechaAlta " +
                $"FROM {tabla} WHERE dni = ?dni";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("?tabla", tabla);
                    cmd.Parameters.AddWithValue("?dni", dni);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            Candidato c = new Candidato(
                                dr["nombre"].ToString(),
                                dr["apellidos"].ToString(),
                                dr["direccion"].ToString(),
                                dr["email"].ToString(),
                                (byte[])dr["foto"],
                                dr["localidad"].ToString(),
                                Convert.ToInt32(dr["cp"]),
                                Convert.ToInt32(dr["telefono"]),
                                Convert.ToDateTime(dr["fechaAlta"]),
                                Convert.ToDateTime(dr["fechaNacimiento"])
                                );
                            return c;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public static bool EliminarCandidato(string dni, string tabla)
        {

            string consulta = $"DELETE FROM {tabla} WHERE dni = ?dni";


            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("?dni", dni);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
            }
        }
    }
}

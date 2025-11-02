using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnayaRRHH.bbdd
{
    internal class Conexion
    {
        private static IConfigurationRoot config;

        /// <summary>
        /// Accede al .json de configuración de conexión a base de datos para extraer
        /// los parámetros de conexión y mapearlos. Así podemos mantener ocultos los parámetros
        /// en repositorios públicos.
        /// </summary>
        static Conexion()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("bbddsettings.json");

            config = builder.Build();
        }

        /// <summary>
        /// Accede al string con parámetros de conexión a bbdd que hemos mapeado en
        /// el constructor Conexion()
        /// </summary>
        /// <returns>String con parámetros de conexión a la base de datos</returns>
        public static string GetConnectionString()
        {
            return config.GetConnectionString("DefaultConnection");
        }
    }
}

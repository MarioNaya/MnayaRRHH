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

        static Conexion()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("bbddsettings.json");

            config = builder.Build();
        }

        public static string GetConnectionString()
        {
            return config.GetConnectionString("DefaultConnection");
        }
    }
}

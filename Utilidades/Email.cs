using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MnayaRRHH.Utilidades
{
    internal class Email
    {
        public static bool EnvioCorreo(string destino, string mensaje)
        {
            
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.hostinger.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("rrhh@reynaldomd.com", "2024-Rrhh");
            smtp.EnableSsl = true;

            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("rrhh@reynaldomd.com");
            correo.To.Add(destino);
            correo.Subject = "Convocatoria para entrevista de trabajo";
            correo.Body = mensaje;
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;

            smtp.Send(correo);

            correo.Dispose();

            return true;

        }

        public static string CrearMensaje(string fecha, string hora)
        {
            string mensaje = $"<!DOCTYPE html>\r\n" +
                $"<html lang=\"es\">\r\n" +
                $"<head>\r\n    " +
                $"<meta charset=\"UTF-8\">\r\n    " +
                $"<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    " +
                $"<title>Convocatoria para Entrevista de Trabajo</title>\r\n    " +
                $"<style>\r\n        " +
                $"body {{\r\n            " +
                $"font-family: Arial, sans-serif;\r\n            " +
                $"max-width: 800px;\r\n            " +
                $"margin: 40px auto;\r\n            " +
                $"padding: 20px;\r\n            " +
                $"background-color: #f5f5f5;\r\n            " +
                $"line-height: 1.6;\r\n        }}\r\n        " +
                $".container {{\r\n            " +
                $"background-color: white;\r\n            " +
                $"padding: 40px;\r\n            " +
                $"border-radius: 8px;\r\n            " +
                $"box-shadow: 0 2px 10px rgba(0,0,0,0.1);\r\n        }}\r\n        " +
                $"h1 {{\r\n            " +
                $"color: #2c3e50;\r\n            " +
                $"font-size: 24px;\r\n            " +
                $"margin-bottom: 30px;\r\n            " +
                $"text-align: center;\r\n            " +
                $"text-transform: uppercase;\r\n        }}\r\n        " +
                $"p {{\r\n            " +
                $"color: #333;\r\n            " +
                $"margin-bottom: 15px;\r\n            " +
                $"text-align: justify;\r\n        }}\r\n        " +
                $".highlight {{\r\n            " +
                $"font-weight: bold;\r\n            " +
                $"color: #000000;\r\n        }}\r\n        " +
                $".email {{\r\n            " +
                $"color: #3498db;\r\n            " +
                $"text-decoration: none;\r\n        }}\r\n        " +
                $".email:hover {{\r\n            " +
                $"text-decoration: underline;\r\n        }}\r\n        " +
                $".firma {{\r\n            " +
                $"margin-top: 40px;\r\n            " +
                $"padding-top: 20px;\r\n            " +
                $"border-top: 2px solid #ecf0f1;\r\n        }}\r\n        " +
                $".firma p {{\r\n            " +
                $"margin: 5px 0;\r\n            " +
                $"font-weight: 500;\r\n        }}\r\n    " +
                $"</style>\r\n</head>\r\n<body>\r\n    " +
                $"<div class=\"container\">\r\n        " +
                $"<h1>Convocatoria para Entrevista de Trabajo</h1>\r\n        \r\n        " +
                $"<p>\r\n            " +
                $"Revisado su CV y considerando que podría ser interesante para el puesto de trabajo que ofertamos\r\n            " +
                $"le convocamos para una entrevista personal el día <span class=\"highlight\">{fecha}</span> a las \r\n            " +
                $"<span class=\"highlight\">{hora} horas</span>.\r\n        " +
                $"</p>\r\n        \r\n        " +
                $"<p>\r\n            " +
                $"Para confirmar la recepción de este correo o cualquier duda que le surja contáctenos a través de la \r\n            " +
                $"siguiente dirección de correo electrónico: \r\n            " +
                $"<a href=\"mailto:rrhh@reynaldomd.com\" class=\"email\">rrhh@reynaldomd.com</a>\r\n        " +
                $"</p>\r\n        \r\n        " +
                $"<div class=\"firma\">\r\n            " +
                $"<p>Atentamente:</p>\r\n            " +
                $"<p><strong>Departamento de Recursos Humanos de RMD</strong></p>\r\n            " +
                $"<p>TalentosBro y Asociados S.U</p>\r\n        " +
                $"<img src=\"http://www.reynaldomd.com/firmacorreo/firmarrhh.png\" alt=\"Firma RRHH\" class=\"firma-img\">\r\n" +
                $"</div>\r\n    " +
                $"</div>\r\n</body>\r\n</html>";

            return mensaje;
        }
    }
}

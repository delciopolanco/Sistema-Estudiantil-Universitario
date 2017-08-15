using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static Sistema_Estudiantil_Universitario.Enums.Estatus;

namespace Sistema_Estudiantil_Universitario.Helpers
{

    static class Correo
    {
        public static MailAddress direccionRemitente;
        public static MailAddress direccionDestinatario;
        public static string usuario = ConfigurationManager.AppSettings["usuarioCorreo"];
        public static string clave = ConfigurationManager.AppSettings["claveCorreo"];
        public static string anfitrion = ConfigurationManager.AppSettings["anfitrionCorreo"];
        public static int puerto = int.Parse(ConfigurationManager.AppSettings["puertoCorreo"]);

        public static string EnviarCorreo(string desde, string hacia, string asunto, string cuerpo, out Resultado resultado, string msg = "Correo enviado correctamente.")
        {
           var  msgEnvio = msg;
            try
            {
                direccionRemitente = new MailAddress(desde, "Sistema Estudiantil Universitario");
                direccionDestinatario = new MailAddress(hacia);
                var smtp = new SmtpClient
                {
                    Host = anfitrion,
                    Port = puerto,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(usuario, clave)
                };
                using (var message = new MailMessage(direccionRemitente, direccionDestinatario)
                {
                    Subject = asunto,
                    Body = cuerpo,
                    IsBodyHtml = true
                })
                {
                    smtp.Send(message);
                }
                resultado = Resultado.OK;
            }
            catch (Exception ex)
            {
                msgEnvio = ex.Message;
                resultado = Resultado.Error;
            }

            return msgEnvio;
        }

        public static bool IsValid(string emailaddress)
        {
            if (string.IsNullOrEmpty(emailaddress))
            {
                return false;
            }
            else
            {
                try
                {
                    MailAddress m = new MailAddress(emailaddress);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
        }
    }
}

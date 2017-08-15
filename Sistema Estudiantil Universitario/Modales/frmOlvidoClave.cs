using Sistema_Estudiantil_Universitario.Datos;
using Sistema_Estudiantil_Universitario.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sistema_Estudiantil_Universitario.Enums.Estatus;

namespace Sistema_Estudiantil_Universitario.Modales
{
    public partial class frmOlvidoClave : Form
    {
        #region "Mensaje"
        private string html = "<!DOCTYPE html> " +
                    "<html lang = 'en' >" +
                    "<head>" +
                    "<meta charset = 'UTF-8'>" +
                    "<meta name = 'viewport' content = 'width=device-width, initial-scale=1'>" +
                    "</head>" +
                    "<style>" +
                    "body {" +
                    "font - family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', Verdana, sans - serif;" +
                    "color: dodgerblue;" +
                    "}" +
                    "div: first - child {" +
                    "padding: 20px;" +
                    "margin: 0px;" +
                    "}" +
                    "table {" +
                    "border: 1px #ccc solid;" +
                    "table td {" +
                    "color: darkgrey;}" +
                    ".data{" +
                    "color: black;}" +
                    ".nodeseado {" +
                    "margin - top: 20px;" +
                    "border: 2px #ccc dashed;" +
                    "width: 30 %;}" +
                    ".nodeseado p {" +
                    "color: cornflowerblue;" +
                    "font - size: 10px;}" +
                    "</style>" +
                    "<body>" +
                    "<div class='main'>" +
                        "<h3>Sistema Universitario Estudiantil</h3>" +
                        "<table class='table'>" +
                            "<tr>" +
                                "<td>Clave temporal:</td>" +
                                "<td class='data'>{{id}}</td>" +
                            "</tr>" +
                        "</table>" +
                        "<div class='nodeseado'>" +
                            "<p>" +
                                "En caso de no identificar este correo, comuniquelo al administrador del sistema." +
                            "</p>" +
                        "</div>" +
                    "</div>" +
                "</body>" +
                "</html>";
        #endregion

        private UsuariosModel Usuarios;

        public frmOlvidoClave()
        {
            Usuarios = new UsuariosModel(new UniDBEntity());
            InitializeComponent();
        }

        private void btnValidarCorreo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCorreo.Text))
            {
                string claveTemporal = Utilitario.ObtenerGuid();
                string correo = txtCorreo.Text.Trim();
                string resultadoCorreo = string.Empty;
                string mensajeUsuarioOK = "Hemos enviado un correo a la dirección ingresada con su contraseña, verifique su buzón de entrada o  la carpeta de spam.";
                Resultado envio = Resultado.Error;

                Cursor = Cursors.WaitCursor;
                if (Usuarios.ExisteCorreo(correo))
                {
                    html = html.Replace("{{id}}", claveTemporal);

                    resultadoCorreo  = Correo.EnviarCorreo(
                        "sistemauniversitario@edu.com",
                        txtCorreo.Text.Trim(),
                        "Olvido su contraseña",
                        html,
                        out envio,
                        mensajeUsuarioOK);

                    if (envio == Resultado.Error)
                    {
                        resultadoCorreo = string.Format("No fue posible enviar el correo electrónico. " +
                                            "La razón se debe alguna de estas causas: \r\n\n  " +
                                            "- {0} \r\n  " +
                                            "- {1}",
                                            resultadoCorreo, "Verifique su conexión a internet");
                    }
                }
                else
                {
                    resultadoCorreo = "No podemos encontrar ese correo electrónico en nuestro sistema.";
                }

                Utilitario.Mensaje(resultadoCorreo);
                Cursor = Cursors.Arrow;

                if (envio == Resultado.OK)
                {
                    Usuarios.SetearClaveTemporal(correo, claveTemporal);
                    this.Close();
                }
            }
        }
    }
}

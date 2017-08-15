using Sistema_Estudiantil_Universitario.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estudiantil_Universitario.Helpers
{
    public static class Utilitario
    {

        public static void ManejarErrores(Control campo, ErrorProvider errorProvider)
        {
            if (EsTXT(campo) && string.IsNullOrEmpty(campo.Text))
            {
                errorProvider.Icon = Properties.Resources.error;
                errorProvider.SetError(campo, Errores.TipoErroresTxt.Requerido.ToName());
            }
            else
            {
                limpiarError(campo, errorProvider);
            }
        }

        public static List<string> EsValidoFormulario(Control formulario)
        {
            List<string> invalidos = new List<string>();

            foreach (Control campo in formulario.Controls)
            {
                if (EsTXT(campo) && string.IsNullOrEmpty(campo.Text))
                {
                    invalidos.Add(campo.Name);
                }

                if (campo is NumericUpDown && (string.IsNullOrEmpty(campo.Text) || campo.Text == "0"))
                {
                    invalidos.Add(campo.Name);
                }
            }
            return invalidos;
        }

        public static bool EsValido(Control formulario, Object entidad, string propiedad = "")
        {
            bool esValido = true;
            var errores = Validar(entidad);

            foreach (ValidationResult campo in errores)
            {
                if (!string.IsNullOrEmpty(propiedad))
                {
                    if (propiedad == campo.MemberNames.FirstOrDefault())
                    {
                        SetearLabelError(formulario, campo);
                        return false;
                    }
                }
                else
                {
                    SetearLabelError(formulario, campo);
                    esValido = false;
                }
            }

            return esValido;
        }

       
        public static bool EsValido(Control formulario, string nombreCampo = "")
        {
            bool esValido = true;
            var errores = EsValidoFormulario(formulario);

            foreach (string campo in errores)
            {
                if (!string.IsNullOrEmpty(nombreCampo))
                {
                    if (nombreCampo == campo)
                    {   
                        SetearLabelError(formulario,campo);
                        esValido = false;
                        return false;
                    }
                }
                else
                {
                    SetearLabelError(formulario, campo);
                    esValido = false;
                }
            }

            return esValido;
        }

        private static void SetearLabelError(Control formulario, ValidationResult campo)
        {
            Control label = formulario.Controls["lblErrortxt" + campo.MemberNames.FirstOrDefault()];
            label.Text = campo.ErrorMessage;
        }

        private static void SetearLabelError(Control formulario, string campo)
        {
            Control label = formulario.Controls["lblError" + campo];
            label.Text = "* Requerido";
        }


        internal static DialogResult Pregunta(string mensaje, MessageBoxButtons boton, MessageBoxIcon icon)
        {
            DialogResult respuesta = MessageBox.Show(mensaje, "Sistema de Estudiantil Universitario", boton, icon);
            return respuesta;
        }

        private static void limpiarError(Control texto, ErrorProvider errorProvider)
        {
            errorProvider.Icon.Dispose();
            errorProvider.SetError(texto, string.Empty);
        }

        internal static void esconderCabezerasTabs(TabControl tab)
        {
            tab.Appearance = TabAppearance.FlatButtons;
            tab.ItemSize = new Size(0, 1);
            tab.SizeMode = TabSizeMode.Fixed;
        }

        public static bool EsTXT(Control campo)
        {
            return campo is TextBox || campo is MaskedTextBox || campo is RichTextBox;
        }

        public static async void EjecutarLuegoDe(this Action accion, int tiempo)
        {
            await Task.Delay(TimeSpan.FromSeconds(tiempo));
            accion();
        }

        public static void Mensaje(string mensaje, MessageBoxButtons boton = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            MessageBox.Show(mensaje, "Sistema de Estudiantil Universitario", boton, icon);
        }

        public static void LimpiarCampos(Control formulario)
        {
            foreach (Control campo in formulario.Controls)
            {
                if (EsTXT(campo) || (campo is Label) && campo.ForeColor == Color.Red)
                {
                    campo.Text = string.Empty;
                }

                if (campo is NumericUpDown)
                {
                    ((NumericUpDown)campo).Value = ((NumericUpDown)campo).Minimum;
                }
            }
        }

        public static void LimpiarErrores(Control formulario)
        {
            foreach (Control campo in formulario.Controls)
            {
                if (campo is Label && campo.ForeColor == Color.Red)
                {
                    campo.Text = string.Empty;
                }
            }
        }

        public static string ObtenerContenidoArchivo(string nombreArchivo)
        {
            if (string.IsNullOrEmpty(nombreArchivo))
            {
                throw new Exception("Debe especificar el nombre del archivo a leer.");
            }

            string ruta = string.Format("{0}\\Datos\\PlantillasHTML\\{1}", Application.StartupPath, nombreArchivo);
            return File.ReadAllText(ruta);
        }

        public static string ObtenerGuid()
        {
            string guid = Guid.NewGuid().ToString();
            return guid.Substring(0, 8);
        }

        public static IList<ValidationResult> Validar(Object instancia)
        {
            ValidationContext context = new ValidationContext(instancia, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            Validator.TryValidateObject(instancia, context, errors, true);
            return errors;
        }
    }
}

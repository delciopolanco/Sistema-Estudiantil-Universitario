using Sistema_Estudiantil_Universitario.Datos;
using Sistema_Estudiantil_Universitario.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistema_Estudiantil_Universitario.Modales
{
    public partial class frmCambioClave : Form
    {
        private UsuariosModel UsuariosBD;
        private Usuarios NuevoUsuario;

        public frmCambioClave()
        {
            InitializeComponent();
            UsuariosBD = new UsuariosModel(new UniBDEntities());
            NuevoUsuario = new Usuarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCambioClave_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.cambiarClave = null;
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this, NuevoUsuario, nameof(NuevoUsuario.Contraseña)))
            {
                return;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (EsValido())
            {
                Cursor = Cursors.WaitCursor;
                UsuariosBD.CambiarContraseña(frmPrincipal.usuarioLogueado, txtContraseña.Text.Trim());
                NuevoUsuario = new Usuarios();
                Cursor = Cursors.Arrow;

                Utilitario.Mensaje("Se ha modificado correctamente la contraseña");
                Utilitario.LimpiarCampos(this);
            }
        }

        private void txtConfirmarContraseña_Validating(object sender, CancelEventArgs e)
        {
            validarConfirmarContraseña();
        }

        private void validarConfirmarContraseña()
        {
            if (!Utilitario.EsValido(this, NuevoUsuario, nameof(NuevoUsuario.ConfirmarContraseña)))
            {
                return;
            }
        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtConfirmarContraseña.Text = string.Empty;
            NuevoUsuario.ConfirmarContraseña = txtConfirmarContraseña.Text.Trim();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtContraseña.Text = string.Empty;
            NuevoUsuario.Contraseña = txtContraseña.Text.Trim();
        }

        private bool EsValido()
        {
            bool contraseña = Utilitario.EsValido(this, NuevoUsuario, nameof(NuevoUsuario.Contraseña));
            bool confirmarContraseña = Utilitario.EsValido(this, NuevoUsuario, nameof(NuevoUsuario.ConfirmarContraseña));
            return contraseña && confirmarContraseña;
        }
    }
}

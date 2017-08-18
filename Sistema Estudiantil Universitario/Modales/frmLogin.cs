using Sistema_Estudiantil_Universitario.Datos;
using Sistema_Estudiantil_Universitario.Enums;
using Sistema_Estudiantil_Universitario.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistema_Estudiantil_Universitario.Modales
{
    public partial class frmLogin : Form
    {
        private UsuariosModel UsuariosBD;
        private bool validacionesExitosas = true;

        public frmLogin()
        {
            InitializeComponent();
            UsuariosBD = new UsuariosModel();
        }

        private void lnkOlvidoClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOlvidoClave olvidoClave = new frmOlvidoClave();
            olvidoClave.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (!Utilitario.EsValido(this) || !validacionesExitosas)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;

            if (UsuariosBD.Login(txtUsuario.Text.Trim(), txtContraseña.Text.Trim()) == false)
            {
                lblError.Text = Errores.TipoErroresTxt.Incorrectos.ToName("Usuario y/o contraseña");
                Cursor = Cursors.Arrow;
                return;
            }

            Cursor = Cursors.Arrow;
            frmPrincipal.ActualizarStatusBar(txtUsuario.Text);
            this.Close();
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContraseña.Text))
            {
                lblErrortxtContraseña.Text = string.Empty;
                lblError.Text = string.Empty;
                validacionesExitosas = true;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtContraseña.Text = string.Empty;
            lblError.Text = string.Empty;
            validacionesExitosas = true;
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {
                lblErrortxtUsuario.Text = string.Empty;
                lblError.Text = string.Empty;
                validacionesExitosas = true;
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtUsuario.Text = string.Empty;
            lblError.Text = string.Empty;
            validacionesExitosas = true;
        }
    }
}

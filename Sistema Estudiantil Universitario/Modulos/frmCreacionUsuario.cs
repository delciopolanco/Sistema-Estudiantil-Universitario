using Sistema_Estudiantil_Universitario.Datos;
using Sistema_Estudiantil_Universitario.Enums;
using Sistema_Estudiantil_Universitario.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistema_Estudiantil_Universitario.Modulos
{
    public partial class frmCreacionUsuario : Form
    {

        private UsuariosModel UsuariosBD;
        private Usuarios NuevoUsuario;

        private bool usuarioValidacion = true;
        private bool correoValidacion = true;

        public frmCreacionUsuario()
        {
            InitializeComponent();
            UsuariosBD = new UsuariosModel();
            NuevoUsuario = new Usuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NuevoUsuario = new Usuarios()
            {
                Usuario = txtUsuario.Text.Trim(),
                Contraseña = txtContraseña.Text.Trim(),
                ConfirmarContraseña = txtConfirmarContraseña.Text.Trim(),
                CorreoElectronico = txtCorreoElectronico.Text.Trim()
            };

            if (!Utilitario.EsValido(this.grpBox, NuevoUsuario) || !esValido())
            {
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                UsuariosBD.Agregar(NuevoUsuario);
                NuevoUsuario = new Usuarios();
                Utilitario.LimpiarCampos(this.grpBox);

                var respuesta = Utilitario.Pregunta("Usuario insertado correctamente." + Environment.NewLine + "¿Desea insertar otro usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta == DialogResult.No)
                {
                    btnCancelar.PerformClick();
                }

            }
            catch (Exception)
            {
                Utilitario.Mensaje("Error al insertar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Arrow;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = formulario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            tab.SelectedTab = listado;
            Utilitario.LimpiarCampos(this.grpBox);
            btnBuscar.PerformClick();
        }

        private void frmCreacionUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.creacionUsuario = null;
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {

            if (!Utilitario.EsValido(this.grpBox, NuevoUsuario, nameof(NuevoUsuario.Usuario)))
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            if (UsuariosBD.Existe(txtUsuario.Text))
            {
                lblErrortxtUsuario.Text = "* Usuario se encuentra en uso.";
                usuarioValidacion = false;
                Cursor = Cursors.Arrow;
                return;
            }

            usuarioValidacion = true;
            Cursor = Cursors.Arrow;
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this.grpBox, NuevoUsuario, nameof(NuevoUsuario.Contraseña)))
            {
                return;
            }
        }

        private void txtConfirmarContraseña_Validating(object sender, CancelEventArgs e)
        {
            validarConfirmarContraseña();
        }

        private void validarConfirmarContraseña()
        {
            if (!Utilitario.EsValido(this.grpBox, NuevoUsuario, nameof(NuevoUsuario.ConfirmarContraseña)))
            {
                return;
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this.grpBox, NuevoUsuario, nameof(NuevoUsuario.CorreoElectronico)))
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            if (UsuariosBD.ExisteCorreo(txtCorreoElectronico.Text))
            {
                lblErrortxtCorreoElectronico.Text = "* Este correo ya se encuentra en uso.";
                Cursor = Cursors.Arrow;
                correoValidacion = false;
                return;
            }

            correoValidacion = true;
            Cursor = Cursors.Arrow;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtUsuario.Text = string.Empty;
            NuevoUsuario.Usuario = txtUsuario.Text.Trim();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtContraseña.Text = string.Empty;
            NuevoUsuario.Contraseña = txtContraseña.Text.Trim();

        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {

            lblErrortxtConfirmarContraseña.Text = string.Empty;
            NuevoUsuario.ConfirmarContraseña = txtConfirmarContraseña.Text.Trim();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtCorreoElectronico.Text = string.Empty;
            NuevoUsuario.CorreoElectronico = txtCorreoElectronico.Text.Trim();
        }

        private void tab_Selected(object sender, TabControlEventArgs e)
        {
            if (tab.SelectedTab == listado)
            {
                Cursor = Cursors.WaitCursor;
                llenarDataGrid(UsuariosBD.Filtrar());
                Cursor = Cursors.Arrow;
            }
        }

        private void llenarDataGrid(IEnumerable<Usuarios> lista)
        {
            dataGridUsuarios.Rows.Clear();
            foreach (Usuarios usuario in lista)
            {
                dataGridUsuarios.Rows.Add(
                    usuario.Id,
                    usuario.Usuario,
                    usuario.CorreoElectronico,
                    ((Estatus.TipoEstatus)usuario.Estatus).ToName());
            }
        }

        private void frmCreacionUsuario_Load(object sender, EventArgs e)
        {
            Utilitario.esconderCabezerasTabs(tab);
            Cursor = Cursors.WaitCursor;
            llenarDataGrid(UsuariosBD.Filtrar());
            Cursor = Cursors.Arrow;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                llenarDataGrid(UsuariosBD.Filtrar(txtBuscar.Text.Trim()));
            }
            else
            {
                llenarDataGrid(UsuariosBD.Filtrar());
            }
            Cursor = Cursors.Arrow;
        }

        private bool esValido()
        {
            return usuarioValidacion && correoValidacion;
        }
    }
}

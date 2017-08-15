using Sistema_Estudiantil_Universitario.Helpers;
using Sistema_Estudiantil_Universitario.Modales;
using Sistema_Estudiantil_Universitario.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estudiantil_Universitario
{
    public partial class frmPrincipal : Form
    {
        public static frmMaestros maestros;
        public static frmAsignaturas asignaturas;
        public static frmAlumnos alumnos;
        public static frmHorarios horarios;
        public static frmProfesion profesion;
        public static frmSeccion seccion;
        public static frmCreacionUsuario creacionUsuario;
        public static frmCambioClave cambiarClave;
        public static string usuarioLogueado = string.Empty;
        public static frmLogin login;
        public static StatusBar mainStatusBar = new StatusBar();
        public static StatusBarPanel panelEstatus = new StatusBarPanel();
        public static StatusBarPanel panelHora = new StatusBarPanel();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            var respuesta = Utilitario.Pregunta("¿Esta seguro de que desea cerrar la sesión?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (respuesta == DialogResult.Yes)
            {
                cerrarTodasLasVentanas();
                login = new frmLogin();
                login.ShowDialog();
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarTodasLasVentanas();
        }

        private void cerrarTodasLasVentanas()
        {
            ActualizarStatusBar(string.Empty);
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            login = new frmLogin();
            login.ShowDialog();

            panelEstatus.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            panelEstatus.AutoSize = StatusBarPanelAutoSize.Spring;
            mainStatusBar.Panels.Add(panelEstatus);

            panelHora.BorderStyle = StatusBarPanelBorderStyle.Raised;
            panelHora.ToolTipText = "Hora: " + DateTime.Today.ToString();
            panelHora.Text = DateTime.Today.ToLongDateString();
            panelHora.AutoSize = StatusBarPanelAutoSize.Contents;
            mainStatusBar.Panels.Add(panelHora);

            mainStatusBar.ShowPanels = true;
            Controls.Add(mainStatusBar);
        }

        public static void ActualizarStatusBar(string usuario = "")
        {
            usuario = string.IsNullOrEmpty(usuario) ? "Inicio de sesión..." : usuario;
            panelEstatus.Text = "Bienvenid@ " + usuario;
            panelEstatus.ToolTipText = "Bienvenid@ " + usuario;
            usuarioLogueado = usuario;
        }

        private void menuItemMaestros_Click(object sender, EventArgs e)
        {
            if (maestros == null)
            {
                maestros = new frmMaestros();
                maestros.MdiParent = this;
                maestros.Show();
            }
            else
            {
                maestros.Activate();
            }
        }

        private void menuItemAsignatura_Click(object sender, EventArgs e)
        {
            if (asignaturas == null)
            {
                asignaturas = new frmAsignaturas();
                asignaturas.MdiParent = this;
                asignaturas.Show();
            }
            else
            {
                asignaturas.Activate();
            }
        }

        private void menuItemAlumno_Click(object sender, EventArgs e)
        {
            if (alumnos == null)
            {
                alumnos = new frmAlumnos();
                alumnos.MdiParent = this;
                alumnos.Show();
            }
            else
            {
                alumnos.Activate();
            }
        }

        private void menuItemSeccion_Click(object sender, EventArgs e)
        {
            if (seccion == null)
            {
                seccion = new frmSeccion();
                seccion.MdiParent = this;
                seccion.Show();
            }
            else
            {
                seccion.Activate();
            }
        }

        private void menuItemHorario_Click(object sender, EventArgs e)
        {
            if (horarios == null)
            {
                horarios = new frmHorarios();
                horarios.MdiParent = this;
                horarios.Show();
            }
            else
            {
                horarios.Activate();
            }
        }

        private void menuItemProfesion_Click(object sender, EventArgs e)
        {
            if (profesion == null)
            {
                profesion = new frmProfesion();
                profesion.MdiParent = this;
                profesion.Show();
            }
            else
            {
                profesion.Activate();
            }
        }

        private void estudiantesFemeninasEnHorarioVespertinoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (creacionUsuario == null)
            {
                creacionUsuario = new frmCreacionUsuario();
                creacionUsuario.MdiParent = this;
                creacionUsuario.Show();
            }
            else
            {
                creacionUsuario.Activate();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (cambiarClave == null)
            {
                cambiarClave = new frmCambioClave();
                cambiarClave.MdiParent = this;
                cambiarClave.Show();
            }
            else
            {
                cambiarClave.Activate();
            }
        }
    }
}

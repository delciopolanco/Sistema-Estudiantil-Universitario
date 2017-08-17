using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estudiantil_Universitario.Modulos
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listado.Hide();
            formulario.Show();
        }

        private void frmAlumnos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.alumnos = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formulario.Hide();
            listado.Show();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            txtMatricula.Text = String.Format("{0:yy-}", DateTime.Now);
        }
    }
}

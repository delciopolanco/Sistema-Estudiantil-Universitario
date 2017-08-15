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
    public partial class frmSeccion : Form
    {
        public frmSeccion()
        {
            InitializeComponent();
        }

        private void frmSeccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.seccion = null;
        }
    }
}

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
    public partial class frmHorarios : Form
    {
        public frmHorarios()
        {
            InitializeComponent();
        }

        private void frmHorarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.horarios = null;
        }
    }
}

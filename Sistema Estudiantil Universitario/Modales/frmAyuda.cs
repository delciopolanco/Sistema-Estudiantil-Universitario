﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Estudiantil_Universitario.Modales
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void frmAyuda_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.ayuda = null;
        }
    }
}

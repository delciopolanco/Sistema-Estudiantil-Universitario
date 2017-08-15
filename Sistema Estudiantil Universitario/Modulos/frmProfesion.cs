using Sistema_Estudiantil_Universitario.Datos;
using Sistema_Estudiantil_Universitario.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sistema_Estudiantil_Universitario.Modulos
{
    public partial class frmProfesion : Form
    {
        private ProfesionesModel ProfesionesBD;
        private Profesiones NuevaProfesion;

        private bool profesionValidacion = true;

        public frmProfesion()
        {
            InitializeComponent();
            ProfesionesBD = new ProfesionesModel(new UniDBEntity());
            NuevaProfesion = new Profesiones();
        }

        private void frmProfesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.profesion = null;
        }

        private void frmProfesion_Load(object sender, EventArgs e)
        {
            Utilitario.esconderCabezerasTabs(tab);
            Cursor = Cursors.WaitCursor;
            llenarDataGrid(ProfesionesBD.Filtrar());
            Cursor = Cursors.Arrow;
        }

        private void llenarDataGrid(IEnumerable<Profesiones> lista)
        {
            dataGridUsuarios.Rows.Clear();
            IEnumerable<Profesiones> listaProfesiones = lista;
            foreach (Profesiones profesion in listaProfesiones)
            {
                dataGridUsuarios.Rows.Add(
                    profesion.Id,
                    profesion.Profesion,
                    String.Format(((Math.Round(profesion.Duracion) == profesion.Duracion) ? "{0:0} meses" : "{0:0.0} meses"), profesion.Duracion)
                );
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NuevaProfesion = new Profesiones()
            {
                Profesion = txtProfesion.Text.Trim(),
                Duracion = txtDuracion.Value,
            };

            if (!Utilitario.EsValido(this.grpBox, NuevaProfesion) || !profesionValidacion)
            {
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                ProfesionesBD.Agregar(NuevaProfesion);
                NuevaProfesion = new Profesiones();
                Utilitario.LimpiarCampos(this.grpBox);

                var respuesta = Utilitario.Pregunta("Profesión insertada correctamente." + Environment.NewLine + "¿Desea insertar otra profesión?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta == DialogResult.No)
                {
                    btnCancelar.PerformClick();
                }

            }
            catch (Exception)
            {
                Utilitario.Mensaje("Error al insertar la profesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Arrow;
        }

        private void txtProfesion_Validating(object sender, CancelEventArgs e)
        {


            if (!Utilitario.EsValido(this.grpBox, NuevaProfesion, nameof(NuevaProfesion.Profesion)))
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            if (ProfesionesBD.Existe(txtProfesion.Text))
            {
                lblErrortxtProfesion.Text = "* Profesion ya se encuentra registrada.";
                profesionValidacion = false;
                Cursor = Cursors.Arrow;
                return;
            }

            profesionValidacion = true;
            Cursor = Cursors.Arrow;
        }

        private void txtProfesion_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtProfesion.Text = string.Empty;
            NuevaProfesion.Profesion = txtProfesion.Text.Trim();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = formulario;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                llenarDataGrid(ProfesionesBD.Filtrar(txtBuscar.Text.Trim()));
            }
            else
            {
                llenarDataGrid(ProfesionesBD.Filtrar());
            }
            Cursor = Cursors.Arrow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            tab.SelectedTab = listado;
            Utilitario.LimpiarCampos(this.grpBox);
            btnBuscar.PerformClick();
        }

        private void txtDuracion_ValueChanged(object sender, EventArgs e)
        {
            lblErrortxtDuracion.Text = string.Empty;
            NuevaProfesion.Duracion = txtDuracion.Value;
        }

        private void txtDuracion_Validating(object sender, CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this.grpBox, Duracion, nameof(NuevaProfesion.Duracion)))
            {
                return;
            }
        }
    }
}

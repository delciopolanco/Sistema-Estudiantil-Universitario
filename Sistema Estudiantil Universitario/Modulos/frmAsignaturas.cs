using Sistema_Estudiantil_Universitario.Datos;
using Sistema_Estudiantil_Universitario.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_Estudiantil_Universitario.Modulos
{
    public partial class frmAsignaturas : Form
    {
        private AsignaturasModel AsignaturasBD;
        private Asignaturas NuevaAsignatura;
        private bool asignaturaValidacion = true;

        public frmAsignaturas()
        {
            InitializeComponent();
            AsignaturasBD = new AsignaturasModel();
            NuevaAsignatura = new Asignaturas();
        }

        private void frmAsignaturas_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.asignaturas = null;
        }

        private void frmAsignaturas_Load(object sender, EventArgs e)
        {
            Utilitario.esconderCabezerasTabs(tab);
            Cursor = Cursors.WaitCursor;
            llenarDataGrid(AsignaturasBD.Filtrar());
            Cursor = Cursors.Arrow;
        }

        private void llenarDataGrid(IEnumerable<Asignaturas> lista)
        {
            dataGridAsignaturas.Rows.Clear();

            foreach (Asignaturas asignatura in lista)
            {

                dataGridAsignaturas.Rows.Add(
                    asignatura.Id,
                    asignatura.Asignatura
                );
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listado.Hide();
            formulario.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                llenarDataGrid(AsignaturasBD.Filtrar(txtBuscar.Text.Trim()));
            }
            else
            {
                llenarDataGrid(AsignaturasBD.Filtrar());
            }
            Cursor = Cursors.Arrow;
        }

        private void txtAsignatura_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtAsignatura.Text = string.Empty;
            NuevaAsignatura.Asignatura = txtAsignatura.Text;
        }

        private void txtAsignatura_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this.grpBox, NuevaAsignatura, nameof(NuevaAsignatura.Asignatura)))
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            if (AsignaturasBD.Existe(txtAsignatura.Text.Trim()))
            {
                lblErrortxtAsignatura.Text = "* Esta asignatura ya se encuentra registada.";
                Cursor = Cursors.Arrow;
                asignaturaValidacion = false;
                return;
            }

            asignaturaValidacion = true;
            Cursor = Cursors.Arrow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formulario.Hide();
            listado.Show();
            Cursor = Cursors.WaitCursor;
            llenarDataGrid(AsignaturasBD.Filtrar());
            Utilitario.LimpiarCampos(this.grpBox);
            Cursor = Cursors.Arrow;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NuevaAsignatura = new Asignaturas()
            {
               Asignatura = txtAsignatura.Text.Trim()
            };

            if (!Utilitario.EsValido(this.grpBox, NuevaAsignatura) || !asignaturaValidacion)
            {
                return;
            }

            try
            {
                var insetar = Utilitario.Pregunta("¿Desea realmente insertar esta asignatura?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (insetar == DialogResult.Yes)
                {

                    Cursor = Cursors.WaitCursor;
                    AsignaturasBD.Agregar(NuevaAsignatura);
                    NuevaAsignatura = new Asignaturas();
                    Utilitario.LimpiarCampos(this.grpBox);

                    var respuesta = Utilitario.Pregunta("Asignatura insertado correctamente." + Environment.NewLine + "¿Desea insertar otra asignatura?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.No)
                    {
                        btnCancelar.PerformClick();
                    }
                }

            }
            catch (Exception)
            {
                Utilitario.Mensaje("Error al insertar asignatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Arrow;
        }
    }
}

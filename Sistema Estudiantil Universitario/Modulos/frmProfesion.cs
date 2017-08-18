using Sistema_Estudiantil_Universitario.Datos;
using Sistema_Estudiantil_Universitario.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            ProfesionesBD = new ProfesionesModel();
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
            dataGridProfesiones.Rows.Clear();
            IEnumerable<Profesiones> listaProfesiones = lista;
            string[] duracion = new string[] { };
            int años = 0;
            int meses = 0;

            foreach (Profesiones profesion in listaProfesiones)
            {
                duracion = profesion.Duracion.ToString().Split('.');
                años = int.Parse(duracion[0]);
                meses = 0;

                if (duracion.Length > 1)
                    meses = int.Parse(duracion[1]);

                string profesionDuracion = ObtenerDuracionLiteral(años, meses);

                dataGridProfesiones.Rows.Add(
                    profesion.Id,
                    profesion.Codigo,
                    profesion.Profesion,
                    profesionDuracion
                );
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NuevaProfesion = new Profesiones()
            {
                Profesion = txtProfesion.Text.Trim(),
                Duracion = txtDuracion.Value,
                Codigo = txtCodigoProfesion.Text
            };

            if (!Utilitario.EsValido(this.grpBox, NuevaProfesion) || !profesionValidacion)
            {
                return;
            }

            try
            {
                var insetar = Utilitario.Pregunta("¿Desea realmente insertar esta profesión?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (insetar == DialogResult.Yes)
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
            txtCodigoProfesion.Text = string.Empty;
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

        private string ObtenerDuracionLiteral(int años, int meses)
        {
            string literalAños = años > 1 ? " años y " : " año y ";
            string literalMeses = meses > 1 ? " meses" : " mes";

            if (meses == 0)
            {
                return años > 1 ? años + " años" : años + " año";
            }
            return años + literalAños + meses + literalMeses;
        }

        private void txtDuracion_ValueChanged(object sender, EventArgs e)
        {
            lblErrortxtDuracion.Text = string.Empty;
            NuevaProfesion.Duracion = txtDuracion.Value;

            if (txtDuracion.Value <= 100)
            {
                string[] duracion = txtDuracion.Value.ToString().Split('.');
                int años = int.Parse(duracion[0]);
                int meses = 0;

                if (duracion.Length > 1)
                {
                    meses = int.Parse(duracion[1]);
                }
                lblDuracion.Text = ObtenerDuracionLiteral(años, meses);
            }

        }

        private void txtDuracion_Validating(object sender, CancelEventArgs e)
        {

            if (!Utilitario.EsValido(this.grpBox, Duracion, nameof(NuevaProfesion.Duracion)))
            {
                return;
            }
        }

        private string ObtenerCodigo(string[] profesion)
        {
            var codigo = string.Empty;
            string[] conectores = new string[] { "de", "la", "en" };

            foreach (string palabra in profesion)
            {
                if (!palabra.ToLower().Contains("de") && !palabra.ToLower().Contains("la") && !palabra.ToLower().Contains("en"))
                    {
                    codigo = palabra.Substring(0, 1);
                    break;
                }
            }
            return codigo;
        }

        private void txtProfesion_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProfesion.Text))
            {
                char[] delimitadores = new char[] { ' ' };
                string[] profesion = txtProfesion.Text.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries);
                string codigo = txtProfesion.Text.Substring(0, 1);

                if (profesion.Length > 1)
                {
                    codigo += this.ObtenerCodigo(profesion.Where((source, index) => index != 0).ToArray());
                }
                else
                {
                    codigo += codigo;
                }

                txtCodigoProfesion.Text = codigo;
            }
            else
            {
                txtCodigoProfesion.Text = string.Empty;
            }
        }
    }
}

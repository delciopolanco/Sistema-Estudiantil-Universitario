using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sistema_Estudiantil_Universitario.Datos;
using Sistema_Estudiantil_Universitario.Helpers;

namespace Sistema_Estudiantil_Universitario.Modulos
{
    public partial class frmHorarios : Form
    {
        private HorariosModel HorariosBD;
        private Horarios NuevoHorario;
        private bool horarioValidacion = true;

        public frmHorarios()
        {
            InitializeComponent();
            HorariosBD = new HorariosModel();
            NuevoHorario = new Horarios();
        }

        private void frmHorarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.horarios = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                llenarDataGrid(HorariosBD.Filtrar(txtBuscar.Text.Trim()));
            }
            else
            {
                llenarDataGrid(HorariosBD.Filtrar());
            }
            Cursor = Cursors.Arrow;
        }

        private void llenarDataGrid(IEnumerable<Horarios> lista)
        {
            dataGridHorarios.Rows.Clear();

            foreach (Horarios horario in lista)
            {
                dataGridHorarios.Rows.Add(
                    horario.Id,
                    horario.Horario
                );
            }
        }

        private void frmHorarios_Load(object sender, EventArgs e)
        {
            Utilitario.esconderCabezerasTabs(tab);
            Cursor = Cursors.WaitCursor;
            llenarDataGrid(HorariosBD.Filtrar());
            Cursor = Cursors.Arrow;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tab.SelectedTab = formulario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NuevoHorario = new Horarios()
            {
                Horario = txtHorario.Text.Trim(),
            };

            if (!Utilitario.EsValido(this.formulario, NuevoHorario) || !horarioValidacion)
            {
                return;
            }

            try
            {
                var insetar = Utilitario.Pregunta("¿Desea realmente insertar este horario?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (insetar == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    HorariosBD.Agregar(NuevoHorario);
                    NuevoHorario = new Horarios();
                    Utilitario.LimpiarCampos(this);

                    var respuesta = Utilitario.Pregunta("Horario insertado correctamente." + Environment.NewLine + "¿Desea insertar otro horario?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.No)
                    {
                        btnCancelar.PerformClick();
                    }
                }

            }
            catch (Exception)
            {
                Utilitario.Mensaje("Error al insertar el horario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Arrow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            tab.SelectedTab = listado;
            Utilitario.LimpiarCampos(this.formulario);
            btnBuscar.PerformClick();
        }

        private void txtHorario_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtHorario.Text = string.Empty;
            NuevoHorario.Horario = txtHorario.Text.Trim();
        }

        private void txtHorario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this.formulario, NuevoHorario, nameof(NuevoHorario.Horario)))
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            if (HorariosBD.Existe(txtHorario.Text))
            {
                lblErrortxtHorario.Text = "* Horario ya se encuentra registrado.";
                horarioValidacion = false;
                Cursor = Cursors.Arrow;
                return;
            }

            horarioValidacion = true;
            Cursor = Cursors.Arrow;
        }
    }
}

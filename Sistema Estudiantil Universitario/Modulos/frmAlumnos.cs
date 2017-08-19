using Sistema_Estudiantil_Universitario.Datos;
using Sistema_Estudiantil_Universitario.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Sistema_Estudiantil_Universitario.Enums.TipoDocentes;

namespace Sistema_Estudiantil_Universitario.Modulos
{
    public partial class frmAlumnos : Form
    {
        private static Modales.frmListadoProfesiones listadoProfesiones = new Modales.frmListadoProfesiones();

        private DocentesModel DocentesBD;
        private Docentes NuevoDocente;
        private static bool validacionIdentificacion = true;

        public frmAlumnos()
        {
            InitializeComponent();
            DocentesBD = new DocentesModel();
            NuevoDocente = new Docentes();
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
            Cursor = Cursors.WaitCursor;
            llenarDataGrid(DocentesBD.Filtrar());
            Cursor = Cursors.Arrow;
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            Utilitario.esconderCabezerasTabs(tab);
            Cursor = Cursors.WaitCursor;
            llenarDataGrid(DocentesBD.Filtrar());
            Cursor = Cursors.Arrow;
        }

        private void llenarHorarios()
        {
            var lista = listadoProfesiones.profesionSeleccionada.Horarios;

            txtHorario.Items.Clear();

            foreach (Horarios horario in lista)
            {
                txtHorario.Items.Add(horario);
            }

            txtHorario.DisplayMember = "Horario";
            txtHorario.ValueMember = "Id";
            txtHorario.SelectedIndex = 0;
            NuevoDocente.Horario = ((Horarios)txtHorario.Items[0]).Id;
        }

        private void llenarDataGrid(IEnumerable<Docentes> lista)
        {
            dataGridUsuarios.Rows.Clear();
            foreach (Docentes docente in lista)
            {
                dataGridUsuarios.Rows.Add(
                    docente.Id,
                    docente.Nombres,
                    docente.Apellidos,
                    docente.Identificacion,
                    docente.Matricula,
                    docente.Profesiones.Profesion);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NuevoDocente = new Docentes()
            {
                Nombres = txtNombres.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Identificacion = txtIdentificacion.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                TipoDocente = (int)TipoDocente.Estudiante,
                FechaNacimiento = txtFechaNacimiento.Value,
                Horario = ((Horarios)txtHorario.Items[txtHorario.SelectedIndex]).Id,
                Tanda = ((Horarios)txtHorario.Items[txtHorario.SelectedIndex]).Horario,
                IdProfesion = listadoProfesiones.profesionSeleccionada.Id,
                CodigoProfesion = listadoProfesiones.profesionSeleccionada.Codigo,
                Sexo = rdlFemenino.Checked ? (int)Sexo.Femenino : (int)Sexo.Masculino

            };

            if (!Utilitario.EsValido(this.grpBox, NuevoDocente) || !validacionIdentificacion)
            {
                return;
            }

            try
            {
                var insetar = Utilitario.Pregunta("¿Desea realmente insertar este Alumno?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (insetar == DialogResult.Yes)
                {

                    Cursor = Cursors.WaitCursor;
                    DocentesBD.Agregar(NuevoDocente);
                    NuevoDocente = new Docentes();
                    Utilitario.LimpiarCampos(this.grpBox);

                    var respuesta = Utilitario.Pregunta("Alumno insertado correctamente." + Environment.NewLine + "¿Desea insertar otro Alumno?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.No)
                    {
                        btnCancelar.PerformClick();
                    }
                }

            }
            catch (Exception)
            {
                Utilitario.Mensaje("Error al insertar alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Arrow;
        }

        private void txtHorario_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtHorario.SelectedIndex >= 0)
            {
                lblErrorTxtHorario.Text = string.Empty;
                NuevoDocente.Horario = ((Horarios)txtHorario.Items[txtHorario.SelectedIndex]).Id;
            }
        }

        private void btnElegirProfesion_Click(object sender, EventArgs e)
        {
            listadoProfesiones.ShowDialog();
            txtIdProfesion.Text = listadoProfesiones.profesionSeleccionada.Profesion;
            llenarHorarios();
        }

        private void txtIdProfesion_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtIdProfesion.Text = string.Empty;
            NuevoDocente.IdProfesion = listadoProfesiones.profesionSeleccionada.Id;
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtNombres.Text = string.Empty;
            NuevoDocente.Nombres = txtNombres.Text;
        }

        private void txtNombres_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this.grpBox, NuevoDocente, nameof(NuevoDocente.Nombres)))
            {
                return;
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtApellidos.Text = string.Empty;
            NuevoDocente.Apellidos = txtApellidos.Text;
        }

        private void txtApellidos_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this.grpBox, NuevoDocente, nameof(NuevoDocente.Apellidos)))
            {
                return;
            }
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtIdentificacion.Text = string.Empty;
            NuevoDocente.Identificacion = txtIdentificacion.Text;
        }

        private void txtIdentificacion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this.grpBox, NuevoDocente, nameof(NuevoDocente.Identificacion)))
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            if (DocentesBD.Existe(txtIdentificacion.Text.Trim()))
            {
                lblErrortxtIdentificacion.Text = "* Esta identificación ya se encuentra registada.";
                Cursor = Cursors.Arrow;
                validacionIdentificacion = false;
                return;
            }

            validacionIdentificacion = true;
            Cursor = Cursors.Arrow;

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtTelefono.Text = string.Empty;
            NuevoDocente.Telefono = txtTelefono.Text;
        }

        private void txtTelefono_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this.grpBox, NuevoDocente, nameof(NuevoDocente.Telefono)))
            {
                return;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            lblErrortxtDireccion.Text = string.Empty;
            NuevoDocente.Direccion = txtDireccion.Text;
        }

        private void txtDireccion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Utilitario.EsValido(this.grpBox, NuevoDocente, nameof(NuevoDocente.Direccion)))
            {
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                llenarDataGrid(DocentesBD.Filtrar(txtBuscar.Text.Trim()));
            }
            else
            {
                llenarDataGrid(DocentesBD.Filtrar());
            }
            Cursor = Cursors.Arrow;
        }
    }
}

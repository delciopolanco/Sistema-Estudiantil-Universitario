using System;
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
    public partial class frmListadoProfesiones : Form
    {
        private Datos.ProfesionesModel ProfesionesBD;

        private Datos.Profesiones profesion = new Datos.Profesiones();
        public Datos.Profesiones profesionSeleccionada
        {
            get { return profesion; }
            set { profesion = value; }
        }

        public frmListadoProfesiones()
        {
            ProfesionesBD = new Datos.ProfesionesModel();
            InitializeComponent();
        }

        private void listadoProfesiones_Load(object sender, EventArgs e)
        {
            Helpers.Utilitario.esconderCabezerasTabs(tab);
            Cursor = Cursors.WaitCursor;
            llenarDataGrid(ProfesionesBD.Filtrar());
            Cursor = Cursors.Arrow;
        }


        private void llenarDataGrid(IEnumerable<Datos.Profesiones> lista)
        {
            if(lista.Count() <= 0)
            {
                lblInfo.Text = "Actualmente no posee profesiones registrada.";
                return;
            }

            dataGridProfesiones.Rows.Clear();

            foreach (Datos.Profesiones profesion in lista)
            {
                dataGridProfesiones.Rows.Add(
                    profesion.Id,
                    profesion.Codigo,
                    profesion.Profesion
                );
            }
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

        private void dataGridProfesiones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            profesion.Id = int.Parse(dataGridProfesiones.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            profesion.Codigo = dataGridProfesiones.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            profesion.Profesion = dataGridProfesiones.Rows[e.RowIndex].Cells["Profesion"].Value.ToString();
            profesion.Horarios = ProfesionesBD.ObtenerHorarios(profesion.Id);
            this.Close();
        }
    }
}

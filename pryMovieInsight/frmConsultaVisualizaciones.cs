using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMovieInsight
{
    public partial class frmConsultaVisualizaciones : Form
    {
        public frmConsultaVisualizaciones()
        {
            InitializeComponent();
        }

        private void frmConsultaVisualizaciones_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();
            for (Int32 i = 0; i < Registro.IND; i++) // Acá utilicé el índice del registro para que me muestre solo los generos que se encuentren cargados en el vector.
            {
                cmbGenero.Items.Add(Registro.Genero[i].Nombre);
            }
            cmbMes.Items.Clear();
            for (Int32 i = 0; i < 12; i++) //Acá utilicé el valor doce para que muestre los doce meses del vector.
            {
                cmbMes.Items.Add(Registro.Meses[i]);
            }
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 fila = cmbGenero.SelectedIndex;
            Int32 columna = cmbMes.SelectedIndex;

            lblCantidad.Text = Matriz.Visualizaciones[fila,columna].ToString();
        }

    }
}

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
    public partial class frmRegistrarVisualizaciones : Form
    {
        public frmRegistrarVisualizaciones()
        {
            InitializeComponent();
        }

        private void frmRegistrarVisualizaciones_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();
            for (Int32 i = 0; i < Registro.IND ; i++) // Acá utilicé el índice del registro para que me muestre solo los generos que se encuentren cargados en el vector.
            {
                cmbGenero.Items.Add(Registro.Genero[i].Nombre);
            }
            cmbMes.Items.Clear();
            for (Int32 i = 0;i < 12; i++) //Acá utilicé el valor doce para que muestre los doce meses del vector.
            {
                cmbMes.Items.Add(Registro.Meses[i]);
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            Int32 fila = cmbGenero.SelectedIndex;
            Int32 columna = cmbMes.SelectedIndex;
            Int32 Visualización = Convert.ToInt32(txtCantidad.Text);

            Matriz.Visualizaciones[fila, columna] = Matriz.Visualizaciones[fila, columna] + Visualización; //Aca se suma el valor actual de la celda de la matriz más el valor ingresado por el usuario
            MessageBox.Show("Visualización cargada correctamente");            
            txtCantidad.Text = "";
        }
    }
}

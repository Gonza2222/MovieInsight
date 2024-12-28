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
    public partial class frmVisualizacionesGenero : Form
    {
        public frmVisualizacionesGenero()
        {
            InitializeComponent();
        }

        private void frmVisualizacionesGenero_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();
            for (Int32 i = 0; i < Registro.IND; i++) //Acá utilicé "Registro.IND" para que tome el largo del vector de los generos cargados como referencia.
            {
                cmbGenero.Items.Add(Registro.Genero[i].Nombre);
            }
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 fila = cmbGenero.SelectedIndex;
            Int32 columna = 0;
            Int32 Max = 0;
            Int32 Min = int.MaxValue;  // usé int.MaxValue para comenzar con el valor mas alto posible
            float Total = 0; // Usé el tipo float para que me dé mas especifico el resultado del promedio
            float Promedio; // Usé el tipo float para que me dé mas especifico el resultado del promedio

            dgvVisualizaciones.Rows.Clear();
            while (columna < Registro.Meses.Length)
            {
                dgvVisualizaciones.Rows.Add(Registro.Meses[columna], Matriz.Visualizaciones[fila, columna]);
                Total = Total + Matriz.Visualizaciones[fila, columna]; //Acumulador para sacar el promedio despues

                if (Matriz.Visualizaciones[fila, columna] > Max)
                {
                    Max = Matriz.Visualizaciones[fila, columna];
                    lblVisMax.Text = Max.ToString();
                }
                if (Matriz.Visualizaciones[fila, columna] < Min)
                {
                    Min = Matriz.Visualizaciones[fila, columna];
                    lblVisMin.Text = Min.ToString();
                }
                columna++;
            }
            lblCantidad.Text = Total.ToString();
            Promedio = Total / Registro.Meses.Length;
            lblPromedio.Text = Promedio.ToString("0.00");
        }
    }
}

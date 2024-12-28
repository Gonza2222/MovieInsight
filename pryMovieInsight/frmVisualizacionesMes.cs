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
    public partial class frmVisualizacionesMes : Form
    {
        public frmVisualizacionesMes()
        {
            InitializeComponent();
        }

        private void frmVisualizacionesMes_Load(object sender, EventArgs e)
        {
            cmbMes.Items.Clear();
            for (Int32 i = 0; i < 12; i++) //Acá utilicé el valor doce para que muestre los doce meses del vector.
            {
                cmbMes.Items.Add(Registro.Meses[i]);
            }
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 fila = 0;
            Int32 columna = cmbMes.SelectedIndex;
            Int32 Max = 0;
            Int32 Min = int.MaxValue;  // usé int.MaxValue para comenzar con el valor mas alto posible
            float Total = 0; // Usé el tipo float para que me dé mas especifico el resultado del promedio
            float Promedio; // Usé el tipo float para que me dé mas especifico el resultado del promedio
            lblVisMax.Text = "";
            lblVisMin.Text = "";

            dgvVisualizaciones.Rows.Clear();
            while (fila < Registro.IND ) 
            {
                dgvVisualizaciones.Rows.Add(Registro.Genero[fila].Nombre, Matriz.Visualizaciones[fila, columna]);
                Total = Total + Matriz.Visualizaciones[fila, columna]; //Acumulador para sacar el promedio despues

                if (Matriz.Visualizaciones[fila, columna] > Max)
                {
                    Max = Matriz.Visualizaciones[fila, columna];
                    lblVisMax.Text = Max.ToString();
                }

                if (Matriz.Visualizaciones[fila, columna] < Min )
                {
                    Min = Matriz.Visualizaciones[fila, columna];
                    lblVisMin.Text = Min.ToString();
                }
                fila++;
            }
            lblCantidad.Text = Total.ToString();
            Promedio = Total / Registro.IND;
            lblPromedio.Text = Promedio.ToString("0.00");
        }
    }
}

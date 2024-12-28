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
    public partial class frmEstadisticaVisualizacionesGenero : Form
    {
        public frmEstadisticaVisualizacionesGenero()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            float Total = 0;
            float promedio;
            Int32 fila = 0;
            Int32 columna = 0;

            dgvVisualizaciones.Rows.Clear();
            while (fila < Registro.Genero.Length)
            {
                String NombreMax = "";
                String NombreMin = "";
                columna = 0;
                Total = 0;
                Int32 Max = 0; //Reinicializar estas variables antes de entrar en el bucle de las columnas IMPORTANTE!!
                Int32 Min = int.MaxValue;//Reinicializar estas variables antes de entrar en el bucle de las columnas IMPORTANTE!!
                while (columna < Registro.Meses.Length) 
                {
                    Total = Total + Matriz.Visualizaciones[fila, columna];
                    if (Matriz.Visualizaciones[fila,columna] > Max)
                    {
                        Max = Matriz.Visualizaciones[fila, columna];
                        NombreMax = Registro.Meses[columna];
                    }
                    if (Matriz.Visualizaciones[fila, columna] < Min)
                    {
                        Min = Matriz.Visualizaciones[fila, columna];
                        NombreMin = Registro.Meses[columna];
                    }
                    columna++;
                }
                promedio = Total / Registro.Meses.Length;
                dgvVisualizaciones.Rows.Add(Registro.Genero[fila].Nombre, Total, promedio, NombreMax, NombreMin);
                fila++;
            }
        }
    }
}

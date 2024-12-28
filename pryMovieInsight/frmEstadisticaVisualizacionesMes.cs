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
    public partial class frmEstadisticaVisualizacionesMes : Form
    {
        public frmEstadisticaVisualizacionesMes()
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
            while (columna < Registro.Meses.Length)
            {
                fila = 0;
                Total = 0;
                String NombreMax = "";
                String NombreMin = "";
                Int32 Max = int.MinValue; //Reinicializar estas variables antes de entrar en el bucle de las filas IMPORTANTE!!               
                Int32 Min = int.MaxValue;//Reinicializar estas variables antes de entrar en el bucle de las filas IMPORTANTE!!


                while (fila < Registro.Genero.Length)
                {
                    Total = Total + Matriz.Visualizaciones[fila, columna];
                    if (Matriz.Visualizaciones[fila, columna] > Max)
                    {
                        Max = Matriz.Visualizaciones[fila, columna];
                        NombreMax = Registro.Genero[fila].Nombre;
                    }
                    if (Matriz.Visualizaciones[fila, columna] < Min)
                    {
                        Min = Matriz.Visualizaciones[fila, columna];
                        NombreMin = Registro.Genero[fila].Nombre;
                    }                   
                    fila++;                    
                }
                promedio = Total / Registro.Genero.Length;
                dgvVisualizaciones.Rows.Add(Registro.Meses[columna], Total, promedio, NombreMax, NombreMin);
                columna++;
            }
            
        }
    }
}

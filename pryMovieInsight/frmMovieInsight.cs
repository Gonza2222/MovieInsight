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
    public partial class frmMovieInsight : Form
    {
        public frmMovieInsight()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe Ventana = new frmAcercaDe();
            Ventana.ShowDialog();
        }

        private void cargaAutomaticaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro.Genero[0].Código = 1;
            Registro.Genero[0].Nombre = "Acción";
            Registro.Genero[0].Descripción = "Películas llenas de emocionantes escenas de persecuciones, combates y situaciones de riesgo. ";

            Registro.Genero[1].Código = 2;
            Registro.Genero[1].Nombre = "Comedia";
            Registro.Genero[1].Descripción = "Películas diseñadas para hacer reír al público con situaciones cómicas y humor. ";

            Registro.Genero[2].Código = 3;
            Registro.Genero[2].Nombre = "Drama";
            Registro.Genero[2].Descripción = "Historias centradas en el desarrollo emocional de los personajes, a menudo explorando situaciones intensas.";

            Registro.Genero[3].Código = 4;
            Registro.Genero[3].Nombre = "Ciencia Ficción";
            Registro.Genero[3].Descripción = "Películas que presentan elementos de ciencia avanzada, tecnología futurista y conceptos imaginativos.";

            Registro.Genero[4].Código = 5;
            Registro.Genero[4].Nombre = "Romántica";
            Registro.Genero[4].Descripción = "Historias centradas en relaciones amorosas y emociones románticas.";

            Registro.Genero[5].Código = 6;
            Registro.Genero[5].Nombre = "Terror";
            Registro.Genero[5].Descripción = "Películas destinadas a asustar o provocar miedo en la audiencia.";

            Registro.Genero[6].Código = 7;
            Registro.Genero[6].Nombre = "Fantasía";
            Registro.Genero[6].Descripción = "Historias que incluyen elementos mágicos, criaturas extraordinarias y mundos imaginarios. ";

            Registro.Genero[7].Código = 8;
            Registro.Genero[7].Nombre = "Misterio";
            Registro.Genero[7].Descripción = "Películas que involucran la resolución de un enigma o crimen. ";

            Registro.Genero[8].Código = 9;
            Registro.Genero[8].Nombre = "Aventura";
            Registro.Genero[8].Descripción = "Narrativas emocionantes que siguen a los personajes en viajes y desafíos. ";

            Registro.Genero[9].Código = 10;
            Registro.Genero[9].Nombre = "Animación";
            Registro.Genero[9].Descripción = "Películas que utilizan técnicas de animación para contar historias, generalmente dirigidas a un público más joven. ";

            Registro.IND = 10;


            Random R = new Random(); //Objeto generador de numeros randoms

            for (Int32 fila = 0; fila < Registro.Genero.Length; fila++)
            {
                for (Int32 columna = 0; columna < Registro.Meses.Length; columna++)
                {
                    Matriz.Visualizaciones[fila, columna] = R.Next(0, 100);
                }
            }
            MessageBox.Show("Datos cargados correctamente");
        
        }

        private void agregarNuevoGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoGenero Ventana = new frmAgregarNuevoGenero();
            Ventana.ShowDialog();
        }

        private void listadoGeneralDeGénerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoGeneralGeneros Ventana = new frmListadoGeneralGeneros();
            Ventana.ShowDialog();
        }

        private void consultaDeDatosDeUnGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDatosGénero Ventana = new frmConsultaDatosGénero();
            Ventana.ShowDialog();
        }

        private void registrarVisualizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarVisualizaciones Ventana = new frmRegistrarVisualizaciones();
            Ventana.ShowDialog();
        }

        private void consultaDeVisualizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVisualizaciones Ventana = new frmConsultaVisualizaciones();
            Ventana.ShowDialog();
        }

        private void visualizacionesDeUnMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizacionesMes Ventana = new frmVisualizacionesMes();
            Ventana.ShowDialog();
        }

        private void visualizacionesDeUnGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizacionesGenero Ventana = new frmVisualizacionesGenero();
            Ventana.ShowDialog();
        }

        private void estadísticaDeVisualizacionesPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaVisualizacionesMes Ventana = new frmEstadisticaVisualizacionesMes();
            Ventana.ShowDialog();
        }
        private void estadísticaDeVisualizacionesPorGéneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaVisualizacionesGenero Ventana = new frmEstadisticaVisualizacionesGenero();
            Ventana.ShowDialog();
        }

        private void frmMovieInsight_Load(object sender, EventArgs e)
        {

        }
    }
}

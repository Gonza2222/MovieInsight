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
    public partial class frmConsultaDatosGénero : Form
    {
        public frmConsultaDatosGénero()
        {
            InitializeComponent();
        }

        private void frmConsultaDatosGénero_Load(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < Registro.IND; i++)
            {
                cmbGenero.Items.Add(Registro.Genero[i].Nombre);
            }
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 i = cmbGenero.SelectedIndex;
            lblCodigo.Text = Registro.Genero[i].Código.ToString();
            lblDescripción.Text = Registro.Genero[i].Descripción.ToString();
        }
    }
}

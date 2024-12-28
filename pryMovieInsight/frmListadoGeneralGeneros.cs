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
    public partial class frmListadoGeneralGeneros : Form
    {
        public frmListadoGeneralGeneros()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            dgvListadoGén.Rows.Clear();
            Int32 total = 0;
            for (Int32 i = 0 ; i < Registro.IND; i++)
            {
                dgvListadoGén.Rows.Add(Registro.Genero[i].Código, Registro.Genero[i].Nombre, Registro.Genero[i].Descripción);
                total = total + 1;
            }
            lblGénCar.Text = total.ToString();

        }
    }
}

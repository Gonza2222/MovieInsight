using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMovieInsight
{
    public partial class frmAgregarNuevoGenero : Form
    {
        public frmAgregarNuevoGenero()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Registro.IND < Registro.Genero.Length)
            {
                Registro.Genero[Registro.IND].Código = Convert.ToInt32(txtCod.Text);
                Registro.Genero[Registro.IND].Nombre = txtNombre.Text;
                Registro.Genero[Registro.IND].Descripción = txtDescp.Text;
                Registro.IND++;
                MessageBox.Show("Género agregado correctamente");
                txtCod.Text = "";
                txtNombre.Text = "";
                txtDescp.Text = "";
            }
            else
            {
                MessageBox.Show("Ya no hay más espacio para la carga de géneros");
                txtCod.Text = "";
                txtNombre.Text = "";
                txtDescp.Text = "";
            }
        }

        private void ControlarCaja()
        {
            if (txtCod.Text != "" && txtNombre.Text != "" && txtDescp.Text != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            ControlarCaja();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ControlarCaja();
        }

        private void txtDescp_TextChanged(object sender, EventArgs e)
        {
            ControlarCaja();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace appCajaRegistradora
{
    public partial class FormRegistrar : Form
    {
        Repositorio bd = new Repositorio();
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {
            nudCodigo.Focus();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void cbUnidad_SelectedValueChanged(object sender, EventArgs e)
        {
            int pos = cbUnidad.SelectedIndex;
            var valor = cbUnidad.SelectedItem.ToString();
            MessageBox.Show("Pos: "+pos+" -> "+valor);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}

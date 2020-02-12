using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCajaRegistradora
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea salir?","Cerrar Aplicacion", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                e.Cancel=true;
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            FormRegistrar fR = new FormRegistrar();

            fR.Show();
        }
    }
}

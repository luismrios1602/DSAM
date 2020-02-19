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
            errorForm.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                var resp = MessageBox.Show("¿Seguro que quieres almacenar el producto "+Convert.ToInt64(nudCodigo.Value)+" : "+txtNombre.Text+"?","Almacenar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    Productos p = new Productos(Convert.ToInt32(nudCodigo.Value),txtNombre.Text,cbUnidad.SelectedItem.ToString(),Convert.ToDouble(nudPrecio.Value));
                    if (bd.addProducto(p))
                    {
                        MessageBox.Show("Guardado!");
                        nudCodigo.Value = 0;
                        txtNombre.Clear();
                        cbUnidad.SelectedIndex = -1;
                        nudPrecio.Value = 0;
                        nudCodigo.Focus();
                    }
                } 
            }
            else
            {
                MessageBox.Show("Valiendo verga");
            }
        }

        private bool validarFormulario()
        {

            bool respuesta = true;

            if (Convert.ToInt64(nudCodigo.Value) == 0)
            {
                errorForm.SetError(nudCodigo, "El codigo no puede ser cero (0)");
                respuesta = false;
            } else
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    errorForm.Clear();
                    errorForm.SetError(txtNombre, "Valor vacío o nulo");
                    respuesta = false;
                }
                else
                {
                    if (cbUnidad.SelectedItem==null)
                    {
                        errorForm.Clear();
                        errorForm.SetError(cbUnidad, "Seleccione una Unidad");
                        respuesta = false;
                    }
                    else
                    {
                        if (Convert.ToInt64(nudPrecio.Value) <= 0)
                        {
                            errorForm.SetError(nudPrecio, "El precio no puede ser cero (0)");
                            respuesta = false;
                        }
                        else
                        {
                            errorForm.Clear(); //Si todo está correcto que elimine los errores generados
                        }
                    }
                }
            }

            return respuesta;
        }

        private void nudCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbUnidad.Focus();
                cbUnidad.DroppedDown = true;
            }
        }

        private void cbUnidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudPrecio.Focus();
                
            }
        }

        private void cbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nudPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistrar.Focus();

            }
        }
    }
}

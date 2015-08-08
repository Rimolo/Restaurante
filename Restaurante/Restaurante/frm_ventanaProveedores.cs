using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class frm_ventanaProveedores : Form
    {
        public frm_ventanaProveedores()
        {
            InitializeComponent();
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (rb_marcas.Checked == true)
            {
                frm_listaMarcas marcas = new frm_listaMarcas();
                marcas.Show();
            }
            else
            {
                if (rb_productos.Checked == true)
                {
                    frm_catalogoProductos catalogo = new frm_catalogoProductos();
                    catalogo.Show();
                }
                else
                {
                    if (rb_proveedores.Checked == true)
                    {
                        frm_listaProveedores proveedores = new frm_listaProveedores();
                        proveedores.Show();
                    }                    
                }
            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

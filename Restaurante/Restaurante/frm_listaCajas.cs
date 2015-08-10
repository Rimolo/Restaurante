using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace Restaurante
{
    public partial class frm_listaCajas : Form
    {
        Cajas objCajas = new Cajas();
        public frm_listaCajas()
        {
            InitializeComponent();
        }

        private void frm_listaCajas_Load(object sender, EventArgs e)
        {
            dt_registro.Value = DateTime.Today;
            carga_lista_cajas();
        }

        private void b_refrescar_Click(object sender, EventArgs e)
        {
            carga_lista_cajas();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            var form1 = (frm_ventanaSeguridad)Tag;
            form1.Show();
            this.Close();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_codigoRegistro.Text = "";
            txt_restaurante.Text = "";
            rb_aperturaCaja.Checked = false;
            rb_cierreCaja.Checked = false;
            dt_registro.Value = DateTime.Today; 
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            objCajas.codigo = null;
            objCajas.fecha = dt_registro.Value.ToString("dd/MM/yyyy");
            objCajas.apertura = 0;
            objCajas.cierre = 0;
            objCajas.codRest = null;
            if (txt_codigoRegistro.Text != "")
            {
                objCajas.codigo = txt_codigoRegistro.Text;

            }
            if (txt_restaurante.Text != "")
            {
                 objCajas.codRest =objCajas.obtener_cod_rest(txt_restaurante.Text);
            }
            if (rb_aperturaCaja.Checked)
            {
                objCajas.apertura = 1;
                objCajas.cierre = 0;
            }
            else {
                objCajas.apertura = 0;
                objCajas.cierre = 1;
            }
            try
            {
                dgv_cajas.AutoGenerateColumns = false;
                dgv_cajas.DataSource = objCajas.carga_cajas_especificos().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void carga_lista_cajas()
        {
            try
            {
                dgv_cajas.AutoGenerateColumns = false;
                dgv_cajas.DataSource = objCajas.carga_cajas().Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

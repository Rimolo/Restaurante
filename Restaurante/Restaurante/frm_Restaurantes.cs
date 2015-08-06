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
    public partial class frm_Restaurantes : Form
    {
        Restaurantes objRestaurantes = new Restaurantes();

        private string _accion;

        public string accion
        {
            get { return _accion; }
            set { _accion = value; }
        }

        private string _codigo;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public frm_Restaurantes()
        {
            InitializeComponent();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_direccion.Text = "";
            txt_especialidad.Text = "";
            txt_nombre.Text = "";
            if (chk_activo.Checked)
            {
                chk_activo.Checked = false;
            }
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor escriba un nombre al Restaurante", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_direccion))
            {
                MessageBox.Show("Por favor escriba la dirección del Restaurante", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_direccion.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_especialidad))
            {
                MessageBox.Show("Por favor escriba la especialidad", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_especialidad.Focus();
                return;
            }

            if (chk_activo.Checked)
            {
                objRestaurantes.activo = true;
            }
            else {
                objRestaurantes.activo = false;
            }

            objRestaurantes.codigo = txt_codigo.Text.Replace(" ", "");
            objRestaurantes.nombre = txt_nombre.Text;
            objRestaurantes.especialidad = txt_especialidad.Text;
            objRestaurantes.direccion = txt_direccion.Text;
            
            
            int tel = 0;
            string text = msk_telefono.Text.Replace("-", "");
            if (!Int32.TryParse(text, out tel))
            {
                objRestaurantes.tel = 0;
            }
            else
            {
                objRestaurantes.tel = tel;
            }
            
            if (objRestaurantes.guardar_rest(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objRestaurantes.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (objRestaurantes.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Restaurante insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar el consecutivo");
                }

            }
        }

        private void mostar_consecutivo()
        {

            try
            {
                DataSet ds1;
                ds1 = objRestaurantes.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = objRestaurantes.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigo.Text = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }

        private void carga_info()
        {
            objRestaurantes.carga_info_rest(_codigo);
            if (objRestaurantes.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = objRestaurantes.nombre;
                txt_direccion.Text = objRestaurantes.direccion;
                txt_especialidad.Text = objRestaurantes.especialidad;
                msk_telefono.Text = objRestaurantes.tel.ToString();
               
                if (objRestaurantes.activo)
                {
                    chk_activo.Checked = true;

                }
                
            }
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Restaurantes_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            if (_accion == "Editar")
            {                
                carga_info();
            }
        }
    }
}

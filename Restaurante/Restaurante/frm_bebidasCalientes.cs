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
    public partial class frm_bebidasCalientes : Form
    {
        Calientes obj_calientes = new Calientes();

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
        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_bebidasCalientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_bebidasCalientes_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            this.mostar_Restaurante();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_ingredientes.Text = "";
            txt_precio.Text = "";
            txt_descripcion.Text = "";
            pb_foto.Image = null ;
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor digite el nomnre del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor escriba una descripcion para el consecutivo", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_ingredientes))
            {
                MessageBox.Show("Por favor digite los ingredientes del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ingredientes.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_precio))
            {
                MessageBox.Show("Por favor digite el precio del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_precio.Focus();
                return;
            }
            
            obj_calientes.codBebidaCal = txt_codigo.Text;
            obj_calientes.nombre = txt_nombre.Text;
            obj_calientes.descripcion = txt_descripcion.Text;
            obj_calientes.precio = Convert.ToDecimal(txt_precio.Text);
            obj_calientes.codRestaurante = txt_restaurantes.Text;
            obj_calientes.ingredientes = txt_ingredientes.Text;

            if (obj_calientes.guardar_Calientes(_accion, txt_restaurantes.Text))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_calientes.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (obj_calientes.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Producto insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar el consecutivo");
                }

            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_buscaFoto_Click(object sender, EventArgs e)
        {

        }

        private void carga_info()
        {
            obj_calientes.carga_info_Calientes(_codigo);
            if (obj_calientes.nombre != "Error")
            {
                 txt_codigo.Text= _codigo;
                 txt_nombre.Text= obj_calientes.nombre;
                 txt_descripcion.Text= obj_calientes.descripcion;
                 txt_precio.Text= obj_calientes.precio.ToString();
                 txt_restaurantes.Text= obj_calientes.codRestaurante;
                 txt_ingredientes.Text= obj_calientes.ingredientes;
                
            }
        }

        private void mostar_consecutivo()
        {
            try
            {
                DataSet ds1;
                ds1 = obj_calientes.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_calientes.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigo.Text = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }

        private void mostar_Restaurante()
        {
            try
            {
                DataSet ds1;
                ds1 = obj_calientes.retorna_nombre_Restaurante(_nick);
                string nombre = ds1.Tables[0].Rows[0]["nombre"].ToString();

                txt_restaurantes.Text = nombre;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el Restaurante" + _nick + "");
            }

        }
    }
}

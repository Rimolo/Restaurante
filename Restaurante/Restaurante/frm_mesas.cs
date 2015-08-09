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
    public partial class frm_mesas : Form
    {
        Mesas obj_mesas = new Mesas();

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

        public frm_mesas()
        {
            InitializeComponent();
        }

        private void frm_mesas_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            this.cargar_Restaurante();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_numero.Text = "";
            txt_sillas.Text = "";
            cb_restaurante.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor digite el nomnre de la mesa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_numero))
            {
                MessageBox.Show("Por favor escriba el numero de la mesa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numero.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_sillas))
            {
                MessageBox.Show("Por favor digite la cantidad de sillas de la mesa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_sillas.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_restaurante))
            {
                MessageBox.Show("Por favor seleccione el restaurante al que pertenece la mesa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_restaurante.Focus();
                return;
            }

            obj_mesas.codMesa = txt_codigo.Text;
            obj_mesas.nombre = txt_nombre.Text;
            obj_mesas.numero = Convert.ToInt32(txt_numero.Text);
            obj_mesas.cantSillas = Convert.ToInt32(txt_sillas.Text);
            obj_mesas.codRestaurante = cb_restaurante.SelectedValue.ToString(); ;           

            if (obj_mesas.guardar_Mesas(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_mesas.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (obj_mesas.actualizar_consecutivo(valor))
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

        private void carga_info()
        {
            obj_mesas.carga_info_Mesa(_codigo);

            if (obj_mesas.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = obj_mesas.nombre;
                txt_numero.Text = obj_mesas.numero.ToString();
                txt_sillas.Text = obj_mesas.cantSillas.ToString();
                cb_restaurante.Text = obj_mesas.codRestaurante;
            }
        }

        private void mostar_consecutivo()
        {

            try
            {
                DataSet ds1;
                ds1 = obj_mesas.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_mesas.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigo.Text = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }

        private void cargar_Restaurante()
        {
            try
            {
                DataSet ds;
                ds = obj_mesas.cargar_lista_Restaurante();
                cb_restaurante.DataSource = ds.Tables[0];
                cb_restaurante.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_restaurante.ValueMember = ds.Tables[0].Columns["codRestaurante"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema cargando el Restaurante", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

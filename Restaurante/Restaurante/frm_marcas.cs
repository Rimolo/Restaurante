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
    public partial class frm_marcas : Form
    {
        Marcas obj_marcas = new Marcas();

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

        public frm_marcas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cb_nacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_detalleEmpresa.Text = "";
            txt_nombreEmpresa.Text = "";
            cb_nacionalidad.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor digite el nomnre de la marca", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor escriba una descripcion de la marca", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }

            if (!cls_validacion.validar(mtb_CedJuridica))
            {
                MessageBox.Show("Por favor digite la cedula juridica de la empresa que registro la marca", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtb_CedJuridica.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_nombreEmpresa))
            {
                MessageBox.Show("Por favor digite el nombre de la Empresa que registro la Marca", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreEmpresa.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_detalleEmpresa))
            {
                MessageBox.Show("Por favor digite los detalle de la Empresa que registro la Marca", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_detalleEmpresa.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_nacionalidad))
            {
                MessageBox.Show("Por favor seleccione la nacionalidad de la Marca", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_nacionalidad.Focus();
                return;
            }
            if (!cls_validacion.validar(mtb_Telefono))
            {
                MessageBox.Show("Por favor digite un telefono de la empresa que registro la Marca", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtb_Telefono.Focus();
                return;
            }

            obj_marcas.codMarca = txt_codigo.Text;
            obj_marcas.nombreMarca = txt_nombre.Text;
            obj_marcas.descripcion = txt_descripcion.Text;
            obj_marcas.detalleEmpresa = txt_detalleEmpresa.Text;
            obj_marcas.nombreEmp = txt_nombreEmpresa.Text;
            obj_marcas.codPais = cb_nacionalidad.SelectedValue.ToString();
            obj_marcas.cedJuridica = mtb_CedJuridica.Text;

            int tel = 0;
            string text = mtb_Telefono.Text.Replace("-", "");
            if (!Int32.TryParse(text, out tel))
            {
                obj_marcas.telefono = 0;
            }
            else
            {
                obj_marcas.telefono = tel;
            }

            if (obj_marcas.guardar_Marcas(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_marcas.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (obj_marcas.actualizar_consecutivo(valor))
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

        private void b_foto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cargar_nacionalidad()
        {
            try
            {
                DataSet ds;
                ds = obj_marcas.cargar_lista_nacionalidad();
                cb_nacionalidad.DataSource = ds.Tables[0];
                cb_nacionalidad.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_nacionalidad.ValueMember = ds.Tables[0].Columns["codigoPais"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema cargando la nacionalidad", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void mostar_consecutivo()
        {
            try
            {
                DataSet ds1;
                ds1 = obj_marcas.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_marcas.retorna_consecutivo_prefijo();
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
            obj_marcas.carga_info_Marca(_codigo);

            if (obj_marcas.nombreMarca != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = obj_marcas.nombreMarca;
                txt_descripcion.Text = obj_marcas.descripcion;
                txt_detalleEmpresa.Text = obj_marcas.detalleEmpresa;
                mtb_CedJuridica.Text = obj_marcas.cedJuridica.ToString();
                mtb_Telefono.Text = obj_marcas.telefono.ToString();
                txt_nombreEmpresa.Text = obj_marcas.nombreEmp;
                cb_nacionalidad.Text = obj_marcas.codPais;
            }
        }

        private void frm_marcas_Load_1(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            this.cargar_nacionalidad();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }
    }
}

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
    public partial class frm_limpiezaHigiene : Form
    {
        Limpieza objLimpieza = new Limpieza();
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
        public frm_limpiezaHigiene()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            cb_marca.SelectedIndex = -1;
            txt_cantidad.Text = "";
            cb_tipo.SelectedItem = -1;
            txt_cantidadMedida.Text = "";
            cb_unidadMedida.SelectedIndex =-1;
            txt_descripcion.Text = "";
            cb_restaurante.SelectedIndex = -1;
            chk_articuloLiquido.Checked = false;
        }

        private void frm_limpiezaHigiene_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            this.cargar_restaurantes();
            this.cargar_medidas();
            this.cargar_marcas();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor digite el nomnre del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_cantidad))
            {
                MessageBox.Show("Por favor digite la cantidad de producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidad.Focus();
                return;
            }
            
            if (!cls_validacion.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor digite la descripcion del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidad.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_cantidadMedida))
            {
                MessageBox.Show("Por favor digite la cantidad de medida", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidadMedida.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_marca))
            {
                MessageBox.Show("Por favor seleccione la marca del producto ", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_marca.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_tipo))
            {
                MessageBox.Show("Por favor seleccione el tipo de producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_tipo.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_restaurante))
            {
                MessageBox.Show("Por favor seleccione el restaurante del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_restaurante.Focus();
                return;
            }
            
            if (!cls_validacion.validar(cb_unidadMedida))
            {
                MessageBox.Show("Por favor seleccione la unidad de medida del producto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_unidadMedida.Focus();
                return;
            }

            objLimpieza.codLimpieza = txt_codigo.Text;
            objLimpieza.nombre = txt_nombre.Text;
            objLimpieza.cantidad = Convert.ToInt32(txt_cantidad.Text);
            objLimpieza.codMedida = cb_unidadMedida.SelectedValue.ToString();
            objLimpieza.codRestaurante = cb_restaurante.SelectedValue.ToString();
            objLimpieza.codMarca = cb_marca.SelectedValue.ToString();
            objLimpieza.descripcion = txt_descripcion.Text;
            objLimpieza.tipoMedida = cb_tipo.SelectedItem.ToString();
            objLimpieza.cantMedida = txt_cantidadMedida.Text;
            if (chk_articuloLiquido.Checked)
            {
                objLimpieza.liquido = true;
            }
            else
            {
                objLimpieza.liquido = false;
            }


            if (objLimpieza.guardar_limpieza(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objLimpieza.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;

                    if (_accion.Equals("Insertar"))
                    {
                        if (objLimpieza.actualizar_consecutivo(valor))
                        {
                            MessageBox.Show("Producto insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostar_consecutivo()
        {
            try
            {
                DataSet ds1;
                ds1 = objLimpieza.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = objLimpieza.retorna_consecutivo_prefijo();
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
            objLimpieza.carga_info_limpieza(_codigo);

            if (objLimpieza.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = objLimpieza.nombre;
                cb_tipo.SelectedIndex = cb_tipo.FindStringExact(objLimpieza.tipoMedida);
                txt_cantidad.Text = objLimpieza.cantidad.ToString();
                txt_descripcion.Text = objLimpieza.descripcion;
                txt_cantidadMedida.Text = objLimpieza.cantMedida;
                cb_restaurante.SelectedIndex = cb_restaurante.FindStringExact(objLimpieza.codRestaurante);
                cb_marca.SelectedIndex = cb_marca.FindStringExact(objLimpieza.codMarca);
                cb_unidadMedida.SelectedIndex = cb_unidadMedida.FindStringExact(objLimpieza.codMedida);
                if (objLimpieza.liquido)
                {
                    chk_articuloLiquido.Checked = true;
                }
                else
                {

                    chk_articuloLiquido.Checked = false;
                }
            }
        }

        private void cargar_medidas()
        {
            try
            {
                DataSet ds;
                ds = objLimpieza.cargar_lista_unidadMedida();
                cb_unidadMedida.DataSource = ds.Tables[0];
                cb_unidadMedida.DisplayMember = ds.Tables[0].Columns["unidadMedida"].ColumnName.ToString();
                cb_unidadMedida.ValueMember = ds.Tables[0].Columns["codMedida"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema cargando las unidades de medida", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cargar_marcas()
        {
            try
            {
                DataSet ds;
                ds = objLimpieza.cargar_lista_Marcas();
                cb_marca.DataSource = ds.Tables[0];
                cb_marca.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_marca.ValueMember = ds.Tables[0].Columns["codMarca"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema cargando las marcas", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cargar_restaurantes()
        {
            try
            {
                DataSet ds;
                ds = objLimpieza.cargar_lista_restaurantes();
                cb_restaurante.DataSource = ds.Tables[0];
                cb_restaurante.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_restaurante.ValueMember = ds.Tables[0].Columns["codRestaurante"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema cargando los restaurantes", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

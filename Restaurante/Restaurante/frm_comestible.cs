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
    public partial class frm_comestible : Form
    {
        Comestibles obj_comestibles = new Comestibles();

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

        public frm_comestible()
        {
            InitializeComponent();
        }

        private void frm_comestible_Load(object sender, EventArgs e)
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

        private void b_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            cb_tipoComestible.Text = "";           
            txt_cantidad.Text = "";
            cb_claseComestible.Text = "";
            cb_lineaComestible.Text = "";
            cb_unidadMedida.Text = "";
            cb_marcaComestible.Text = "";
            cb_restaurante.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor digite el nomnre del comestible", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_cantidad))
            {
                MessageBox.Show("Por favor digite la cantidad de comestibles en almacenamiento", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidad.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_tipoComestible))
            {
                MessageBox.Show("Por favor digite el tipo del comestible ", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_tipoComestible.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_lineaComestible))
            {
                MessageBox.Show("Por favor seleccione la linea del comestible", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_lineaComestible.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_claseComestible))
            {
                MessageBox.Show("Por favor seleccione la clase del comestible", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_claseComestible.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_restaurante))
            {
                MessageBox.Show("Por favor seleccione el restaurante del comestible", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_restaurante.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_marcaComestible))
            {
                MessageBox.Show("Por favor seleccione la marca del comestible", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_marcaComestible.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_unidadMedida))
            {
                MessageBox.Show("Por favor seleccione la unidad de medida del comestible", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_unidadMedida.Focus();
                return;
            }

            obj_comestibles.codComestible = txt_codigo.Text;
            obj_comestibles.nombre = txt_nombre.Text;
            obj_comestibles.cantidad = Convert.ToInt32(txt_cantidad.Text);
            obj_comestibles.codMedida = cb_unidadMedida.SelectedValue.ToString();
            obj_comestibles.codRestaurante = cb_restaurante.SelectedValue.ToString();
            obj_comestibles.codMarca = cb_marcaComestible.SelectedValue.ToString();
            obj_comestibles.clase = cb_claseComestible.SelectedItem.ToString();
            obj_comestibles.linea = cb_lineaComestible.SelectedItem.ToString();
            obj_comestibles.tipo = cb_tipoComestible.SelectedItem.ToString();


            if (obj_comestibles.guardar_Comestibles(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_comestibles.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;

                    if (_accion.Equals("Insertar"))
                    {
                        if (obj_comestibles.actualizar_consecutivo(valor))
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
                ds1 = obj_comestibles.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_comestibles.retorna_consecutivo_prefijo();
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
            obj_comestibles.carga_info_Comestibles(_codigo);

            if (obj_comestibles.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = obj_comestibles.nombre;
                cb_tipoComestible.Text = obj_comestibles.tipo;
                txt_cantidad.Text = obj_comestibles.cantidad.ToString();
                cb_claseComestible.Text = obj_comestibles.clase;
                cb_lineaComestible.Text = obj_comestibles.linea;
                cb_unidadMedida.Text = obj_comestibles.codMedida;
                cb_marcaComestible.Text = obj_comestibles.codMarca;
                cb_restaurante.Text = obj_comestibles.codRestaurante;     
            }
        }

        private void cargar_medidas()
        {
            try
            {
                DataSet ds;
                ds = obj_comestibles.cargar_lista_unidadMedida();
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
                ds = obj_comestibles.cargar_lista_Marcas();
                cb_marcaComestible.DataSource = ds.Tables[0];
                cb_marcaComestible.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_marcaComestible.ValueMember = ds.Tables[0].Columns["codMarca"].ColumnName.ToString();
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
                ds = obj_comestibles.cargar_lista_restaurantes();
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

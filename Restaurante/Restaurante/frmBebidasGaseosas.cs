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
    public partial class frmBebidasGaseosas : Form
    {
        Gaseosas obj_gaseosa = new Gaseosas();

        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }
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
        public frmBebidasGaseosas()
        {
            InitializeComponent();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_precio.Text = "";
            txt_cantidad.Text = "";
            cb_nacionalidad.Text = "";
            cb_marca.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor digite el nomnre de la gaseosa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor escriba una descripcion de la gaseosa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_cantidad))
            {
                MessageBox.Show("Por favor digite la cantidad de gaseosas en almacenamiento", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidad.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_precio))
            {
                MessageBox.Show("Por favor digite el precio de la gaseosa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_precio.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_nacionalidad))
            {
                MessageBox.Show("Por favor seleccione la nacionalidad de la gaseosa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_nacionalidad.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_marca))
            {
                MessageBox.Show("Por favor seleccione la marca de la gaseosa", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_marca.Focus();
                return;
            }
           
            obj_gaseosa.codBebidaGas = txt_codigo.Text;
            obj_gaseosa.nombre = txt_nombre.Text;
            obj_gaseosa.descripcion = txt_descripcion.Text;
            obj_gaseosa.codRestaurante = txt_restaurante.Text;
            obj_gaseosa.precio = Convert.ToDecimal(txt_precio.Text);
            obj_gaseosa.cantidad = Convert.ToInt32(txt_cantidad.Text);
            obj_gaseosa.codPais = cb_nacionalidad.SelectedValue.ToString();
            obj_gaseosa.codMarca = cb_marca.SelectedValue.ToString();

            if (error=obj_gaseosa.guardar_Gaseosas(_accion, txt_restaurante.Text) && _accion != "Editar")
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_gaseosa.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (obj_gaseosa.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Producto insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar el consecutivo");
                }

            }else {
                if (!error)
                {
                    MessageBox.Show("Producto insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
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

        private void frmBebidasGaseosas_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            this.mostar_Restaurante();
            this.cargar_nacionalidad();
            this.cargar_marcas();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void mostar_Restaurante()
        {
            try
            {
                DataSet ds1;
                ds1 = obj_gaseosa.retorna_nombre_Restaurante(_nick);
                string nombre = ds1.Tables[0].Rows[0]["nombre"].ToString();

                txt_restaurante.Text = nombre;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el Restaurante" + _nick + "");
            }

        }

        private void mostar_consecutivo()
        {
            try
            {
                DataSet ds1;
                ds1 = obj_gaseosa.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_gaseosa.retorna_consecutivo_prefijo();
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
            obj_gaseosa.carga_info_Gaseosas(_codigo);

            if (obj_gaseosa.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = obj_gaseosa.nombre;
                cb_marca.Text = obj_gaseosa.codMarca;
                cb_nacionalidad.Text = obj_gaseosa.codPais;
                txt_precio.Text = obj_gaseosa.precio.ToString();
                txt_restaurante.Text = obj_gaseosa.codRestaurante;
                txt_cantidad.Text = obj_gaseosa.cantidad.ToString();
                txt_descripcion.Text = obj_gaseosa.descripcion;               
            }
        }

        private void cargar_nacionalidad()
        {
            try
            {
                DataSet ds;
                ds = obj_gaseosa.cargar_lista_nacionalidad();
                cb_nacionalidad.DataSource = ds.Tables[0];
                cb_nacionalidad.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_nacionalidad.ValueMember = ds.Tables[0].Columns["codigoPais"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema cargando las nacionalidades", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cargar_marcas()
        {
            try
            {
                DataSet ds;
                ds = obj_gaseosa.cargar_lista_Marcas();
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

    }
}

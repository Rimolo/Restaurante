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
    public partial class frm_tecnologia : Form
    {
        Tecnologia obj_tecnologia = new Tecnologia();

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

        public frm_tecnologia()
        {
            InitializeComponent();
        }

        private void frm_tecnologia_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            this.cargar_Restaurante();
            this.cargar_Marcas();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_cantidad.Text = "";
            cb_restaurante.Text = "";
            cb_marca.Text = "";
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor digite el nombre de la tecnologia", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_cantidad))
            {
                MessageBox.Show("Por favor escriba la cantidad de la tecnologia en almacenamiento", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidad.Focus();
                return;
            }

            if (!cls_validacion.validar(cb_marca))
            {
                MessageBox.Show("Por favor seleccione la marca a la que pertenece la tecnologia", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_marca.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_restaurante))
            {
                MessageBox.Show("Por favor seleccione el restaurante al que pertenece la tecnologia", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_restaurante.Focus();
                return;
            }

            obj_tecnologia.codTecnologia = txt_codigo.Text.Replace(" ", "");
            obj_tecnologia.nombre = txt_nombre.Text;
            obj_tecnologia.cantidad = Convert.ToInt32(txt_cantidad.Text);
            obj_tecnologia.codMarca = cb_marca.SelectedValue.ToString().Replace(" ", "");
            obj_tecnologia.codRestaurante = cb_restaurante.SelectedValue.ToString();
            obj_tecnologia.descripcion = txt_descripcion.Text;

            if (obj_tecnologia.guardar_Tecno(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_tecnologia.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;

                    if (_accion.Equals("Insertar"))
                    {
                        if (obj_tecnologia.actualizar_consecutivo(valor))
                        {
                            MessageBox.Show("Tecnologia insertada con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tecnologia insertada con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void carga_info()
        {
            obj_tecnologia.carga_info_Tecno(_codigo);

            if (obj_tecnologia.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = obj_tecnologia.nombre;
                txt_descripcion.Text = obj_tecnologia.descripcion;
                txt_cantidad.Text = obj_tecnologia.cantidad.ToString();
                cb_marca.Text = obj_tecnologia.codMarca;
                cb_restaurante.Text = obj_tecnologia.codRestaurante;
            }
        }

        private void mostar_consecutivo()
        {
            try
            {
                DataSet ds1;
                ds1 = obj_tecnologia.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_tecnologia.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigo.Text = pre + valor;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }

        private void cargar_Marcas()
        {
            try
            {
                DataSet ds;
                ds = obj_tecnologia.cargar_lista_Marcas();
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

        private void cargar_Restaurante()
        {
            try
            {
                DataSet ds;
                ds = obj_tecnologia.cargar_lista_Restaurante();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;

namespace Restaurante
{
    public partial class frm_vinos : Form
    {
        bool hayImagen = false;
        Vinos obj_vinos = new Vinos();

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

        public frm_vinos()
        {
            InitializeComponent();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_año.Text = "";
            txt_descripcion.Text = "";
            txt_precioUni.Text = "";
            txt_precioBot.Text = "";
            txt_cantidad.Text = "";
            cb_nacionalidad.Text = "";
            cb_marca.Text = "";
            pb_foto.Image = null;
            hayImagen = false;
        }

        private void frm_vinos_Load(object sender, EventArgs e)
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

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor digite el nomnre del vino", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor escriba una descripcion del vino", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_cantidad))
            {
                MessageBox.Show("Por favor digite la cantidad de vinos en almacenamiento", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cantidad.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_precioUni))
            {
                MessageBox.Show("Por favor digite el precio por copa de vino", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_precioUni.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_precioBot))
            {
                MessageBox.Show("Por favor digite el precio de la botella de vino", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_precioBot.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_año))
            {
                MessageBox.Show("Por favor digite el año del vino", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_año.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_nacionalidad))
            {
                MessageBox.Show("Por favor seleccione la nacionalidad del vino", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_nacionalidad.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_marca))
            {
                MessageBox.Show("Por favor seleccione la marca del vino", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_marca.Focus();
                return;
            }

            obj_vinos.codVino = txt_codigo.Text;
            obj_vinos.nombre = txt_nombre.Text;
            obj_vinos.descripcion = txt_descripcion.Text;
            obj_vinos.codRestaurante = txt_restaurante.Text;
            obj_vinos.precioU = Convert.ToDecimal(txt_precioUni.Text);
            obj_vinos.precioB = Convert.ToDecimal(txt_precioBot.Text);
            obj_vinos.cantidad = Convert.ToInt32(txt_cantidad.Text);
            obj_vinos.cosecha = Convert.ToInt32(txt_año.Text);
            obj_vinos.codPais = cb_nacionalidad.SelectedValue.ToString();
            obj_vinos.codMarca = cb_marca.SelectedValue.ToString();
            if (hayImagen)
            {
                MemoryStream ms = new MemoryStream();
                pb_foto.Image.Save(ms, pb_foto.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                obj_vinos.imagen = a;
            }

            if (error = obj_vinos.guardar_Vinos(_accion, txt_restaurante.Text) && _accion != "Editar")
            {
                if (hayImagen)
                {
                    obj_vinos.guardar_imagen();
                }
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_vinos.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;

                    if (obj_vinos.actualizar_consecutivo(valor))
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
            else
            {
                if (!error) { 
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
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pb_foto.Image = Image.FromFile(f.FileName);
                    pb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                    hayImagen = true;
                }
            }
            catch (Exception) { }
        }

        private void mostar_Restaurante()
        {
            try
            {
                DataSet ds1;
                ds1 = obj_vinos.retorna_nombre_Restaurante(_nick);
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
                ds1 = obj_vinos.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_vinos.retorna_consecutivo_prefijo();
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
            obj_vinos.carga_info_Vinos(_codigo);

            if (obj_vinos.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = obj_vinos.nombre;
                cb_marca.Text = obj_vinos.codMarca;
                cb_nacionalidad.Text = obj_vinos.codPais;
                txt_precioUni.Text = obj_vinos.precioU.ToString();
                txt_precioBot.Text = obj_vinos.precioB.ToString();
                txt_restaurante.Text = obj_vinos.codRestaurante;
                txt_cantidad.Text = obj_vinos.cantidad.ToString();
                txt_año.Text = obj_vinos.cosecha.ToString();
                txt_descripcion.Text = obj_vinos.descripcion;
                if (!string.IsNullOrEmpty((obj_vinos.imagen.ToString())))
                {
                    MemoryStream ms = new MemoryStream(obj_vinos.imagen);
                    pb_foto.Image = Image.FromStream(ms);
                    pb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                    ms.Close();
                }
            }
        }

        private void cargar_nacionalidad()
        {
            try
            {
                DataSet ds;
                ds = obj_vinos.cargar_lista_nacionalidad();
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
                ds = obj_vinos.cargar_lista_Marcas();
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

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
    public partial class frm_comidaBuffet : Form
    {
        bool hayImagen = false;
        Buffet obj_buffet = new Buffet();

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

        public frm_comidaBuffet()
        {
            InitializeComponent();
        }

        private void frm_comidaBuffet_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            this.cargar_unidadMedida();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombreBuffet.Text = "";
            cbo_tipoBuffet.Text = "";
            txt_precioBuffet.Text = "";          
            cbo_unidadMedida.Text = "";
            pic_foto.Image = null;
            hayImagen = false;
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (!cls_validacion.validar(txt_nombreBuffet))
            {
                MessageBox.Show("Por favor digite el nomnbre de la comida buffet", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreBuffet.Focus();
                return;
            }
            
            if (!cls_validacion.validar(txt_precioBuffet))
            {
                MessageBox.Show("Por favor digite el precio de la comida buffet", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_precioBuffet.Focus();
                return;
            }
            if (!cls_validacion.validar(cbo_unidadMedida))
            {
                MessageBox.Show("Por favor seleccione la unidad de medida de la comida buffet", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_unidadMedida.Focus();
                return;
            }
            if (!cls_validacion.validar(cbo_tipoBuffet))
            {
                MessageBox.Show("Por favor seleccione el tipo de la comida buffet", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_tipoBuffet.Focus();
                return;
            }

            obj_buffet.codBuffet = txt_codigoBuffet.Text;
            obj_buffet.nombre = txt_nombreBuffet.Text;
            obj_buffet.precio = Convert.ToDecimal(txt_precioBuffet.Text);
            obj_buffet.codMedida = cbo_unidadMedida.SelectedValue.ToString();
            obj_buffet.tipo = cbo_tipoBuffet.SelectedItem.ToString();
            if (hayImagen)
            {
                MemoryStream ms = new MemoryStream();
                pic_foto.Image.Save(ms, pic_foto.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                obj_buffet.imagen = a;
            }

            if (error = obj_buffet.guardar_Buffet(_accion, _nick) && _accion != "Editar")
            {
                if (hayImagen)
                {
                    obj_buffet.guardar_imagen();
                }
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_buffet.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (obj_buffet.actualizar_consecutivo(valor))
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
                if (!error)
                {
                    MessageBox.Show("Plato insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_buscaFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pic_foto.Image = Image.FromFile(f.FileName);
                    pic_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                    hayImagen = true;
                }
            }
            catch (Exception) { }
        }

        private void mostar_consecutivo()
        {
            try
            {
                DataSet ds1;
                ds1 = obj_buffet.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_buffet.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigoBuffet.Text = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }

        private void carga_info()
        {
            obj_buffet.carga_info_Buffet(_codigo);

            if (obj_buffet.nombre != "Error")
            {
                txt_codigoBuffet.Text = _codigo;
                txt_nombreBuffet.Text = obj_buffet.nombre;
                cbo_unidadMedida.Text = obj_buffet.codMedida;
                cbo_tipoBuffet.Text = obj_buffet.tipo;
                txt_precioBuffet.Text = obj_buffet.precio.ToString();               
                if (!string.IsNullOrEmpty((obj_buffet.imagen.ToString())))
                {
                    MemoryStream ms = new MemoryStream(obj_buffet.imagen);
                    pic_foto.Image = Image.FromStream(ms);
                    pic_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                    ms.Close();
                }
            }
        }

        private void cargar_unidadMedida()
        {
            try
            {
                DataSet ds;
                ds = obj_buffet.cargar_lista_unidadMedida();
                cbo_unidadMedida.DataSource = ds.Tables[0];
                cbo_unidadMedida.DisplayMember = ds.Tables[0].Columns["unidadMedida"].ColumnName.ToString();
                cbo_unidadMedida.ValueMember = ds.Tables[0].Columns["codMedida"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema cargando las nacionalidades", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}

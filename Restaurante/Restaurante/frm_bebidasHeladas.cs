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
    public partial class frm_bebidasHeladas : Form
    {
        bool hayImagen = false;
        bool cambioImagen = false;
        Heladas obj_heladas = new Heladas();

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

        public frm_bebidasHeladas()
        {
            InitializeComponent();
        }

        private void frm_bebidasHeladas_Load(object sender, EventArgs e)
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
            txt_descripcion.Text = "";
            txt_precio.Text = "";
            txt_ingredientes.Text = "";
            pb_foto.Image = null;
            hayImagen = false;
            cambioImagen = false;
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (pb_foto.Image.RawFormat != null) { hayImagen = true; }
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

            obj_heladas.codBebidaHel = txt_codigo.Text;
            obj_heladas.nombre = txt_nombre.Text;
            obj_heladas.descripcion = txt_descripcion.Text;
            obj_heladas.precio = Convert.ToDecimal(txt_precio.Text);
            obj_heladas.codRestaurante = txt_restaurantes.Text;
            obj_heladas.ingredientes = txt_ingredientes.Text;
            if (cambioImagen)
            {
                MemoryStream ms = new MemoryStream();
                pb_foto.Image.Save(ms, pb_foto.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                obj_heladas.imagen = a;
            }

            if (obj_heladas.guardar_Heladas(_accion, txt_restaurantes.Text))
            {
                if (hayImagen)
                {
                    obj_heladas.guardar_imagen();
                }
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_heladas.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;

                    if (_accion.Equals("Insertar"))
                    {
                        if (obj_heladas.actualizar_consecutivo(valor))
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
                    cambioImagen = true;
                }
            }
            catch (Exception) { }
        }

        private void carga_info()
        {
            obj_heladas.carga_info_Heladas(_codigo);
            
            if (obj_heladas.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = obj_heladas.nombre;
                txt_descripcion.Text = obj_heladas.descripcion;
                txt_precio.Text = obj_heladas.precio.ToString();
                txt_restaurantes.Text = obj_heladas.codRestaurante;
                txt_ingredientes.Text = obj_heladas.ingredientes;
                if (!string.IsNullOrEmpty((obj_heladas.imagen.ToString())))
                {
                    MemoryStream ms = new MemoryStream(obj_heladas.imagen);
                    pb_foto.Image = Image.FromStream(ms);
                    pb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                    ms.Close();
                }
            }
        }

        private void mostar_consecutivo()
        {
            try
            {
                DataSet ds1;
                ds1 = obj_heladas.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_heladas.retorna_consecutivo_prefijo();
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
                ds1 = obj_heladas.retorna_nombre_Restaurante(_nick);
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

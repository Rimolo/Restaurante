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
    public partial class frm_especiales : Form
    {
        bool hayImagen = false;
        bool cambioImagen = false;
        Especiales obj_especiales = new Especiales();

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

        public frm_especiales()
        {
            InitializeComponent();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_ingredientes.Text = "";
            txt_precio.Text = "";
            txt_detalle.Text = "";
            pb_foto.Image = null;
            hayImagen = false;
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (pb_foto.Image.RawFormat != null) { hayImagen = true; }
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor digite el nomnre del especial", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_detalle))
            {
                MessageBox.Show("Por favor escriba los detalle del especial", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_detalle.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_ingredientes))
            {
                MessageBox.Show("Por favor digite los ingredientes del especial", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ingredientes.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_precio))
            {
                MessageBox.Show("Por favor digite el precio del especial", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_precio.Focus();
                return;
            }

            obj_especiales.codEspeciales = txt_codigo.Text;
            obj_especiales.nombre = txt_nombre.Text;
            obj_especiales.detalle = txt_detalle.Text;
            obj_especiales.precio = Convert.ToDecimal(txt_precio.Text);
            obj_especiales.ingredientes = txt_ingredientes.Text;
            if (cambioImagen)
            {
                MemoryStream ms = new MemoryStream();
                pb_foto.Image.Save(ms, pb_foto.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                obj_especiales.imagen = a;
            }

            if (obj_especiales.guardar_Especiales(_accion, _nick) )
            {
                if (hayImagen)
                {
                    obj_especiales.guardar_imagen();
                }

                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_especiales.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;

                    if (_accion.Equals("Insertar"))
                    {
                        if (obj_especiales.actualizar_consecutivo(valor))
                        {
                            MessageBox.Show("Especial insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Especial insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }
            }
            catch (Exception) { }
        }
    

        private void frm_especiales_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void carga_info()
        {
            obj_especiales.carga_info_Especiales(_codigo);
            if (obj_especiales.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = obj_especiales.nombre;
                txt_detalle.Text = obj_especiales.detalle;
                txt_precio.Text = obj_especiales.precio.ToString();
                txt_ingredientes.Text = obj_especiales.ingredientes;
                if (!string.IsNullOrEmpty((obj_especiales.imagen.ToString())))
                {
                    MemoryStream ms = new MemoryStream(obj_especiales.imagen);
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
                ds1 = obj_especiales.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_especiales.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigo.Text = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }
    }
}

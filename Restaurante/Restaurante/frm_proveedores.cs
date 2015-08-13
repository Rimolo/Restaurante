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
using System.IO;

namespace Restaurante
{
    public partial class frm_proveedores : Form
    {
        bool hayfoto = false;
        List<string> _items2 = new List<string>();
        Proveedores obj_Proveedores = new Proveedores();
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

        public frm_proveedores()
        {
            InitializeComponent();
        }

        private void lst_productosRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_proveedores_Load(object sender, EventArgs e)
        {
            DataSet ds2;
            ds2 = obj_Proveedores.cargar_lista_ProductosR();
            _items2.Add(Convert.ToString(ds2.Tables[0].Rows[0]["productosR"]));
            lst_productosRestaurante.DataSource = null;
            lst_productosRestaurante.DataSource = _items2;

            this.mostar_consecutivo();
            if (_accion == "Editar")
            {
                carga_info();
            }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_apellido1.Text = "";
            txt_apellido2.Text = "";
            mtb_cedula.Text = "";
            txt_correo.Text = "";
            txt_nombreContacto.Text = "";
            txt_direccion.Text = "";
            txt_direccionContacto.Text = "";
            mtb_telefono.Text = "";
            mtb_celular.Text = "";
            mtb_fax.Text = "";
            mtb_oficina.Text = "";
            dtp_fecha.Value = DateTime.Today;
            pic_foto.Image = null;
            hayfoto = false;
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor escriba un nombre del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(mtb_cedula))
            {
                MessageBox.Show("Por favor digite la cedula del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtb_cedula.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_nombreContacto))
            {
                MessageBox.Show("Por favor escriba el nombre de contacto del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreContacto.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_direccion))
            {
                MessageBox.Show("Por favor escriba la direccion del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_direccion.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_correo))
            {
                MessageBox.Show("Por favor escriba el correo del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_correo.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor escriba el nonbre del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_direccionContacto))
            {
                MessageBox.Show("Por favor escriba la direccion de contacto  del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_direccionContacto.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_apellido1))
            {
                MessageBox.Show("Por favor escriba el primer apellido del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellido1.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_apellido2))
            {
                MessageBox.Show("Por favor escriba el segundo apellido del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apellido2.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_direccion))
            {
                MessageBox.Show("Por favor dijite la direccion del proveedor", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_direccion.Focus();
                return;
            }

            obj_Proveedores.codigo = txt_codigo.Text.Replace(" ", "");
            obj_Proveedores.nombreP = txt_nombre.Text;
            obj_Proveedores.cedula = mtb_cedula.Text;
            obj_Proveedores.nombreC = txt_nombreContacto.Text;
            obj_Proveedores.direccionP = txt_direccion.Text;
            obj_Proveedores.correo = txt_correo.Text;
            obj_Proveedores.direccionC = txt_direccionContacto.Text;
            obj_Proveedores.apellido1 = txt_apellido1.Text;
            obj_Proveedores.apellido2 = txt_apellido2.Text;
            obj_Proveedores.fecha = dtp_fecha.Value.ToString("yyyy-MM-dd");

            string text = mtb_telefono.Text.Replace("-", "");
            if (text=="")
            {
                obj_Proveedores.telefono = "0";
            }
            else
            {
                obj_Proveedores.telefono = text;
            }
            text = mtb_celular.Text.Replace("-", "");
            if (text == "")
            {
                obj_Proveedores.celular = "0";
            }
            else
            {
                obj_Proveedores.celular = text;
            }
            text = mtb_fax.Text.Replace("-", "");
            if (text == "")
            {
                obj_Proveedores.fax = "0";
            }
            else
            {
                obj_Proveedores.fax = text;
            }
            text = mtb_oficina.Text.Replace("-", "");
            if (text == "")
            {
                obj_Proveedores.oficina = "0";
            }
            else
            {
                obj_Proveedores.oficina = text;
            }

            if (hayfoto)
            {
                MemoryStream ms = new MemoryStream();
                pic_foto.Image.Save(ms, pic_foto.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                obj_Proveedores.foto = a;
            }

            if (obj_Proveedores.guardar_Proveedor(_accion))
            {
                if (hayfoto)
                {
                    obj_Proveedores.guardar_imagen();
                }

                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_Proveedores.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;

                    if (_accion.Equals("Insertar"))
                    {
                        if (obj_Proveedores.actualizar_consecutivo(valor))
                        {
                            MessageBox.Show("Proveedor insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Proveedor insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar el consecutivo");
                }

            }
        }

        private void b_cerrar_Click(object sender, EventArgs e)
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
                    hayfoto = true;
                }
            }
            catch (Exception) { }
        }

        private void b_asigna_Click(object sender, EventArgs e)
        {
            List<string> _items = new List<string>();

            obj_Proveedores.agregar_productos(lst_productosRestaurante.SelectedItem.ToString(), _nick);

            DataSet ds;
            ds = obj_Proveedores.cargar_lista_ProductosP();
            _items.Add( Convert.ToString(ds.Tables[0].Rows[0]["productosP"]));   
                       
            lst_productosProveedor.DataSource = null;
            lst_productosProveedor.DataSource = _items;

            _items2.RemoveAt(lst_productosRestaurante.SelectedIndex);
            lst_productosRestaurante.DataSource = null;
            lst_productosRestaurante.DataSource= _items2;
        }

        private void b_remueve_Click(object sender, EventArgs e)
        {
            List<string> _items = new List<string>();           

            obj_Proveedores.remover_productos(lst_productosProveedor.SelectedItem.ToString(), _nick);
            
            DataSet ds;
            ds = obj_Proveedores.cargar_lista_ProductosP();
            _items.Add(Convert.ToString(ds.Tables[0].Rows[0]["productosP"]));            
            
            lst_productosProveedor.DataSource = null;
            lst_productosProveedor.DataSource = _items;

            _items2.Add(lst_productosProveedor.SelectedIndex.ToString());
            lst_productosRestaurante.DataSource = null;
            lst_productosRestaurante.DataSource = _items2;
        }

        private void mostar_consecutivo()
        {

            try
            {
                DataSet ds1;
                ds1 = obj_Proveedores.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_Proveedores.retorna_consecutivo_prefijo();
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
            obj_Proveedores.carga_info_empleado(_codigo);
            if (obj_Proveedores.nombreP != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_correo.Text = obj_Proveedores.correo;
                txt_direccion.Text = obj_Proveedores.direccionP;
                txt_direccionContacto.Text = obj_Proveedores.direccionC;
                txt_nombre.Text = obj_Proveedores.nombreP;
                txt_apellido1.Text = obj_Proveedores.apellido1;
                txt_apellido2.Text = obj_Proveedores.apellido2;
                mtb_cedula.Text = obj_Proveedores.cedula;
                mtb_celular.Text = obj_Proveedores.celular;
                mtb_telefono.Text = obj_Proveedores.telefono;
                mtb_oficina.Text = obj_Proveedores.oficina;
                mtb_fax.Text = obj_Proveedores.fax;
                dtp_fecha.Value = Convert.ToDateTime(obj_Proveedores.fecha);
                if (obj_Proveedores.foto!=null)
                {
                    MemoryStream ms = new MemoryStream(obj_Proveedores.foto);
                    pic_foto.Image = Image.FromStream(ms);
                    pic_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                    ms.Close();
                }
                
            }
        }
    }
}

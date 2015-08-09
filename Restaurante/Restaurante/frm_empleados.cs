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
    public partial class frm_empleados : Form
    {
        bool hayfoto = false;
        Empleados objEmpleados = new Empleados();
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
        public frm_empleados()
        {
            InitializeComponent();
        }

        private void frm_empleados_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            cargar_paises();
            cargar_paises();
            cargar_rest();
            if (_accion == "Editar")
            {
                carga_info();
            }
        }
        private void cargar_puestos()
        {
            try
            {
                DataSet ds;
                ds = objEmpleados.cargar_lista_puestos();
                cb_puesto.DataSource = ds.Tables[0];
                cb_puesto.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_puesto.ValueMember = ds.Tables[0].Columns["codPuesto"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void cargar_rest()
        {
            try
            {
                DataSet ds;
                ds = objEmpleados.cargar_lista_restaurantes();
                cb_restaurante.DataSource = ds.Tables[0];
                cb_restaurante.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_restaurante.ValueMember = ds.Tables[0].Columns["codRestaurante"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void cargar_paises()
        {
            try
            {
                DataSet ds;
                ds = objEmpleados.cargar_lista_paises();
                cb_nac.DataSource = ds.Tables[0];
                cb_nac.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_nac.ValueMember = ds.Tables[0].Columns["codigoPais"].ColumnName.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_apellido1.Text = "";
            txt_apellido2.Text = "";
            msk_ced.Text = "";
            msk_tel1.Text = "";
            msk_tel2.Text = "";
            cb_nac.SelectedIndex = -1;
            cb_puesto.SelectedIndex = -1;
            cb_restaurante.SelectedIndex = -1;
            pic_foto.Image = null;
            hayfoto = false;
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor escriba un nombre al Empleado", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(msk_ced))
            {
                MessageBox.Show("Por favor escriba una cedula al Empleado", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_ced.Focus();
                return;
            }

            if (!cls_validacion.validar(cb_nac))
            {
                MessageBox.Show("Por favor selecicone una nacionalidad", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_nac.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_puesto))
            {
                MessageBox.Show("Por favor selecicone un puesto", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_puesto.Focus();
                return;
            }
            if (!cls_validacion.validar(cb_restaurante))
            {
                MessageBox.Show("Por favor selecicone un restaurante", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_restaurante.Focus();
                return;
            }


            objEmpleados.codigo = txt_codigo.Text.Replace(" ", "");
            objEmpleados.nombre = txt_nombre.Text;
            objEmpleados.cedula = msk_ced.Text;
            objEmpleados.codNacionalidad=cb_nac.SelectedValue.ToString();

            objEmpleados.codPuesto=cb_puesto.SelectedValue.ToString());
            objEmpleados.codRest= cb_restaurante.SelectedValue.ToString());
            int tel = 0;
            string text = msk_tel1.Text.Replace("-", "");
            if (!Int32.TryParse(text, out tel))
            {
                objEmpleados.telefono1 = 0;
            }
            else
            {
                objEmpleados.telefono1 = tel;
            }
            text = msk_tel2.Text.Replace("-", "");
            if (!Int32.TryParse(text, out tel))
            {
                objEmpleados.telefono2 = 0;
            }
            else
            {
                objEmpleados.telefono2 = tel;
            }
            if (hayfoto)
            {
                MemoryStream ms = new MemoryStream();
                pic_foto.Image.Save(ms, pic_foto.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                objEmpleados.foto = a;
            }

            if (objEmpleados.guardar_empleado(_accion))
            {
                if (hayfoto)
                {
                    objEmpleados.guardar_imagen();
                }

                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objEmpleados.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (objEmpleados.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Empleado insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    pic_foto.Image = Image.FromFile(f.FileName);
                    pic_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                    hayfoto = true;
                }
            }
            catch (Exception) { }
        }

        private void cb_restaurante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_nac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void mostar_consecutivo()
        {

            try
            {
                DataSet ds1;
                ds1 = objEmpleados.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = objEmpleados.retorna_consecutivo_prefijo();
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
            objEmpleados.carga_info_empleado(_codigo);
            if (objEmpleados.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = objEmpleados.nombre;
                txt_apellido1.Text = objEmpleados.apellido1;
                txt_apellido2.Text = objEmpleados.apellido2;
                msk_ced.Text = objEmpleados.cedula;
                msk_tel1.Text = objEmpleados.telefono1.ToString();
                msk_tel2.Text = objEmpleados.telefono1.ToString();
                MemoryStream ms = new MemoryStream(objEmpleados.foto);
                pic_foto.Image = Image.FromStream(ms);
                pic_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                ms.Close();

            }
        }
    }
}

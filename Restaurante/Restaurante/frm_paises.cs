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
    public partial class frm_paises : Form
    {
        bool hayBandera = false;
        Paises objPais = new Paises();
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
        public frm_paises()
        {
            InitializeComponent();
        }

        private void frm_paises_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            if (_accion == "Editar")
            {
                carga_info();
            }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombrePais.Text = "";
            pic_bandera.InitialImage = null;
        }
        
        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombrePais))
            {
                MessageBox.Show("Por favor escriba un nombre al Pais", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombrePais.Focus();
                return;
            }

            objPais.codigo = txt_codigoPais.Text.Replace(" ", "");
            objPais.nombre = txt_nombrePais.Text;
            if (hayBandera) {
                MemoryStream ms = new MemoryStream();
                pic_bandera.Image.Save(ms, pic_bandera.Image.RawFormat);
                objPais.bandera = ms.GetBuffer();
            }
            
            if (objPais.guardar_pais(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objPais.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (objPais.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Pais insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar el consecutivo");
                }

            }
        }

        private void mostar_consecutivo()
        {

            try
            {
                DataSet ds1;
                ds1 = objPais.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = objPais.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigoPais.Text = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }

        private void carga_info()
        {
            objPais.carga_info_pais(_codigo);
            if (objPais.nombre != "Error")
            {
                txt_codigoPais.Text = _codigo;
                txt_nombrePais.Text = objPais.nombre;
                MemoryStream ms = new MemoryStream(objPais.bandera);
                pic_bandera.Image = new Bitmap(ms);
                pic_bandera.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_buscaFoto_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                pic_bandera.Image = new Bitmap(fileToOpen);
                pic_bandera.SizeMode = PictureBoxSizeMode.StretchImage;
                hayBandera = true;
            }
        }
    }
}

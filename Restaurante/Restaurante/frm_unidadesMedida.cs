using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Windows.Forms;
namespace Restaurante
{
    public partial class frm_unidadesMedida : Form
    {
        Unidades objUnidades = new Unidades();

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

        public frm_unidadesMedida()
        {
            InitializeComponent();
        }

        private void frm_unidadesMedida_Load(object sender, EventArgs e)
        {
            mostar_consecutivo();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_simbolo.Text = "";
            txt_simbologia.Text = "";
            txt_unidad.Text = "";
            cb_detalle.SelectedIndex = -1;
            cb_escala.SelectedIndex = -1;
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_unidad))
            {
                MessageBox.Show("Por favor escriba una unidad a la medida", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_unidad.Focus();
                return;
            }

            if (!cls_validacion.validar(cb_escala))
            {
                MessageBox.Show("Por favor seleccione un tipo de escala", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_escala.Focus();
                return;
            }

            if (!cls_validacion.validar(cb_detalle))
            {
                MessageBox.Show("Por favor seleccione un tipo de detalle", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_detalle.Focus();
                return;
            }



            objUnidades.codigo = txt_codigo.Text.Replace(" ","");
            objUnidades.unidad = txt_unidad.Text;
            objUnidades.detalle = cb_detalle.SelectedItem.ToString();
            objUnidades.escala = cb_escala.SelectedItem.ToString();
            objUnidades.simbolo = txt_simbolo.Text;
            objUnidades.simbologia = txt_simbologia.Text;
            if (objUnidades.guardar_unidades(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objUnidades.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (objUnidades.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Unidad de Medida insertada con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar la unidad de medida");
                }

            }
        }
        private void mostar_consecutivo()
        {

            try
            {
                DataSet ds1;
                ds1 = objUnidades.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = objUnidades.retorna_consecutivo_prefijo();
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
            objUnidades.carga_info_unidades(_codigo);
            if (objUnidades.unidad != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_unidad.Text = objUnidades.unidad;
                txt_simbolo.Text = objUnidades.simbolo;
                txt_simbologia.Text = objUnidades.simbologia;
                cb_detalle.Text = objUnidades.detalle;
                cb_escala.Text = objUnidades.escala;
            }
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_escala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_escala.SelectedIndex != -1) { 
            string valor = cb_escala.SelectedItem.ToString();
                switch (valor)
                {

                    case "yotta":
                        txt_simbolo.Text = "Y";
                        break;
                    case "zetta":
                        txt_simbolo.Text = "Z";
                        break;
                    case "exa":
                        txt_simbolo.Text = "E";
                        break;
                    case "peta":
                        txt_simbolo.Text = "P";
                        break;
                    case "tera":
                        txt_simbolo.Text = "T";
                        break;
                    case "giga":
                        txt_simbolo.Text = "G";
                        break;
                    case "mega":
                        txt_simbolo.Text = "M";
                        break;
                    case "kilo":
                        txt_simbolo.Text = "k";
                        break;
                    case "hecto":
                        txt_simbolo.Text = "h";
                        break;
                    case "deca":
                        txt_simbolo.Text = "da";
                        break;
                    case "deci":
                        txt_simbolo.Text = "d";
                        break;
                    case "centi":
                        txt_simbolo.Text = "c";
                        break;
                    case "mili":
                        txt_simbolo.Text = "m";
                        break;
                    case "micro":
                        txt_simbolo.Text = "µ";
                        break;
                    case "nano":
                        txt_simbolo.Text = "n";
                        break;
                    case "pico":
                        txt_simbolo.Text = "p";
                        break;
                    case "femto":
                        txt_simbolo.Text = "f";
                        break;
                    case "atto":
                        txt_simbolo.Text = "a";
                        break;
                    case "zepto":
                        txt_simbolo.Text = "z";
                        break;
                    case "yocto":
                        txt_simbolo.Text = "y";
                        break;
                    case "UNIDAD":
                        txt_simbolo.Text = txt_unidad.Text;
                        break;
                    default:
                        
                        break;
                }
            }
            if (!string.IsNullOrEmpty(txt_simbolo.Text))
            {
                cb_detalle.Enabled = true;
            }
            else {
                cb_detalle.Enabled = false;
            }
        }

        private void cb_detalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_detalle.SelectedIndex != -1)
            {
                txt_simbologia.Text = txt_simbolo.Text + txt_unidad.Text[0];
            }          
        }
    }
}

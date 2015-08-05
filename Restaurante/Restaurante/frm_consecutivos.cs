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
    public partial class frm_consecutivos : Form
    {
        Consecutivos obj_consecutivos = new Consecutivos();

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

        public frm_consecutivos()
        {
            InitializeComponent();
        }

        private void frm_consecutivos_Load(object sender, EventArgs e)
        {
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cb_tipoConsecutivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = cb_tipoConsecutivo.SelectedItem.ToString();
            switch (valor)
            {
                
                case "Clientes":
                    txt_prefijo.Text= "CLI-";                    
                    break;
                case "Personal":

                    txt_prefijo.Text = "PE-";
                    break;                
                case "Proveedor":

                    txt_prefijo.Text = "PRO-";
                    break;                
                case "Puestos":

                    txt_prefijo.Text = "PU-";
                    break;                
                case "Eventos o Roles":

                    txt_prefijo.Text = "EVE-";
                    break;                
                case "Usuarios":

                    txt_prefijo.Text = "USU-";
                    break;                
                case "Unidades de Medida":

                    txt_prefijo.Text = "UM-";
                    break;                
                case "Paises":

                    txt_prefijo.Text = "P-";
                    break;
                case "Marcas":

                    txt_prefijo.Text = "M-";
                    break;
                case "Comestibles":

                    txt_prefijo.Text = "COM-";
                    break;
                case "Desechables y Empaques":

                    txt_prefijo.Text = "DE-";
                    break;
                case "Equipos y Utensilios":

                    txt_prefijo.Text = "EU-";
                    break;
                case "Limpieza e Higiene":

                    txt_prefijo.Text = "LH-";
                    break;
                case "Tecnologia":

                    txt_prefijo.Text = "TEC-";
                    break;
                case "Restaurante":

                    txt_prefijo.Text = "RES-";
                    break;
                case "Buffet":

                    txt_prefijo.Text = "BUF-";
                    break;
                case "Especiales":

                    txt_prefijo.Text = "ESP-";
                    break;
                case "Bebidas Calientes":

                    txt_prefijo.Text = "BC-";
                    break;
                case "Bebidas Heladas":

                    txt_prefijo.Text = "BH-";
                    break;
                case "Bebidas Gaseosas":

                    txt_prefijo.Text = "BG-";
                    break;
                case "Licores":

                    txt_prefijo.Text = "L-";
                    break;
                case "Vinos":

                    txt_prefijo.Text = "V-";
                    break;
                case "Empleados":

                    txt_prefijo.Text = "EMP-";
                    break;
                case "Mesas":

                    txt_prefijo.Text = "ME-";
                    break;
                case "Bitacora":

                    txt_prefijo.Text = "BIT-";
                    break;
                case "Facturas":

                    txt_prefijo.Text = "FAC-";
                    break;
                default:

                    txt_prefijo.Text = "";
                    break;

            }
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(cb_tipoConsecutivo))
            {
                MessageBox.Show("Por favor seleccione un tipo de consecutivo", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_tipoConsecutivo.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_descripcion))
            {
                MessageBox.Show("Por favor escriba una descripcion para el consecutivo", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_descripcion.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_valorConsecutivo))
            {
                MessageBox.Show("Por favor digite el valor inicial del consecutivo", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_valorConsecutivo.Focus();
                return;
            }

            obj_consecutivos.codConsecutivo = Convert.ToString(txt_prefijo.Text + txt_valorConsecutivo.Text);
            obj_consecutivos.tipo = Convert.ToString(cb_tipoConsecutivo.SelectedItem.ToString());
            obj_consecutivos.descripcion = Convert.ToString(txt_descripcion.Text);
            obj_consecutivos.valor = Convert.ToString(txt_valorConsecutivo.Text);
            obj_consecutivos.prefijo = Convert.ToString(txt_prefijo.Text);

            if (obj_consecutivos.guardar_consecutivos())
            {
                MessageBox.Show("Consecutivo insertado con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            cb_tipoConsecutivo.Text = "";
            txt_descripcion.Text = "";
            txt_valorConsecutivo.Text = "";
            txt_prefijo.Text = "";
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carga_info()
        {
            obj_consecutivos.carga_info_Consecutivos(_codigo);
            if (obj_consecutivos.tipo != "Error")
            {
                cb_tipoConsecutivo.Text = obj_consecutivos.tipo; 
                txt_descripcion.Text = obj_consecutivos.descripcion.ToString(); 
                txt_valorConsecutivo.Text = obj_consecutivos.valor; 
                txt_prefijo.Text = obj_consecutivos.prefijo.ToString(); 
            }
        }

    }
}

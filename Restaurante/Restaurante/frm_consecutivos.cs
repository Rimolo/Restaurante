using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class frm_consecutivos : Form
    {
        public frm_consecutivos()
        {
            InitializeComponent();
        }

        private void frm_consecutivos_Load(object sender, EventArgs e)
        {

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
    }
}

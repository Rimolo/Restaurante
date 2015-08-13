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
namespace Restaurante
{
    public partial class frm_cierreCaja2 : Form
    {

        Cajas objCajas = new Cajas();
        private string _nick;
        private string codCaja;
        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public string _accion;
        public string accion
        {
            get { return _accion; }
            set { _accion = value; }
        }
        public frm_cierreCaja2()
        {
            InitializeComponent();
        }

        private void frm_cierreCaja2_Load(object sender, EventArgs e)
        {
            mostrarConsecutivo();
        }

        private void mostrarConsecutivo()
        {

            try
            {
                DataSet ds1;
                ds1 = objCajas.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = objCajas.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                codCaja = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }


        }
        private void b_borrar_Click(object sender, EventArgs e)
        {
            msk_montoCierre.Text = "";
        }
    

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(msk_montoCierre))
            {
                MessageBox.Show("Por favor escriba un monto de cierre", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_montoCierre.Focus();
                return;
            }
            objCajas.codigo = codCaja;
            objCajas.cierre = Convert.ToInt32(msk_montoCierre.Text);
            objCajas.codRest = objCajas.obtener_cod_rest("Turin Anivo");
            objCajas.fecha = DateTime.Now.ToString("dd/MM/yyyy");
            if (objCajas.guardar_caja("Insertar"))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objCajas.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (objCajas.actualizar_consecutivo(valor))
                    {
                        if (_accion == "Reiniciar")
                        {
                            frm_login login = new frm_login();
                            login.Show();
                        }
                        else
                        {
                            Application.Exit();
                        }
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
            Close();
        }
    }
}

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
    public partial class frm_clientes : Form
    {
        Clientes objClientes = new Clientes();
        public frm_clientes()
        {
            InitializeComponent();
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

        private string _nombreR;

        public string nombreR
        {
            get { return _nombreR; }
            set { _nombreR = value; }
        }

        private int _numeroMesa;

        public int numeroMesa
        {
            get { return _numeroMesa; }
            set { _numeroMesa = value; }
        }

        private string _codR;
        public string codR
        {
            get { return _codR; }
            set { _codR = value; }
        }
        private int _cantSillas;

        public int cantSillas
        {
            get { return _cantSillas; }
            set { _cantSillas = value; }
        }


        private int _montoPago;
        //monto total
        private int _bs1;
        private int _bs2;
        private int _bs3;
        private int _bs4;
        //lista de pedidos del buffet
        private string buffets1;
        private string buffets2;
        private string buffets3;
        private string buffets4;
        private void cb_silla1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_precio1.Text = cb_silla1.SelectedValue.ToString();
            _montoPago += Convert.ToInt32(txt_precio1.Text);
            txt_montoPago.Text = _montoPago.ToString();
        }

        private void cb_silla2_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_precio2.Text = cb_silla2.SelectedValue.ToString();
            _montoPago += Convert.ToInt32(txt_precio1.Text);
            txt_montoPago.Text = _montoPago.ToString();
        }

        private void cb_silla3_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_precio3.Text = cb_silla3.SelectedValue.ToString();
            _montoPago += Convert.ToInt32(txt_precio1.Text);
            txt_montoPago.Text = _montoPago.ToString();
        }

        private void cb_silla4_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_precio4.Text = cb_silla4.SelectedValue.ToString();
            _montoPago += Convert.ToInt32(txt_precio1.Text);
            txt_montoPago.Text = _montoPago.ToString();
        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
            timer1.Start();
            mostrar_consecutivo();
            _montoPago = 0;
            _bs1 = 0;
            _bs2 = 0;
            _bs3 = 0;
            _bs4 = 0;
            buffets1 = "";
            buffets2 = "";
            buffets3 = "";
            buffets4 = "";
            dt_reserva.Value = DateTime.Today;
            cargar_especialidades();
            objClientes.codR = _codR;
            txt_NombreMesa.Text = objClientes.cargar_nombre_mesa(_numeroMesa);
            txt_numeroMesa.Text = _numeroMesa.ToString();
            txt_restaurante.Text = _nombreR;
            txt_montoPago.Text = _montoPago.ToString();
            txt_estadoCuenta.Text = "Sin Pagar";
            msk_fecha_llegada.Text = DateTime.Today.ToString();
            if (_accion.Equals("Editar")) {
                txt_estadoCuenta.Text = "Pagado";
                b_imprimir.Enabled = true;
                cargarinfo();
            }
            if (_cantSillas == 2) {
                cb_silla3.Enabled = false;
                cb_silla4.Enabled = false;
                chk_buffet4.Enabled = false;
                chk_buffet5.Enabled = false;
                lst_pedido3.Visible = false;
                lst_pedido4.Visible = false;
                txt_total3.Visible = false;
                txt_total4.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
            }
           
        }

        private void mostrar_consecutivo()
        {

            try
            {
                DataSet ds1;
                ds1 = objClientes.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = objClientes.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigoCliente.Text = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }

        private void chk_buffet1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_buffet1.Checked)
            {
                panel2.Visible = true;
                try
                {
                    DataSet ds;
                    ds = objClientes.cargar_lista_buffet();
                    lst_pedido1.DataSource = ds.Tables[0];
                    lst_pedido1.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                    lst_pedido1.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            else {
                panel2.Visible = false;
                lst_pedido1.DataSource = null;
                buffets1 = "";
                _bs1 = 0;
            }
            
        }

        private void chk_buffet2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_buffet2.Checked)
            {
                panel2.Visible = true;
                
                try
                {
                    DataSet ds;
                    ds = objClientes.cargar_lista_buffet();
                    lst_pedido2.DataSource = ds.Tables[0];
                    lst_pedido2.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                    lst_pedido2.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                panel2.Visible = false;
                lst_pedido2.DataSource = null;
                buffets2 = "";
                _bs2 = 0;
            }

        }

        private void chk_buffet4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_buffet4.Checked)
            {
                panel2.Visible = true;
                try
                {
                    DataSet ds;
                    ds = objClientes.cargar_lista_buffet();
                    lst_pedido3.DataSource = ds.Tables[0];
                    lst_pedido3.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                    lst_pedido3.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                panel2.Visible = false;
                lst_pedido3.DataSource = null;
                buffets3 = "";
                _bs3 = 0;
            }

        }

        private void chk_buffet5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_buffet1.Checked)
            {
                panel2.Visible = true;
                try
                {
                    DataSet ds;
                    ds = objClientes.cargar_lista_buffet();
                    lst_pedido4.DataSource = ds.Tables[0];
                    lst_pedido4.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                    lst_pedido4.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                panel2.Visible = false;
                lst_pedido4.DataSource = null;
                _bs4 = 0;
                buffets4 = "";
            }

        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombreCliente.Text = "";
            cb_silla1.SelectedIndex = -1;
            cb_silla2.SelectedIndex = -1;
            if (cantSillas == 4){
                cb_silla3.SelectedIndex = -1;
                cb_silla4.SelectedIndex = -1;

            }
            chk_reservacion.Checked = false;
            dt_reserva.Enabled = false;
            msk_fecha_llegada.Text = "";
            chk_buffet1.Checked = false;
            chk_buffet2.Checked = false;
            chk_buffet4.Checked = false;
            chk_buffet5.Checked = false;
            txt_total1.Text = "";
            txt_total2.Text = "";
            txt_total3.Text = "";
            txt_total4.Text = "";
            txt_precio1.Text = "";
            txt_precio2.Text = "";
            txt_precio3.Text = "";
            txt_precio4.Text = "";
            _montoPago = 0;
            _bs1 = 0;
            _bs2 = 0;
            _bs3 = 0;
            _bs4 = 0;
            buffets1 = "";
            buffets2 = "";
            buffets3 = "";
            buffets4 = "";

        }
        private void cargar_especialidades()
        {
            try
            {
                DataSet ds;
                ds = objClientes.cargar_lista_especialidades();
                cb_silla1.DataSource = ds.Tables[0];
                cb_silla1.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_silla1.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                cb_silla2.DataSource = ds.Tables[0];
                cb_silla2.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_silla2.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                if (_cantSillas == 4) {
                    cb_silla3.DataSource = ds.Tables[0];
                    cb_silla3.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                    cb_silla3.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                    cb_silla4.DataSource = ds.Tables[0];
                    cb_silla4.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                    cb_silla4.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (!cls_validacion.validar(txt_nombreCliente))
            {
                MessageBox.Show("Por favor escriba un nombre al cliente", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreCliente.Focus();
                return;
            }

            if (_montoPago==0)
            {
                MessageBox.Show("Por favor realice una orden", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
                        
            if (!cls_validacion.validar(msk_fecha_llegada))
            {
                MessageBox.Show("Por favor escriba una fecha de llegada", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_fecha_llegada.Focus();
                return;
            }

            
            objClientes.codigo = txt_codigoCliente.Text.Replace(" ", "");
            objClientes.nombre = txt_nombreCliente.Text;
            objClientes.fechaE = msk_fecha_llegada.Text;
            objClientes.monto = _montoPago;
            objClientes.codR = _codR;
            objClientes.horaE = txt_horaEntrada.Text;
            if (chk_reservacion.Checked)
            {
                objClientes.fechaR = dt_reserva.Value.ToString("dd/MM/yyyy");
                objClientes.reservo = true;
            }
            else {
                objClientes.reservo = false;
            }
            objClientes.horaS = txt_horaSalida.Text;
            objClientes.duracion = txt_duracionMesa.Text;
            objClientes.barra = false;
            objClientes.codMesa = objClientes.cargar_cod_mesa(_numeroMesa);
            if (cb_silla1.SelectedIndex != -1)
            {
                objClientes.pedidos1 = cb_silla1.SelectedItem.ToString();
            }
            else {
                objClientes.pedidos1 = "";
            }
            if (cb_silla2.SelectedIndex != -1)
            {
                objClientes.pedidos2 = cb_silla2.SelectedItem.ToString();
            }
            else
            {
                objClientes.pedidos2 = "";
            }
            if (_cantSillas == 4) {
                if (cb_silla3.SelectedIndex != -1)
                {
                    objClientes.pedidos3 = cb_silla3.SelectedItem.ToString();
                }
                else
                {
                    objClientes.pedidos3 = "";
                }
                if (cb_silla4.SelectedIndex != -1)
                {
                    objClientes.pedidos4 = cb_silla4.SelectedItem.ToString();
                }
                else
                {
                    objClientes.pedidos4 = "";
                }
            }

            if (chk_buffet1.Checked)
            {
                foreach (DataRowView objDataRowView in lst_pedido4.SelectedItems)
                {
                    buffets1 += objDataRowView["nombre"].ToString() + ";";
                }

                objClientes.listabs1 = buffets1;

            }
            else {
                objClientes.listabs1 = "";
            }
            if (chk_buffet2.Checked)
            {
                foreach (DataRowView objDataRowView in lst_pedido4.SelectedItems)
                {
                    buffets2 += objDataRowView["nombre"].ToString() + ";";
                }
                objClientes.listabs2 = buffets2;

            }
            else
            {
                objClientes.listabs2 = "";
            }
            if (chk_buffet4.Checked)
            {
                foreach (DataRowView objDataRowView in lst_pedido4.SelectedItems)
                {
                    buffets3 += objDataRowView["nombre"].ToString() + ";";
                }
                objClientes.listabs3 = buffets3;

            }
            else
            {
                objClientes.listabs3 = "";
            }
            if (chk_buffet5.Checked)
            {
                foreach (DataRowView objDataRowView in lst_pedido4.SelectedItems)
                {
                    buffets4 += objDataRowView["nombre"].ToString() + ";";
                }
                objClientes.listabs4 = buffets4;

            }
            else
            {
                objClientes.listabs4 = "";
            }
           
            
            if (objClientes.guardar_cliente(_accion))
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = objClientes.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (objClientes.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Cliente insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Close();
        }

        private void b_imprimir_Click(object sender, EventArgs e)
        {
            //Generar XML
        }

        private void lst_pedido1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bs1 = 0;
            foreach (DataRowView objDataRowView in lst_pedido1.SelectedItems)
            {
                _bs1 += Convert.ToInt32(objDataRowView["precio"].ToString());
            }
            
            txt_total1.Text = _bs1.ToString();
        }

        private void lst_pedido2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bs2 += Convert.ToInt32(lst_pedido2.SelectedValue.ToString());
            
            txt_total2.Text = _bs2.ToString();
        }

        private void lst_pedido3_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bs3 += Convert.ToInt32(lst_pedido3.SelectedValue.ToString());
            
            txt_total3.Text = _bs3.ToString();
        }

        private void lst_pedido4_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bs4 += Convert.ToInt32(lst_pedido4.SelectedValue.ToString());
            
            txt_total4.Text = _bs4.ToString();
        }

        private void chk_reservacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_reservacion.Checked)
            {
                dt_reserva.Enabled = true;
            }
            else {
                dt_reserva.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            
            if (_accion == "Editar")
            {
                txt_horaSalida.Text = hora.ToString("HH:mm:ss");
                DateTime dur = DateTime.Parse(txt_horaEntrada.Text);
                TimeSpan t = new TimeSpan();
                t = dur-hora;
                double duracion = t.TotalHours; 
                txt_duracionMesa.Text =duracion.ToString();
            }
            else {
                txt_horaEntrada.Text = hora.ToString("HH:mm:ss");
                timer1.Stop();
            }
        }
    
        private void cargarinfo()
        {
            objClientes.carga_info_cliente(_codigo);
            if (objClientes.nombre != "Error")
            {
                _numeroMesa = objClientes.cargar_num_mesa(objClientes.codMesa);
                txt_codigoCliente.Text = _codigo;
                txt_nombreCliente.Text = objClientes.nombre;
                txt_montoPago.Text = objClientes.monto.ToString();
                txt_NombreMesa.Text = objClientes.cargar_nombre_mesa(_numeroMesa);
                _cantSillas = objClientes.cargar_cant_sillas(_numeroMesa);
                txt_numeroMesa.Text = _numeroMesa.ToString();
                txt_restaurante.Text = _nombreR;
                txt_horaEntrada.Text = objClientes.horaE;
                txt_estadoCuenta.Text = "Pagado";
                msk_fecha_llegada.Text = objClientes.fechaE;
                if (objClientes.reservo) {
                    dt_reserva.Value = Convert.ToDateTime(objClientes.fechaR);
                    chk_reservacion.Checked = true;
                }
                if (!string.IsNullOrEmpty(objClientes.pedidos1))
                {
                    cb_silla1.SelectedItem = objClientes.pedidos1;
                    txt_precio1.Text = cb_silla1.SelectedValue.ToString();
                }
                if (!string.IsNullOrEmpty(objClientes.pedidos2))
                {
                    cb_silla2.SelectedItem = objClientes.pedidos2;
                    txt_precio2.Text = cb_silla2.SelectedValue.ToString();
                }
                if (!string.IsNullOrEmpty(objClientes.listabs1)) {
                    chk_buffet1.Checked = true;
                    panel2.Visible = true;
                    try
                    {
                        DataSet ds;
                        ds = objClientes.cargar_lista_buffet();
                        lst_pedido1.DataSource = ds.Tables[0];
                        lst_pedido1.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                        lst_pedido1.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string[] words = objClientes.listabs1.Split(',');
                    foreach (string word in words)
                    {
                        int index = lst_pedido1.FindString(word);
                        lst_pedido1.SetSelected(index, true);
                    }
                    foreach (DataRowView objDataRowView in lst_pedido1.SelectedItems)
                    {
                        _bs1 += Convert.ToInt32(objDataRowView["precio"].ToString());
                    }

                    txt_total1.Text = _bs1.ToString();
                }

                if (!string.IsNullOrEmpty(objClientes.listabs2))
                {
                    chk_buffet2.Checked = true;
                    panel2.Visible = true;
                    try
                    {
                        DataSet ds;
                        ds = objClientes.cargar_lista_buffet();
                        lst_pedido2.DataSource = ds.Tables[0];
                        lst_pedido2.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                        lst_pedido2.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string[] words = objClientes.listabs2.Split(',');
                    foreach (string word in words)
                    {
                        int index = lst_pedido2.FindString(word);
                        lst_pedido2.SetSelected(index, true);
                    }
                    foreach (DataRowView objDataRowView in lst_pedido2.SelectedItems)
                    {
                        _bs2 += Convert.ToInt32(objDataRowView["precio"].ToString());
                    }

                    txt_total2.Text = _bs2.ToString();
                }

                if (_cantSillas == 4) {
                    if (!string.IsNullOrEmpty(objClientes.pedidos3))
                    {
                        cb_silla3.SelectedItem = objClientes.pedidos3;
                        txt_precio3.Text = cb_silla3.SelectedValue.ToString();

                    }
                    if (!string.IsNullOrEmpty(objClientes.pedidos4))
                    {
                        cb_silla4.SelectedItem = objClientes.pedidos4;
                        txt_precio4.Text = cb_silla4.SelectedValue.ToString();
                    }
                    if (!string.IsNullOrEmpty(objClientes.listabs3))
                    {
                        chk_buffet4.Checked = true;
                        panel2.Visible = true;
                        try
                        {
                            DataSet ds;
                            ds = objClientes.cargar_lista_buffet();
                            lst_pedido3.DataSource = ds.Tables[0];
                            lst_pedido3.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                            lst_pedido3.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string[] words = objClientes.listabs4.Split(',');
                        foreach (string word in words)
                        {
                            int index = lst_pedido4.FindString(word);
                            lst_pedido4.SetSelected(index, true);
                        }
                        foreach (DataRowView objDataRowView in lst_pedido3.SelectedItems)
                        {
                            _bs3 += Convert.ToInt32(objDataRowView["precio"].ToString());
                        }

                        txt_total3.Text = _bs3.ToString();
                    }
                    if (!string.IsNullOrEmpty(objClientes.listabs1))
                    {
                        chk_buffet5.Checked = true;
                        panel2.Visible = true;
                        try
                        {
                            DataSet ds;
                            ds = objClientes.cargar_lista_buffet();
                            lst_pedido4.DataSource = ds.Tables[0];
                            lst_pedido4.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                            lst_pedido4.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string[] words = objClientes.listabs4.Split(',');
                        foreach (string word in words)
                        {
                            int index = lst_pedido4.FindString(word);
                            lst_pedido4.SetSelected(index, true);
                        }
                        foreach (DataRowView objDataRowView in lst_pedido4.SelectedItems)
                        {
                            _bs4 += Convert.ToInt32(objDataRowView["precio"].ToString());
                        }

                        txt_total4.Text = _bs4.ToString();
                    }

                }
                
            }

        }
    }
}

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
using System.Globalization;
using System.Xml;

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


        private double _montoPago;
        private bool cblisto;
        //monto total
        private double _bs1;
        private double _bs2;
        private double _bs3;
        private double _bs4;
        //lista de pedidos del buffet
        private string buffets1;
        private string buffets2;
        private string buffets3;
        private string buffets4;
        double precio;
        private void cb_silla1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cblisto)
            {
                if (cb_silla1.SelectedIndex > 0)
                {
                    if (!string.IsNullOrEmpty(txt_precio1.Text))
                    {
                        precio = double.Parse(txt_precio1.Text, NumberStyles.Currency);
                        _montoPago -= precio;
                    }
                    txt_precio1.Text = cb_silla1.SelectedValue.ToString();
                    precio = double.Parse(txt_precio1.Text, NumberStyles.Currency);
                    _montoPago += precio;
                    txt_montoPago.Text = _montoPago.ToString();
                }
                else {
                    txt_precio1.Text = "";
                }
            }
        }

        private void cb_silla2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cblisto)
            {
                if (cb_silla2.SelectedIndex > 0)
                {
                    if (!string.IsNullOrEmpty(txt_precio2.Text))
                    {
                        precio = double.Parse(txt_precio2.Text, NumberStyles.Currency);
                        _montoPago -= precio;
                    }
                    txt_precio2.Text = cb_silla2.SelectedValue.ToString();
                    precio = double.Parse(txt_precio2.Text, NumberStyles.Currency);
                    _montoPago +=precio;
                    txt_montoPago.Text = _montoPago.ToString();
                }
                else
                {
                    txt_precio2.Text = "";
                }
            }
        }

        private void cb_silla3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cblisto)
            {
                if (cb_silla3.SelectedIndex > 0)
                {
                    if (!string.IsNullOrEmpty(txt_precio3.Text))
                    {
                        precio = double.Parse(txt_precio3.Text, NumberStyles.Currency);
                        _montoPago -= precio;
                    }
                    txt_precio3.Text = cb_silla3.SelectedValue.ToString();
                    precio = double.Parse(txt_precio3.Text, NumberStyles.Currency);
                    _montoPago += precio;
                    txt_montoPago.Text = _montoPago.ToString();
                }
                else
                {
                    txt_precio3.Text = "";
                }
            }
        }

        private void cb_silla4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cblisto)
            {
                if (cb_silla4.SelectedIndex > 0)
                {
                    if (!string.IsNullOrEmpty(txt_precio4.Text))
                    {
                        precio = double.Parse(txt_precio4.Text, NumberStyles.Currency);
                        _montoPago -= precio;
                    }
                    txt_precio4.Text = cb_silla4.SelectedValue.ToString();
                    precio = double.Parse(txt_precio4.Text, NumberStyles.Currency);
                    _montoPago += precio;
                    txt_montoPago.Text = _montoPago.ToString();
                }
                else
                {
                    txt_precio4.Text = "";
                }
            }
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
            objClientes.codR = _codR;
            cargar_especialidades();
            txt_NombreMesa.Text = objClientes.cargar_nombre_mesa(_numeroMesa);
            txt_numeroMesa.Text = _numeroMesa.ToString();
            txt_restaurante.Text = _nombreR;
            txt_montoPago.Text = _montoPago.ToString();
            txt_estadoCuenta.Text = "Sin Pagar";
            msk_fecha_llegada.Text = DateTime.Today.ToString();
            if (_accion.Equals("Editar")) {
                objClientes.codigo = _codigo;
                objClientes.codMesa = objClientes.cargar_cod_mesa2();
                objClientes.codMesa.Replace(" ", "");
                _numeroMesa = objClientes.cargar_num_mesa(objClientes.codMesa);
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
                if (!chk_buffet2.Checked && !chk_buffet4.Checked && !chk_buffet5.Checked)
                {
                    panel2.Visible = false;
                }
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
                if(!chk_buffet1.Checked && !chk_buffet4.Checked && !chk_buffet5.Checked)
                {
                    panel2.Visible = false;
                }
                
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
                if (!chk_buffet1.Checked && !chk_buffet2.Checked && !chk_buffet5.Checked)
                {
                    panel2.Visible = false;
                }
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
                if (!chk_buffet1.Checked && !chk_buffet2.Checked && !chk_buffet4.Checked)
                {
                    panel2.Visible = false;
                }
                lst_pedido4.DataSource = null;
                _bs4 = 0;
                buffets4 = "";
            }

        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombreCliente.Text = "";
            cb_silla1.SelectedIndex = 0;
            cb_silla2.SelectedIndex = 0;
            if (cantSillas == 4){
                cb_silla3.SelectedIndex = 0;
                cb_silla4.SelectedIndex = 0;

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
            cblisto = true;
            try
            {
                DataSet ds;
                DataSet ds2;
                DataSet ds3;
                DataSet ds4;
                ds = objClientes.cargar_lista_especialidades();
                DataRow dataRow = ds.Tables[0].NewRow();

                dataRow["nombre"] = "";
                dataRow["precio"] = "0";

                ds.Tables[0].Rows.InsertAt(dataRow, 0);
                cb_silla1.DataSource = ds.Tables[0];
                cb_silla1.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_silla1.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                ds2 = objClientes.cargar_lista_especialidades();
                DataRow dataRow2 = ds2.Tables[0].NewRow();

                dataRow2["nombre"] = "";
                dataRow2["precio"] = "0";
                ds2.Tables[0].Rows.InsertAt(dataRow2, 0);
                cb_silla2.DataSource = ds2.Tables[0];
                cb_silla2.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_silla2.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                if (_cantSillas == 4) {
                    ds3 = objClientes.cargar_lista_especialidades();
                    DataRow dataRow3 = ds3.Tables[0].NewRow();
                    dataRow3["nombre"] = "";
                    dataRow3["precio"] = "0";
                    ds3.Tables[0].Rows.InsertAt(dataRow3, 0);
                    cb_silla3.DataSource = ds3.Tables[0];
                    cb_silla3.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                    cb_silla3.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                    ds4 = objClientes.cargar_lista_especialidades();
                    DataRow dataRow4 = ds4.Tables[0].NewRow();
                    dataRow4["nombre"] = "";
                    dataRow4["precio"] = "0";
                    ds4.Tables[0].Rows.InsertAt(dataRow4, 0);
                    cb_silla4.DataSource = ds.Tables[0];
                    cb_silla4.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                    cb_silla4.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                }
                cblisto = false;
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
            if (cb_silla1.SelectedIndex >0)
            {
                objClientes.pedidos1 = cb_silla1.Text;
            }
            else {
                objClientes.pedidos1 = "";
            }
            if (cb_silla2.SelectedIndex > 0)
            {
                objClientes.pedidos2 = cb_silla2.Text;
            }
            else
            {
                objClientes.pedidos2 = "";
            }
            if (_cantSillas == 4) {
                if (cb_silla3.SelectedIndex > 0)
                {
                    objClientes.pedidos3 = cb_silla3.Text;
                }
                else
                {
                    objClientes.pedidos3 = "";
                }
                if (cb_silla4.SelectedIndex > 0)
                {
                    objClientes.pedidos4 = cb_silla4.Text;
                }
                else
                {
                    objClientes.pedidos4 = "";
                }
            }

            if (chk_buffet1.Checked)
            {
                foreach (DataRowView objDataRowView in lst_pedido1.SelectedItems)
                {
                    buffets1 += objDataRowView["nombre"].ToString() + ",";
                }

                objClientes.listabs1 = buffets1;

            }
            else {
                objClientes.listabs1 = "";
            }
            if (chk_buffet2.Checked)
            {
                foreach (DataRowView objDataRowView in lst_pedido2.SelectedItems)
                {
                    buffets2 += objDataRowView["nombre"].ToString() + ",";
                }
                objClientes.listabs2 = buffets2;

            }
            else
            {
                objClientes.listabs2 = "";
            }
            if (chk_buffet4.Checked)
            {
                foreach (DataRowView objDataRowView in lst_pedido3.SelectedItems)
                {
                    buffets3 += objDataRowView["nombre"].ToString() + ",";
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
                    buffets4 += objDataRowView["nombre"].ToString() + ",";
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
            
            XmlTextWriter writer = new XmlTextWriter("Factura.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Factura");
            writer.WriteStartElement("Restaurante");
            writer.WriteString(_nombreR);
            writer.WriteEndElement();
            writer.WriteStartElement("Fecha");
            writer.WriteString(objClientes.fechaE);
            writer.WriteEndElement();
            writer.WriteStartElement("NombreCliente");
            writer.WriteString(objClientes.nombre);
            writer.WriteEndElement();
            writer.WriteStartElement("HoraEntrada");
            writer.WriteString(objClientes.horaE);
            writer.WriteEndElement();
            writer.WriteStartElement("HoraSalida");
            writer.WriteString(objClientes.horaS);
            writer.WriteEndElement();
            writer.WriteStartElement("DuracionMesa");
            writer.WriteString(objClientes.duracion);
            writer.WriteEndElement();
            writer.WriteStartElement("ListaFactura");
            for (int i = 0; i < 4; i++) {
                switch (i) {
                    case 1:
                        if (!string.IsNullOrEmpty(objClientes.pedidos1))
                        {
                            crearNodo(objClientes.pedidos1, "Especialidad", writer);
                            
                            
                        }
                        if (!string.IsNullOrEmpty(objClientes.listabs1))
                        {

                            string[] words = objClientes.listabs1.Remove(objClientes.listabs1.Length - 1).Split(',');
                            foreach (string word in words)
                            {
                                crearNodo(word, "Buffet", writer);
                            }
                        }

                        break;
                    case 2:
                        if (!string.IsNullOrEmpty(objClientes.pedidos2))
                        {
                            crearNodo(objClientes.pedidos2, "Especialidad", writer);
                        }
                        if (!string.IsNullOrEmpty(objClientes.listabs2))
                        {

                            string[] words = objClientes.listabs2.Remove(objClientes.listabs2.Length - 1).Split(',');
                            foreach (string word in words)
                            {
                                crearNodo(word, "Buffet", writer);
                            }
                        }
                        break;
                    case 3:
                        if (!string.IsNullOrEmpty(objClientes.pedidos3))
                        {
                            crearNodo(objClientes.pedidos3, "Especialidad", writer);
                        }
                        if (!string.IsNullOrEmpty(objClientes.listabs3))
                        {

                            string[] words = objClientes.listabs3.Remove(objClientes.listabs3.Length - 1).Split(',');
                            foreach (string word in words)
                            {
                                crearNodo(word, "Buffet", writer);
                            }
                        }
                        break;
                    case 4:
                        if (!string.IsNullOrEmpty(objClientes.pedidos4))
                        {
                            crearNodo(objClientes.pedidos4, "Especialidad", writer);
                        }
                        if (!string.IsNullOrEmpty(objClientes.listabs4))
                        {

                            string[] words = objClientes.listabs4.Remove(objClientes.listabs4.Length - 1).Split(',');
                            foreach (string word in words)
                            {
                                crearNodo(word, "Buffet", writer);
                            }
                        }
                        break;
                    default:
                        break;


                }
                
            }
           
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("Factura Creada", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void crearNodo(string especilidad, string tipo, XmlTextWriter writer)
        {
            writer.WriteStartElement("Producto");
            writer.WriteStartElement("Nombre");
            writer.WriteString(especilidad);
            writer.WriteEndElement();
            writer.WriteStartElement("Tipo");
            writer.WriteString(tipo);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        private void lst_pedido1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_total1.Text = "";
            if (_bs1 != 0) {
                _montoPago -= _bs1;
            }
            if (lst_pedido1.SelectedIndex != -1)
            {
                _bs1 = 0;
                foreach (DataRowView objDataRowView in lst_pedido1.SelectedItems)
                {
                    _bs1 += double.Parse(objDataRowView["precio"].ToString(), NumberStyles.Currency);
                }

                txt_total1.Text = _bs1.ToString();
                _montoPago += _bs1;
                txt_montoPago.Text = _montoPago.ToString();
            }
        }

        private void lst_pedido2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_total2.Text = "";
            if (_bs2 != 0)
            {
                _montoPago -= _bs2;
            }
            if (lst_pedido2.SelectedIndex != -1)
            {
                _bs2 = 0;
                foreach (DataRowView objDataRowView in lst_pedido2.SelectedItems)
                {
                    _bs2 += double.Parse(objDataRowView["precio"].ToString(), NumberStyles.Currency);
                }

                txt_total2.Text = _bs2.ToString();
                _montoPago += _bs2;
                txt_montoPago.Text = _montoPago.ToString();
            }
        }

        private void lst_pedido3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_bs3 != 0)
            {
                _montoPago -= _bs3;
            }
            _bs3 = 0;
            foreach (DataRowView objDataRowView in lst_pedido3.SelectedItems)
            {
                _bs3 += double.Parse(objDataRowView["precio"].ToString(), NumberStyles.Currency);
            }

            txt_total3.Text = _bs3.ToString();
        }

        private void lst_pedido4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_bs4 != 0)
            {
                _montoPago -= _bs4;
            }
            _bs4 = 0;
            foreach (DataRowView objDataRowView in lst_pedido4.SelectedItems)
            {
                _bs4 += double.Parse(objDataRowView["precio"].ToString(), NumberStyles.Currency);
            }

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
                string horaEntrada = objClientes.horaE;
                DateTime dur = DateTime.ParseExact(horaEntrada, "HH:mm:ss", CultureInfo.InvariantCulture);
                TimeSpan t = new TimeSpan();
                t = dur - hora;
                string duracion = t.ToString(@"hh\:mm\:ss");
                txt_duracionMesa.Text = duracion;
                txt_horaSalida.Text = hora.ToString("HH:mm:ss");
                timer1.Stop();
                
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
                    DateTime t = DateTime.ParseExact(objClientes.fechaR, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dt_reserva.Value = t;
                    chk_reservacion.Checked = true;
                }
                if (!string.IsNullOrEmpty(objClientes.pedidos1))
                {
                    cb_silla1.SelectedIndex = cb_silla1.FindStringExact(objClientes.pedidos1);
                    txt_precio1.Text = cb_silla1.SelectedValue.ToString();
                }
                if (!string.IsNullOrEmpty(objClientes.pedidos2))
                {
                    cb_silla2.SelectedIndex = cb_silla1.FindStringExact(objClientes.pedidos2);
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
                    /**foreach (DataRowView objDataRowView in lst_pedido1.SelectedItems)
                    {
                        _bs1 += double.Parse(objDataRowView["precio"].ToString(), NumberStyles.Currency);
                    }

                    txt_total1.Text = _bs1.ToString();*/
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
                    
                }

                if (_cantSillas == 4) {
                    if (!string.IsNullOrEmpty(objClientes.pedidos3))
                    {
                        cb_silla3.SelectedIndex = cb_silla1.FindStringExact(objClientes.pedidos3);
                        txt_precio3.Text = cb_silla3.SelectedValue.ToString();

                    }
                    if (!string.IsNullOrEmpty(objClientes.pedidos4))
                    {
                        cb_silla4.SelectedIndex = cb_silla1.FindStringExact(objClientes.pedidos4);
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
                        string[] words = objClientes.listabs3.Split(',');
                        foreach (string word in words)
                        {
                            int index = lst_pedido3.FindString(word);
                            lst_pedido3.SetSelected(index, true);
                        }
                        
                    }
                    if (!string.IsNullOrEmpty(objClientes.listabs4))
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
                       
                    }

                }
                
            }

        }
    }
}

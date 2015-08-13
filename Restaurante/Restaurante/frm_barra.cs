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
    public partial class frm_barra : Form
    {
        ClientesBarra objClientes = new ClientesBarra();

        private double _montoPago;
        private bool cblisto;
        private string buffet;
        private string _codR;
        public string codR
        {
            get { return _codR; }
            set { _codR = value; }
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

        public frm_barra()
        {
            InitializeComponent();
        }

        private void lst_pedidosPrevios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_pedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precio;
            buffet = objClientes.listaPedidos;
            if (!cblisto)
            {
                if (cb_pedido.SelectedIndex > 0)
                {
                    if (!string.IsNullOrEmpty(txt_precio.Text))
                    {
                        precio = double.Parse(txt_precio.Text, NumberStyles.Currency);
                        _montoPago -= precio;
                    }
                    txt_precio.Text = cb_pedido.SelectedValue.ToString();
                    precio = double.Parse(txt_precio.Text, NumberStyles.Currency);
                    _montoPago += precio;
                    txt_montoPago.Text = _montoPago.ToString();
                    buffet += cb_pedido.Text + ",";
                }
                else
                {
                    txt_precio.Text = "";
                }
            }
        }

        private void frm_barra_Load(object sender, EventArgs e)
        {
            timer1.Start();
            mostrar_consecutivo();
            _montoPago = 0;
            buffet = "";
            objClientes.codR = _codR;
            cargar_buffet();
            txt_mesa.Text = "barra";
            txt_restaurante.Text = _nombreR;
            txt_montoPago.Text = _montoPago.ToString();
            txt_cuenta.Text = "Sin Pagar";
            if (_accion.Equals("Editar"))
            {
                b_imprimir.Enabled = true;
                cargarinfo();
            }
        }
        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombreCliente.Text = "";
            cb_pedido.SelectedIndex = 0;
            txt_numeroSilla.Text = "";
            txt_precio.Text = "";
            if (_accion == "Editar")
            {
                _montoPago = objClientes.monto;
                if (!string.IsNullOrEmpty(objClientes.listaPedidos))
                {

                    string[] words = objClientes.listaPedidos.Split(',');
                    foreach (string word in words)
                    {
                        int index = lst_pedidosPrevios.FindString(word);
                        lst_pedidosPrevios.SetSelected(index, true);
                    }
                    buffet = objClientes.listaPedidos;
                    txt_montoPago.Text = objClientes.monto.ToString();
                }
            }
            else
            {
                _montoPago = 0;
                txt_montoPago.Text = "";
                buffet = "";

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

            if (_montoPago == 0)
            {
                MessageBox.Show("Por favor realice una orden", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!cls_validacion.validar(txt_numeroSilla) && !cls_validacion.esentero(txt_numeroSilla))
            {
                MessageBox.Show("Por favor escriba un numero de silla", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numeroSilla.Focus();
                return;
            }


            objClientes.codigo = txt_codigoCliente.Text.Replace(" ", "");
            objClientes.nombre = txt_nombreCliente.Text;
            objClientes.fechaE = DateTime.Today.ToString("dd/MM/yyyy");
            objClientes.monto = _montoPago;
            objClientes.codR = _codR;
            objClientes.horaE = txt_horaEntrada.Text;
            objClientes.horaS = txt_horaSalida.Text;
            objClientes.duracion = txt_duracion.Text;
            objClientes.barra = false;
            objClientes.listaPedidos = buffet;
            objClientes.numeroSilla = Convert.ToInt32(txt_numeroSilla.Text);

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

        private void cargarinfo()
        {
            objClientes.carga_info_cliente(_codigo);
            if (objClientes.nombre != "Error")
            {
                txt_codigoCliente.Text = _codigo;
                txt_nombreCliente.Text = objClientes.nombre;
                txt_montoPago.Text = objClientes.monto.ToString();
                txt_numeroSilla.Text = objClientes.numeroSilla.ToString();
                txt_restaurante.Text = _nombreR;
                txt_horaEntrada.Text = objClientes.horaE;
                

                if (!string.IsNullOrEmpty(objClientes.listaPedidos))
                {

                    string[] words = objClientes.listaPedidos.Split(',');
                    foreach (string word in words)
                    {
                        lst_pedidosPrevios.Items.Add(word);
                    }
                    txt_montoPago.Text = objClientes.monto.ToString();
                }



            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;

            if (_accion == "Editar" || _accion == "Pagar")
            {
                
                string horaEntrada = objClientes.horaE;
                DateTime dur = DateTime.ParseExact(horaEntrada,"HH:mm:ss", CultureInfo.InvariantCulture);
                TimeSpan t = new TimeSpan();
                t = dur - hora;
                string duracion = t.ToString(@"hh\:mm\:ss");
                txt_duracion.Text = duracion;
                if (accion == "Pagar")
                {
                    txt_horaSalida.Text = hora.ToString("HH:mm:ss");
                    timer1.Stop();
                }
                
            }
            else
            {
                txt_horaEntrada.Text = hora.ToString("HH:mm:ss");
                timer1.Stop();
            }
        }

        private void cargar_buffet()
        {
            cblisto = true;
            try
            {
                DataSet ds;
                ds = objClientes.cargar_lista_buffet();
                DataRow dataRow = ds.Tables[0].NewRow();
                dataRow["nombre"] = "";
                dataRow["precio"] = "0";
                ds.Tables[0].Rows.InsertAt(dataRow, 0);
                cb_pedido.DataSource = ds.Tables[0];
                cb_pedido.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
                cb_pedido.ValueMember = ds.Tables[0].Columns["precio"].ColumnName.ToString();
                cblisto = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con la conexión a la base de datos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

        private void b_imprimir_Click(object sender, EventArgs e)
        {
            _accion = "Pagar";
            txt_cuenta.Text = "Pagado";

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
            writer.WriteString(txt_horaSalida.Text);
            writer.WriteEndElement();
            writer.WriteStartElement("DuracionMesa");
            writer.WriteString(txt_duracion.Text);
            writer.WriteEndElement();
            writer.WriteStartElement("ListaFactura");
            if (!string.IsNullOrEmpty(objClientes.listaPedidos))
            {

                            string[] words = objClientes.listaPedidos.Remove(objClientes.listaPedidos.Length - 1).Split(',');
                            foreach (string word in words)
                            {
                                crearNodo(word, "Buffet", writer);
                            }
                        
                       

            }
            writer.WriteStartElement("MontoAPagar");
            writer.WriteString(objClientes.monto.ToString());
            writer.WriteEndElement();
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
    }
}

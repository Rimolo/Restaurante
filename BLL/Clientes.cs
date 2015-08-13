using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DAL;
using System.Windows.Forms;
namespace BLL
{
    public class Clientes
    {
        #region propiedades
        private string _codigo;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _codR;

        public string codR
        {
            get { return _codR; }
            set { _codR = value; }
        }

        private string _codMesa;

        public string codMesa
        {
            get { return _codMesa; }
            set { _codMesa = value; }
        }

        private string _fechaE;

        public string fechaE
        {
            get { return _fechaE; }
            set { _fechaE = value; }
        }

        private string _fechaR;

        public string fechaR
        {
            get { return _fechaR; }
            set { _fechaR = value; }
        }

        private double _monto;

        public double monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        private string _horaE;

        public string horaE
        {
            get { return _horaE; }
            set { _horaE = value; }
        }

        private string _horaS;

        public string horaS
        {
            get { return _horaS; }
            set { _horaS = value; }
        }

        private bool _reservo;

        public bool reservo
        {
            get { return _reservo; }
            set { _reservo = value; }
        }

        private bool _barra;

        public bool barra
        {
            get { return _barra; }
            set { _barra = value; }
        }
        private string _duracion;

        public string duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }

        private string _pedidos1;

        public string pedidos1
        {
            get { return _pedidos1; }
            set { _pedidos1 = value; }
        }

        private string _pedidos2;

        public string pedidos2
        {
            get { return _pedidos2; }
            set { _pedidos2 = value; }
        }

        private string _pedidos3;

        public string pedidos3
        {
            get { return _pedidos3; }
            set { _pedidos3 = value; }
        }

        private string _pedidos4;

        public string pedidos4
        {
            get { return _pedidos4; }
            set { _pedidos4 = value; }
        }

        private string _listabs1;

        public string listabs1
        {
            get { return _listabs1; }
            set { _listabs1 = value; }
        }

        private string _listabs2;

        public string listabs2
        {
            get { return _listabs2; }
            set { _listabs2 = value; }
        }

        private string _listabs3;

        public string listabs3
        {
            get { return _listabs3; }
            set { _listabs3 = value; }
        }

        private string _listabs4;

        public string listabs4
        {
            get { return _listabs4; }
            set { _listabs4 = value; }
        }

        #endregion

        #region variables privadas
        SqlConnection conexion;
        string sql;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region Metodos
        public bool guardar_cliente(string accion)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (accion.Equals("Insertar"))
                {
                    if (!_reservo)
                    {
                        sql = "Insert into Cliente values(@cod,@nombre,convert(datetime,@fecha,103),@monto,0,0,@codR,@horaE,null,null,'Sin pagar',null)";

                    }
                    else
                    {
                        sql = "Insert into Cliente values(@cod,@nombre,convert(datetime,@fecha,103),@monto,1,0,@codR,@horaE,null,null,'Sin pagar',convert(datetime,@fechaR,103))";

                    }
                }
                else
                {
                    sql = "Update Cliente SET" +
                        " estadoFactura='Pagado'," +
                        " horaSalida=@horaS," +
                        " duracion=@duracion" +
                        " where codCliente=@cod";
                }
                ParamStruct[] parametros = new ParamStruct[9];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fecha", SqlDbType.VarChar, _fechaE);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@monto", SqlDbType.Money, _monto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@codR", SqlDbType.VarChar, _codR);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@horaE", SqlDbType.VarChar, _horaE);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@horaS", SqlDbType.VarChar, _horaS);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@fechaR", SqlDbType.VarChar, _fechaR);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@duracion", SqlDbType.VarChar, _duracion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@cod", SqlDbType.VarChar, _codigo);



                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return false;
                }
                else
                {
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    if (accion == "Insertar")
                    {
                        guardar_pedidos();

                    }
                    return true;
                }


            }
        }

        public void guardar_pedidos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                sql = "Insert into ClienteReserva values(@codM,@cod,@ps1,@ps2,@ps3,@ps4,@ls1,@ls2,@ls3,@ls4)";

                ParamStruct[] parametros = new ParamStruct[10];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codM", SqlDbType.VarChar, _codMesa);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ps1", SqlDbType.VarChar, _pedidos1);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@ps2", SqlDbType.VarChar, _pedidos2);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@ps3", SqlDbType.VarChar, _pedidos3);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@ps4", SqlDbType.VarChar, _pedidos4);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@cod", SqlDbType.VarChar, _codigo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@ls1", SqlDbType.VarChar, _listabs1);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@ls2", SqlDbType.VarChar, _listabs2);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@ls3", SqlDbType.VarChar, _listabs3);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@ls4", SqlDbType.VarChar, _listabs4);


                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar los pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return;
                }
                else
                {
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return;
                }
            }
        }


        public DataSet retorna_consecutivo_valor()
        {

            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener la cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select valor From Consecutivos WHERE tipo='Clientes'";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error cargar los consecutivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {


                    return ds;
                }
            }
        }


        public DataSet retorna_consecutivo_prefijo()
        {

            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener la cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select prefijo From Consecutivos WHERE tipo='Clientes'";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error cargar los consecutivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {


                    return ds;
                }
            }
        }

        public bool actualizar_consecutivo(int id)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener la cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {

                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Clientes'";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@valor", SqlDbType.Int, id);

                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return false;
                }
                else
                {
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return true;
                }
            }
        }

        public DataSet carga_clientes()
        {
            //Modificar cuando vaya a cargar el grid
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select c.codCliente,c.nombre,c.montoPagado,concat(concat(concat(concat(concat(concat(concat(concat(pedidoS1,' '), cr.pedidoS2), cr.pedidoS3), cr.pedidoS4), cr.buffetS1), cr.buffetS2), cr.buffetS3), cr.buffetS4) as detalleProducto,c.fecha,c.reserva,r.nombre as nombreRest from Cliente c join ClienteReserva cr on c.codCliente = cr.codCliente join Restaurante r on c.codRestaurante = r.codRestaurante Where c.codRestaurante='" + _codR + "' Order by c.CodCliente";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        //Modificar cuando vaya a cargar el grid
        public DataSet carga_cliente_especifico()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select c.codCliente,c.nombre,c.montoPagado,concat(concat(concat(concat(concat(concat(concat(concat(pedidoS1,' '), cr.pedidoS2), cr.pedidoS3), cr.pedidoS4), cr.buffetS1), cr.buffetS2), cr.buffetS3), cr.buffetS4) as detalleProducto,c.fecha,c.reserva,r.nombre from Cliente c join ClienteReserva cr on c.codCliente = cr.codCliente join Restaurante r on c.codRestaurante = r.codRestaurante ";
                string condicion = "Where ";

                if (!string.IsNullOrEmpty(_codigo))
                {
                    sql1 += condicion + "c.codCliente ='" + _codigo + "'";
                    condicion = " and ";
                }
                if (!string.IsNullOrEmpty(_nombre))
                {
                    sql1 += condicion + "c.nombre ='" + _nombre + "'";
                    condicion = " and ";
                }
                if (_reservo)
                {
                    sql1 += condicion + "c.fechaReserva='" + fechaR + "'";
                    condicion = " and ";

                }

                sql = sql1+condicion+ "c.codRestaurante='"+_codR+"' Order by c.codCliente";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }
        

        public void carga_info_cliente(string codC)
        {

            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombre = "Error";
            }
            else
            {
                sql = "Select c.nombre,c.fecha,c.montoPagado,c.reserva,c.barra,c.codRestaurante,c.horaEntrada,c.fechaReserva,cr.codMesa,cr.pedidoS1,cr.pedidoS2,cr.pedidoS3,cr.pedidoS4,cr.buffetS1,cr.buffetS2,cr.buffetS3,cr.buffetS4 " +
                    "from Cliente c join ClienteReserva cr on c.codCliente = cr.codCliente where c.codCliente = @cod";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, codC);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener el cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombre = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _fechaE = ds.Tables[0].Rows[0]["fecha"].ToString();
                        _monto = Convert.ToDouble(ds.Tables[0].Rows[0]["montoPagado"].ToString());
                        _reservo = Convert.ToBoolean(ds.Tables[0].Rows[0]["reserva"].ToString());
                        _barra = Convert.ToBoolean(ds.Tables[0].Rows[0]["barra"].ToString());
                        _codR = ds.Tables[0].Rows[0]["codRestaurante"].ToString();
                        _horaE = ds.Tables[0].Rows[0]["horaEntrada"].ToString();
                        _fechaR = ds.Tables[0].Rows[0]["fechaReserva"].ToString();
                        _codMesa = ds.Tables[0].Rows[0]["codMesa"].ToString();
                        _pedidos1 = ds.Tables[0].Rows[0]["pedidoS1"].ToString();
                        _pedidos2 = ds.Tables[0].Rows[0]["pedidoS2"].ToString();
                        _pedidos3 = ds.Tables[0].Rows[0]["pedidoS3"].ToString();
                        _pedidos4 = ds.Tables[0].Rows[0]["pedidoS4"].ToString();
                        _listabs1 = ds.Tables[0].Rows[0]["buffetS1"].ToString();
                        _listabs2 = ds.Tables[0].Rows[0]["buffetS2"].ToString();
                        _listabs3 = ds.Tables[0].Rows[0]["buffetS3"].ToString();
                        _listabs4 = ds.Tables[0].Rows[0]["buffetS4"].ToString();


                    }
                    else
                    {
                        _nombre = "Error";
                    }
                }

            }
        }

        public DataSet cargar_lista_especialidades()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select nombre,precio from Especiales Where codRestaurante ='" + _codR + "'";


                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar las especialidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }



        public DataSet cargar_lista_buffet()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select nombre,precio from Buffet";


                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public string cargar_nombre_mesa(int num)
        {
            string nombreMesa = "";
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select nombre from Mesas where numero=@num and codRestaurante=@codRest";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@num", SqlDbType.Int, num);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@codRest", SqlDbType.VarChar, codR);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener la mesa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        nombreMesa = ds.Tables[0].Rows[0]["nombre"].ToString();

                    }

                }

            }
            return nombreMesa;
        }

        public string cargar_cod_mesa(int num)
        {
            string cod = "";
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codigoMesa from Mesas where numero=@num and codRestaurante=@codRest";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@num", SqlDbType.Int, num);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@codRest", SqlDbType.VarChar, codR);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener la mesa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cod = ds.Tables[0].Rows[0]["codigoMesa"].ToString();


                    }

                }
                return cod;
            }
        }

        public string cargar_cod_mesa2()
        {
            string cod = "";
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codMesa from ClienteReserva where codCliente=@cod";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, _codigo);
                
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener la mesa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        cod = ds.Tables[0].Rows[0]["codMesa"].ToString();


                    }

                }
                return cod;
            }
        }

        public int cargar_num_mesa(string cod)
        {
            int num = -1;
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else
            {
                sql = "Select numero from Mesas where codigoMesa=@cod and codRestaurante=@codRest";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, cod);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@codRest", SqlDbType.VarChar, codR);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener el pais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        num = Convert.ToInt32(ds.Tables[0].Rows[0]["numero"].ToString());


                    }

                }
                return num;
            }
        }

        public int cargar_cant_sillas(int numM)
        {
            int num = -1;
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else
            {
                sql = "Select cantidadSillas from Mesas where numero=@numMesa and codRestaurante=@codRest";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@numMesa", SqlDbType.Int, numM);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@codRest", SqlDbType.VarChar, codR);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener el pais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        num = Convert.ToInt32(ds.Tables[0].Rows[0]["cantidadSillas"].ToString());


                    }

                }
                return num;
            }
        }
        #endregion

    }
}

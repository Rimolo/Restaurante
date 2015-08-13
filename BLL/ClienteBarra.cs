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
    public class ClientesBarra
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

        private string _fechaE;

        public string fechaE
        {
            get { return _fechaE; }
            set { _fechaE = value; }
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

        private int _numeroSilla;

        public int numeroSilla
        {
            get { return _numeroSilla; }
            set { _numeroSilla = value; }
        }

        private string _listaPedidos;

        public string listaPedidos
        {
            get { return _listaPedidos; }
            set { _listaPedidos = value; }
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
                    sql = "Insert into Cliente values(@cod,@nombre,convert(datetime,@fecha,103),@monto,0,1,@codR,@horaE,null,null,'Sin pagar',null)";


                }
                else if (accion.Equals("Editar"))
                {
                    sql = "Update Cliente SET" +
                        " duracion=@duracion" +
                        " where codCliente=@cod";
                }
                else
                {
                    sql = "Update Cliente SET" +
                        " estadoFactura='Pagado'," +
                        " horaSalida=@horaS," +
                        " duracion=@duracion" +
                        " where codCliente=@cod";
                }

                ParamStruct[] parametros = new ParamStruct[8];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fecha", SqlDbType.VarChar, _fechaE);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@monto", SqlDbType.Money, _monto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@codR", SqlDbType.VarChar, _codR);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@horaE", SqlDbType.VarChar, _horaE);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@horaS", SqlDbType.VarChar, _horaS);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@duracion", SqlDbType.VarChar, _duracion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@cod", SqlDbType.VarChar, _codigo);



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
                    if (!accion.Equals("Pagar"))
                    {
                        guardar_pedidos(accion);

                    }
                    return true;
                }


            }
        }

        public void guardar_pedidos(string _accion)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (_accion == "Insertar")
                {
                    sql = "Insert into ClienteBarra values(@cod,@pedido,@numSilla)";
                }
                else
                {
                    sql = "Update ClienteBarra SET" +
                        " detalleProducto=@pedido" +
                        " where codCliente=@cod";
                }
                ParamStruct[] parametros = new ParamStruct[3];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@pedido", SqlDbType.VarChar, _listaPedidos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@numSilla", SqlDbType.VarChar, _numeroSilla);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@cod", SqlDbType.VarChar, _codigo);



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

            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select c.codCliente,c.nombre,c.montoPagado,b.detalleProducto,c.fecha from Cliente c join ClienteBarra b on c.codCliente = b.codCliente Where c.estadoFactura ='Sin Pagar' Order by codCliente";

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
                string sql1 = "Select c.codCliente,c.nombre,c.montoPagado,b.detalleProducto,c.fecha from Cliente c join ClienteBarra b on c.codCliente = b.codCliente ";
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

                sql = sql1 + condicion + " c.estadoFactura ='Sin Pagar'  Order by c.codCliente";

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

        public bool eliminar_cliente(string codEmp)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Cliente where codCliente = @cod";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, codEmp);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                sql = "Select c.nombre,c.fecha,c.montoPagado,c.codRestaurante,c.horaEntrada,c.duracion,cb.numSilla,cb.detalleProducto " +
                    "from Cliente c join ClienteBarra cb on c.codCliente = cb.codCliente where c.codCliente = @cod";
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
                        _duracion = ds.Tables[0].Rows[0]["duracion"].ToString();
                        _codR = ds.Tables[0].Rows[0]["codRestaurante"].ToString();
                        _horaE = ds.Tables[0].Rows[0]["horaEntrada"].ToString();
                        _listaPedidos = ds.Tables[0].Rows[0]["detalleProducto"].ToString();
                        _numeroSilla = Convert.ToInt32(ds.Tables[0].Rows[0]["numSilla"].ToString());


                    }
                    else
                    {
                        _nombre = "Error";
                    }
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
                    MessageBox.Show(mensaje_error, "Error al cargar los Buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        #endregion

    }
}

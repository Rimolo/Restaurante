using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;


namespace BLL
{
    public class Pedidos
    {
        #region propiedades
        private int _num_pedido;

        public int num_pedido
        {
            get { return _num_pedido; }
            set { _num_pedido = value; }
        }
        private DateTime _fecha_pedido;

        public DateTime fecha_pedido
        {
            get { return _fecha_pedido; }
            set { _fecha_pedido = value; }
        }
        private decimal _total_pedido;

        public decimal total_pedido
        {
            get { return _total_pedido; }
            set { _total_pedido = value; }
        }
        private int _cod_proveedor;

        public int cod_proveedor
        {
            get { return _cod_proveedor; }
            set { _cod_proveedor = value; }
        }



        #endregion

        #region variables privadas
        SqlTransaction transaccion;
        SqlConnection conexion;
        string sql;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        DataTable datatable_pedidos;
        #endregion

        #region metodos

        public DataSet carga_lista_pedidos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "select p.Num_Pedido,p.Fecha_Pedido, p.Monto_Pedido, pr.nombre_proveedor" +
                      " from Pedidos p " + 
                      " JOIN Proveedores pr ON p.cod_proveedor = pr.cod_proveedor";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar la lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }


        }

        public DataSet carga_lista_productos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "select cod_producto,nombre_producto" +
                      " from Productos Order by cod_producto";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar la lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }


        }

        public DataSet carga_lista_proveedores()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select Cod_Proveedor,Nombre_Proveedor" +
                      " from Proveedores Order by Nombre_Proveedor";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al carga la lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public void crear_estructura_detalle()
        {
            datatable_pedidos = new DataTable();
            datatable_pedidos.Columns.Add("Codigo");
            datatable_pedidos.Columns.Add("Nombre");
            datatable_pedidos.Columns.Add("Cantidad");
            datatable_pedidos.Columns.Add("Precio");
            datatable_pedidos.Columns.Add("Subtotal");
        }

        public DataTable agregar_productos_aldetalle(int cod_prod, string nombre_prod, int cantidad, decimal precio, decimal subtotal)
        {
            DataRow fila = datatable_pedidos.NewRow();
            fila["Codigo"] = cod_prod;
            fila["Nombre"] = nombre_prod;
            fila["Cantidad"] = cantidad;
            fila["Precio"] = precio.ToString("n2");
            fila["Subtotal"] = subtotal.ToString("n2");
            datatable_pedidos.Rows.Add(fila);
            return datatable_pedidos;
        }

        public bool insertar_maestro_pedido()
        {

            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {

                sql = "Insert into Pedidos values(@num_pedido, @fecha, @monto, @cod_prov)";
                ParamStruct[] parametros = new ParamStruct[4];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@num_pedido", SqlDbType.Int, _num_pedido.ToString());
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fecha", SqlDbType.DateTime, _fecha_pedido.ToString());
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@monto", SqlDbType.Decimal, _total_pedido.ToString());
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@cod_prov", SqlDbType.Int, _cod_proveedor.ToString());
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);

                transaccion = conexion.BeginTransaction();
                cls_DAL.ejecuta_sqlcommand(ref transaccion, conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {                    
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    MessageBox.Show(mensaje_error, "Error al insertar el pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {

                    if (insertar_detalle_pedido())
                    {
                        transaccion.Commit();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                        return true;
                    }
                    else
                    {
                        transaccion.Rollback();
                        cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                        MessageBox.Show(mensaje_error, "Error al insertar el pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }


        public decimal calcula_total_pedido(decimal subtotal, decimal total)
        {
            decimal temptotal = total;
            temptotal += subtotal;
            return temptotal;
        }

        public int retorna_consecutivo_pedido()
        {
            int numero = 0;
            Random rd = new Random();
            numero = rd.Next(1000);
            return numero;
        }


        private bool insertar_detalle_pedido()
        {
            foreach (DataRow fila in datatable_pedidos.Rows)
            {
                sql = "Insert into Detalle_Pedido(Num_Pedido,Cod_Producto,Cantidad,Precio)values(@num_pedido,@cod_prod,@cantidad,@precio)";
                ParamStruct[] parametros = new ParamStruct[4];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@num_pedido", SqlDbType.Int, _num_pedido);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_prod", SqlDbType.Int, Convert.ToInt32(fila["Codigo"]));
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@cantidad", SqlDbType.Int, Convert.ToInt32(fila["Cantidad"]));
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@precio", SqlDbType.Decimal, Convert.ToDecimal(fila["Precio"]));                               
                cls_DAL.ejecuta_sqlcommand(ref transaccion, conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al insertar el pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    return false;
                }         
            }
            return true;
        }

        public DataTable eliminar_producto_deldetalle(int posicion)
        {
            datatable_pedidos.Rows[posicion].Delete();
            return datatable_pedidos;
        }

        public bool eliminar_detalle_pedido(int cod_pedido)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Detalle_Pedido where Num_Pedido IN (Select Num_Pedido From Pedidos where Num_Pedido = @cod)";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.Int, cod_pedido);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el detalle del pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool eliminar_pedido(int cod_pedido)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Pedidos where Num_Pedido = @cod";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.Int, cod_pedido);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion

    }
}

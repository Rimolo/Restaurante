using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Calientes
    {
        #region propiedades

        private string _codBebidaCal;

        public string codBebidaCal
        {
            get { return _codBebidaCal; }
            set { _codBebidaCal = value; }
        }
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _ingredientes;

        public string ingredientes
        {
            get { return _ingredientes; }
            set { _ingredientes = value; }
        }
        private decimal _precio;

        public decimal precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        private string _codRestaurante;

        public string codRestaurante
        {
            get { return _codRestaurante; }
            set { _codRestaurante = value; }
        }
        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private byte[] _imagen;

        public byte[] imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        #endregion

        #region variables privadas
        SqlConnection conexion;
        string sql;
        string mensaje_error;
        int numero_error;
        DataSet ds;
        #endregion

        #region metodos

        public DataSet carga_calientes_especificos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select Bc.codBebidaCal, Bc.nombre, Bc.precio, R.nombre as nomrest from BebidaCaliente Bc ";
                string condicion = "Where ";
                string join = "INNER JOIN Restaurante R ON Bc.codRestaurante = R.codRestaurante ";
                if (!string.IsNullOrEmpty(_codBebidaCal))
                {
                    sql1 += join + condicion + "Bc.codBebidaCaliente ='" + _codBebidaCal + "'";
                    condicion = "and ";
                }
                else
                {
                    if (!string.IsNullOrEmpty(_nombre))
                    {
                        sql1 += join + condicion + "Bc.nombre ='" + _nombre + "'";
                    }
                }
                sql = sql1 + " Order by Bc.codBebidaCal";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar las Bebidas Calientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public DataSet carga_Calientes()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select Bc.codBebidaCal, Bc.nombre, Bc.precio, R.nombre as nomrest from BebidaCaliente Bc INNER JOIN Restaurante R ON Bc.codRestaurante = R.codRestaurante Order by Bc.codBebidaCal";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar las Bebidas Calientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool guardar_Calientes(string accion,string Restaurante)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            string codRest = "";
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (accion.Equals("Insertar"))
                {
                    DataSet ds;
                    ds = retorna_Cod_Restaurante(Restaurante);
                    codRest = Convert.ToString(ds.Tables[0].Rows[0]["codRestaurante"]);
                    sql = "Insert into BebidaCaliente values(@codBebidaCal, @nombre, @ingredientes, @precio, @codRestaurante,  @descripcion, null)";
                }
                else
                {
                    sql = "Update BebidaCaliente SET" +
                        " nombre=@nombre," +
                        " descripcion=@descripcion," +
                        " precio=@precio," +
                        " ingredientes=@ingredientes," +
                        " imagen=null" +
                        " where codBebidaCal=@codBebidaCal";
                }
                ParamStruct[] parametros = new ParamStruct[6];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codBebidaCal", SqlDbType.VarChar, _codBebidaCal);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@ingredientes", SqlDbType.VarChar, _ingredientes);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@precio", SqlDbType.Money, _precio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@codRestaurante", SqlDbType.VarChar, codRest);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@descripcion", SqlDbType.VarChar, _descripcion);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public DataSet retorna_Cod_Restaurante(string nombre)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {                
                sql = "Select codRestaurante from Restaurante where nombre='"+ nombre +"'";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el codigo del Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool eliminar_Calientes(string codRestaurente)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from BebidaCaliente where codBebidaCal = @codBebidaCal";

                ParamStruct[] parametros = new ParamStruct[1];               
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codBebidaCal", SqlDbType.VarChar, codBebidaCal);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar la Bebida Caliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void carga_info_Calientes(string codCal)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombre = "Error";
            }
            else
            {
                sql = "Select Bc.codBebidaCal, Bc.nombre, Bc.ingredientes, Bc.precio, R.nombre as nomrest,  Bc.descripcion,  Bc.imagen" +
                      " from BebidaCaliente Bc INNER JOIN Restaurante R ON Bc.codRestaurante = R.codRestaurante where codBebidaCal = @codCal";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codCal", SqlDbType.VarChar, codCal);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener la informacion del producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombre = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {                        
                        _nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _ingredientes = ds.Tables[0].Rows[0]["ingredientes"].ToString();
                        _precio = Convert.ToDecimal(ds.Tables[0].Rows[0]["precio"]);
                        _descripcion = ds.Tables[0].Rows[0]["descripcion"].ToString();
                        _codRestaurante = ds.Tables[0].Rows[0]["nomrest"].ToString();
                        if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["imagen"].ToString()))
                        {
                            _imagen = (byte[])(ds.Tables[0].Rows[0]["imagen"]);
                        }
                        else
                        {
                            _imagen = null;
                        }

                    }
                    else
                    {
                        _nombre = "Error";
                    }
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
                sql = "Select valor From Consecutivos WHERE tipo='Bebidas Calientes'";

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
                sql = "Select prefijo From Consecutivos WHERE tipo='Bebidas Calientes'";

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

                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Bebidas Calientes'";

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

        public DataSet retorna_nombre_Restaurante(string nick)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {

                sql = "Select R.nombre" +
                      " from Restaurante R INNER JOIN Usuario U ON R.codRestaurante = U.codRest where U.nickname='" + nick + "'";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el codigo del Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public void guardar_imagen()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                sql = "Update BebidaCaliente set imagen=@img Where codBebidaCal='" + _codBebidaCal + "'";
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.guardar_imagen(conexion, sql, _imagen, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
            }
        }

        #endregion
    }
}

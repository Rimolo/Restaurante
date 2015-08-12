using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Especiales
    {
        #region propiedades

        private string _codEspeciales;

        public string codEspeciales
        {
            get { return _codEspeciales; }
            set { _codEspeciales = value; }
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
        private string _detalle;

        public string detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
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

        public DataSet carga_especiales_especificos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select codEspeciales, nombre, ingredientes, detalle, precio from Especiales ";
                string condicion = "Where ";
                if (!string.IsNullOrEmpty(_codEspeciales))
                {
                    sql1 += condicion + "codEspeciales ='" + _codEspeciales + "'";
                    condicion = "and ";
                }
                else
                {
                    if (!string.IsNullOrEmpty(_nombre))
                    {
                        sql1 += condicion + "nombre ='" + _nombre + "'";
                    }
                }
                sql = sql1 + " Order by codEspeciales";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar la informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public DataSet carga_Especiales()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codEspeciales, nombre, precio, detalle, ingredientes from Especiales Order by codEspeciales";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar la informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool guardar_Especiales(string accion, string nick)
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
                    ds = retorna_codigo_Restaurante(nick); ;
                    codRest = Convert.ToString(ds.Tables[0].Rows[0]["codRest"]);
                    sql = "Insert into Especiales values(@codEspeciales, @nombre, @ingredientes, @precio, @detalle, @CodRestaurante, null)";
                }
                else
                {
                    sql = "Update Especiales SET" +
                        " nombre=@nombre," +
                        " detalle=@detalle," +
                        " precio=@precio," +
                        " ingredientes=@ingredientes," +
                        " imagen=null" +
                        " where codEspeciales=@codEspeciales";
                }
                ParamStruct[] parametros = new ParamStruct[6];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codEspeciales", SqlDbType.VarChar, _codEspeciales);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@ingredientes", SqlDbType.VarChar, _ingredientes);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@precio", SqlDbType.Money, _precio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@detalle", SqlDbType.VarChar, _detalle);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@CodRestaurante", SqlDbType.VarChar, codRest);                
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el especial", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool eliminar_Especiales(string codRestaurente)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Especiales where codEspeciales = @codEspeciales";

                ParamStruct[] parametros = new ParamStruct[1];               
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codEspeciales", SqlDbType.VarChar, codEspeciales);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el especial", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void carga_info_Especiales(string codEsp)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombre = "Error";
            }
            else
            {
                sql = "Select codEspeciales, nombre, ingredientes, detalle, precio, imagen" +
                      " from Especiales where codEspeciales = @codEsp";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codEsp", SqlDbType.VarChar, codEsp);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener la informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombre = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {                        
                        _nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _ingredientes = ds.Tables[0].Rows[0]["ingredientes"].ToString();
                        _precio = Convert.ToDecimal(ds.Tables[0].Rows[0]["precio"]);
                        _detalle = ds.Tables[0].Rows[0]["detalle"].ToString();
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
                sql = "Select valor From Consecutivos WHERE tipo='Especiales'";

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
                sql = "Select prefijo From Consecutivos WHERE tipo='Especiales'";

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

                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Especiales'";

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

        public DataSet retorna_codigo_Restaurante(string nick)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codRest" +
                      " from Usuario where nickname='" + nick + "'";

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
                sql = "Update Especiales set imagen=@img Where codEspeciales='" + _codEspeciales + "'";
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.guardar_imagen(conexion, sql, _imagen, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
            }
        }

        #endregion
    }
}

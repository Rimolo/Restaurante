using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Consecutivos
    {
        #region propiedades

        private string _codConsecutivo;

        public string codConsecutivo
        {
            get { return _codConsecutivo; }
            set { _codConsecutivo = value; }
        }
        private string _tipo;

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private string _valor;

        public string valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        private string _prefijo;

        public string prefijo
        {
            get { return _prefijo; }
            set { _prefijo = value; }
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

        public DataSet carga_consecutivos_especificos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select codConsecutivo,tipo,descripcion,valor from Consecutivos ";
                string condicion = "Where ";
                if (!string.IsNullOrEmpty(_codConsecutivo))
                {
                    sql1 += condicion + "codConsecutivo ='" + _codConsecutivo + "'";
                    condicion = "and ";
                }
                else
                {
                    if (!string.IsNullOrEmpty(_tipo))
                    {
                        sql1 += condicion + "tipo ='" + _tipo + "'";
                    }
                }
                sql = sql1 + " Order by codConsecutivo";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los consecutivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public DataSet carga_consecutivos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codConsecutivo,tipo,descripcion,valor from Consecutivos Order by codConsecutivo";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los consecutivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool guardar_consecutivos(string accion)
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
                    sql = "Insert into Consecutivos values(@codConsecutivo, @tipo, @descripcion, @valor, @prefijo)";
                }
                else
                {
                    sql = "Update BebidaCaliente SET" +
                       " valor=@valor," +
                       " descripcion=@descripcion" +
                       " where codConsecutivo=@codConsecutivo";
                }

                ParamStruct[] parametros = new ParamStruct[5];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codConsecutivo", SqlDbType.VarChar, _codConsecutivo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@tipo", SqlDbType.VarChar, _tipo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@descripcion", SqlDbType.VarChar, _descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@valor", SqlDbType.NChar, _valor);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@prefijo", SqlDbType.VarChar, _prefijo);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el consecutivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool eliminar_consecutivos(string codConsecutivo)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Consecutivos where codConsecutivo = @codConsecutivo";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codConsecutivo", SqlDbType.VarChar, codConsecutivo);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el consecutivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void carga_info_Consecutivos(string codConsecutivo)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _tipo = "Error";
            }
            else
            {
                sql = "Select tipo,descripcion,valor,prefijo" +
                      " from Consecutivos where codConsecutivo='" + codConsecutivo + "'";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, codConsecutivo);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener el consecutivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _tipo = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _tipo = ds.Tables[0].Rows[0]["tipo"].ToString();
                        _descripcion = ds.Tables[0].Rows[0]["descripcion"].ToString();
                        _valor = ds.Tables[0].Rows[0]["valor"].ToString();
                        _prefijo = ds.Tables[0].Rows[0]["prefijo"].ToString();

                    }
                    else
                    {
                        _tipo = "Error";
                    }
                }

            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;
namespace BLL
{
    public class Login
    {
        #region propiedades
       
        private string _contraseña;

        public string contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

        private string _codR;

        public string codR
        {
            get { return _codR; }
            set { _codR = value; }
        }
        private bool _adminCuentas;
        public bool adminCuentas
        {
            get { return _adminCuentas; }
            set { _adminCuentas = value; }
        }

        private bool _adminSeguridad;
        public bool adminSeguridad
        {
            get { return _adminSeguridad; }
            set { _adminSeguridad = value; }
        }

        private bool _adminSistema;
        public bool adminSistema
        {
            get { return _adminSistema; }
            set { _adminSistema = value; }
        }

        private bool _adminRestaurante;
        public bool adminRestaurante
        {
            get { return _adminRestaurante; }
            set { _adminRestaurante = value; }
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
        public void carga_info_usuario(string usuario)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                sql = "Select nickname,codRest,adminCuentas,adminRestaurante,adminSistema,adminSeguridad,contraseña" +
                      " from Usuario where nickname=@cod";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, usuario);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Usuario/clave incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _contraseña = ds.Tables[0].Rows[0]["contraseña"].ToString();
                        _codR = ds.Tables[0].Rows[0]["codRest"].ToString();
                        _adminSeguridad = Convert.ToBoolean(ds.Tables[0].Rows[0]["adminSeguridad"].ToString());
                        _adminCuentas = Convert.ToBoolean(ds.Tables[0].Rows[0]["adminCuentas"].ToString());
                        _adminSistema = Convert.ToBoolean(ds.Tables[0].Rows[0]["adminSistema"].ToString());
                        _adminRestaurante = Convert.ToBoolean(Convert.ToBoolean(ds.Tables[0].Rows[0]["adminRestaurante"].ToString()));
                    }
                    
                }

            }
        }

        public string nombre_rest() {
            string nombreRest="";
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                sql = "Select nombre" +
                      " from Restaurante where codRestaurante='@cod'";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, _codR);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Usuario/clave incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        nombreRest = ds.Tables[0].Rows[0]["nombre"].ToString();
                        
                    }

                }
                
            }
            return nombreRest;
        }

        #endregion
    }
}

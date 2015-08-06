using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;
namespace BLL
{
    public class Usuarios
    {
        #region propiedades
        private string _codigo;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _codigoR;

        public string codigoR
        {
            get { return _codigoR; }
            set { _codigoR = value; }
        }
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apellido1;

        public string apellido1
        {
            get { return _apellido1; }
            set { _apellido1 = value; }
        }

        private string _apellido2;

        public string apellido2
        {
            get { return _apellido2; }
            set { _apellido2 = value; }
        }
        private string _login;

        public string login
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _contraseña;

        public string contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }
        private bool _adminRestaurante;
        public bool adminRestaurante
        {
            get { return _adminRestaurante; }
            set { _adminRestaurante = value; }
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

        private int _telfijo;
        public int telfijo
        {
            get { return _telfijo; }
            set { _telfijo = value; }
        }

        private int _celular;
        public int celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        private string _codPuesto;
        public string codPuesto
        {
            get { return _codPuesto; }
            set { _codPuesto = value; }
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

        public bool guardar_usuario(string accion)
        {
            _codPuesto = "PU-1";
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
                    sql = "Insert into Usuario values(@cod,@nombre,@apellido1,@apellido2,@nick,@clave,@adminRes,@adminCuen,@adminSis,@adminSeg,@puesto,@tel,@cel,@codR)";
                }
                else
                {
                    sql = "Update Usuario SET" +
                        " nombre=@nombre," +
                        " apellido1=@apellido1," +
                        " apellido2=@apellido2," +
                        " nickname=@nick," +
                        " contraseña=@clave," +
                        " adminRestaurante=@adminRes," +
                        " adminCuentas=@adminCuen," +
                        " adminSistema=@adminSis," +
                        " adminSeguridad=@adminSeg," +
                        " telefono1=@tel," +
                        " telefono2=@cel," +
                        " codPuesto=@puesto," +
                        " codRest=@codR"+
                        " where codUsuario=@cod";
                }
                ParamStruct[] parametros = new ParamStruct[14];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@apellido1", SqlDbType.VarChar, _apellido1);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@apellido2", SqlDbType.VarChar, _apellido2);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@nick", SqlDbType.VarChar, _login);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@clave", SqlDbType.VarChar, _contraseña);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@adminRes", SqlDbType.Bit, _adminRestaurante);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@adminCuen", SqlDbType.Bit, _adminCuentas);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@adminSis", SqlDbType.Bit, _adminSistema);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@adminSeg", SqlDbType.Bit, _adminSeguridad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@tel", SqlDbType.Int, _telfijo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 10, "@cel", SqlDbType.Int, _celular);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 11, "@puesto", SqlDbType.VarChar, _codPuesto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 12, "@cod", SqlDbType.VarChar, _codigo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 13, "@codR", SqlDbType.VarChar, _codigoR);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                sql = "Select valor From Consecutivos WHERE tipo='Usuarios'";

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
                sql = "Select prefijo From Consecutivos WHERE tipo='Usuarios'";

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

                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Usuarios'";

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

        public DataSet carga_usuarios()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select CodUsuario,nombre,apellido1,apellido2,telefono1,telefono2,nickname,adminSistema,adminSeguridad,adminRestaurante,adminCuentas from Usuario Order by CodUsuario";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        //Faltara revisar despues
        public DataSet carga_usuarios_especificos(string privilegio)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select CodUsuario,nombre,apellido1,apellido2,telefono1,telefono2,nickname,adminSistema,adminSeguridad,adminRestaurante,adminCuentas from Usuario ";
                string condicion = "Where ";
               
                if (!string.IsNullOrEmpty(_codigo))
                {
                    sql1 += condicion + "CodUsuario ='" + _codigo + "'";
                    condicion = " and ";
                }
                if (!string.IsNullOrEmpty(_nombre))
                {
                    sql1 += condicion + "nombre ='" + _nombre + "'";
                    condicion = " and ";
                }
                if (!string.IsNullOrEmpty(_login))
                {
                    sql1 += condicion + "nickname ='" + _login + "'";
                    condicion = " and ";
                }
                if (privilegio != "ninguno")
                {
                    if (privilegio.Equals("Administrador de Cuentas")) {
                        sql1 += condicion + "adminCuentas=1";
                    }
                    if (privilegio.Equals("Administrador del Sistema"))
                    {
                        sql1 += condicion + "adminSistema=1";
                    }
                    if (privilegio.Equals("Administrador del Restaurante"))
                    {
                        sql1 += condicion + "adminRestaurante=1";
                    }
                    if (privilegio.Equals("Administrador de Seguridad"))
                    {
                        sql1 += condicion + "adminSeguridad=1";
                    }
                    
                    
                }
                sql = sql1 + " Order by CodUsuario";
                
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool eliminar_usuario(string cod_usuario)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Usuario where codUsuario = @codUsuario";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codUsuario", SqlDbType.VarChar, cod_usuario);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        

        public void carga_info_usuario(string codUsuario)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombre = "Error";
            }
            else
            {
                sql = "Select nombre,apellido1,apellido2,nickname,telefono1,telefono2,adminCuentas,adminRestaurante,adminSistema,adminSeguridad,contraseña" +
                      " from Usuario where codUsuario=@cod";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, codUsuario);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener el rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombre = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _contraseña = ds.Tables[0].Rows[0]["contraseña"].ToString();
                        _nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _apellido1 = ds.Tables[0].Rows[0]["apellido1"].ToString(); 
                        _apellido2 = ds.Tables[0].Rows[0]["apellido2"].ToString(); 
                        _login = ds.Tables[0].Rows[0]["nickname"].ToString();
                        _telfijo = Convert.ToInt32(ds.Tables[0].Rows[0]["telefono1"].ToString());
                        _celular = Convert.ToInt32(ds.Tables[0].Rows[0]["telefono2"].ToString());
                        _adminSeguridad = Convert.ToBoolean(ds.Tables[0].Rows[0]["adminSeguridad"].ToString());
                        _adminCuentas = Convert.ToBoolean(ds.Tables[0].Rows[0]["adminCuentas"].ToString());
                        _adminSistema= Convert.ToBoolean(ds.Tables[0].Rows[0]["adminSistema"].ToString());
                        _adminRestaurante = Convert.ToBoolean(Convert.ToBoolean(ds.Tables[0].Rows[0]["adminRestaurante"].ToString()));
                    }
                    else
                    {
                        _nombre = "Error";
                    }
                }

            }
        }

        public string cargar_cod_res(string nombreR)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombre = "Error";
            }
            else
            {
                sql = "Select codRestaurante" +
                      " from Restaurante where nombre=@nombre";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, nombreR);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener el restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombre = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _codigoR = ds.Tables[0].Rows[0]["codRestaurante"].ToString();
                                               
                    }
                    else
                    {
                        _nombre = "Error";
                    }
                }
                                
            }
            return _codigoR;
        }
        #endregion
    }
}


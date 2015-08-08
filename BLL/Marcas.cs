using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Marcas
    {
        #region propiedades
        private string _codMarca;

        public string codMarca
        {
            get { return _codMarca; }
            set { _codMarca = value; }
        }
        private string _nombreMarca;

        public string nombreMarca
        {
            get { return _nombreMarca; }
            set { _nombreMarca = value; }
        }
        private string _codPais;

        public string codPais
        {
            get { return _codPais; }
            set { _codPais = value; }
        }       
        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }        
        private string _cedJuridica;

        public string cedJuridica
        {
            get { return _cedJuridica; }
            set { _cedJuridica = value; }
        }
        private string _nombreEmp;

        public string nombreEmp
        {
            get { return _nombreEmp; }
            set { _nombreEmp = value; }
        }        
        private string _detalleEmpresa;

        public string detalleEmpresa
        {
            get { return _detalleEmpresa; }
            set { _detalleEmpresa = value; }
        }
        private string _telefono;

        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private byte[] _imagen;

        public byte[] imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }
        private byte[] _logo;

        public byte[] logo
        {
            get { return _logo; }
            set { _logo = value; }
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

        public DataSet carga_Marcas_especificos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select M.codMarca, M.nombre, M.Descripcion, P.nombre as nomPais, M.nombEmp, M.TelefonoEmp from Marcas M";
                string condicion = "Where ";
                string join = "INNER JOIN Pais P ON M.codPais = P.codigoPais";
                if (!string.IsNullOrEmpty(_codMarca))
                {
                    sql1 += join + condicion + "M.codMarca ='" + _codMarca + "'";
                    condicion = "and ";
                }
                else
                {
                    if (!string.IsNullOrEmpty(_nombreMarca))
                    {
                        sql1 += join + condicion + "M.nombre ='" + _nombreMarca + "'";
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(_nombreEmp))
                        {
                            sql1 += join + condicion + "M.nombEmp ='" + _nombreEmp + "'";
                        }
                        if (!string.IsNullOrEmpty(_codPais))
                        {
                            sql1 += join + condicion + "P.nombre ='" + _codPais + "'";
                            condicion = "and ";
                        }
                    }
                }
                
               
                sql = sql1 + " Order by codMarca";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar las Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public DataSet carga_Marca()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select M.codMarca, M.nombre, M.Descripcion, P.nombre as nomPais, M.nombEmp, M.TelefonoEmp from Marcas M INNER JOIN Pais P ON M.codPais = P.codigoPais Order by M.codMarca";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar las Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool guardar_Marcas(string accion, string Restaurante)
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
                    ds = retorna_Cod_Pais(Restaurante);
                    codRest = Convert.ToString(ds.Tables[0].Rows[0]["codRestaurante"]);
                    sql = "Insert into Marcas values(@codMarca, @nombre, @codPais, @descripcion, @nombEmp, @detalleEmp, @telefonoEmp, @cedJuridicaEmp, null, null)";
                }
                else
                {
                    sql = "Update Marcas SET" +
                        " nombre=@nombre," +
                        " descripcion=@descripcion," +
                        " codPais=@codPais," +
                        " nombEmp=@nombEmp," +
                        " detalleEmp=@detalleEmp," +
                        " telefonoEmp=@telefonoEmp," +
                        " cedJuridicaEmp=@cedJuridicaEmp" +
                        " where codMarca=@codMarca";
                }
                ParamStruct[] parametros = new ParamStruct[8];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codMarca", SqlDbType.VarChar, _codMarca);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, _nombreMarca);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@codPais", SqlDbType.VarChar, _codPais);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@descripcion", SqlDbType.VarChar, _descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@nombEmp", SqlDbType.VarChar, _nombreEmp);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@detalleEmp", SqlDbType.VarChar, _detalleEmpresa);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@telefonoEmp", SqlDbType.VarChar, _telefono);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@cedJuridicaEmp", SqlDbType.VarChar, _cedJuridica);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar la Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public DataSet retorna_Cod_Pais(string nacionalidad)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {                
                sql = "Select codPais from Pais where nombre='"+ nacionalidad + "'";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el codigo del Pais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool eliminar_Marca(string codMarca)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Marcas where codMarca = @codMarca";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codMarca", SqlDbType.VarChar, codMarca);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar la Marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void carga_info_Marca(string codMar)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombreMarca = "Error";
            }
            else
            {
                sql = "Select M.nombre, P.nombre as nomPais, M.descripcion, M.nombEmp, M.detalleEmp, M.telefonoEmp, M.cedJuridicaEmp, M.logoEmpresa, M.imagenMarca" +
                      " from Marcas M INNER JOIN Pais P ON M.codPais = P.codidoPais where codMarca=@codMarca";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codMarca", SqlDbType.VarChar, codMar);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener las Marcas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombreMarca = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {                        
                        _nombreMarca = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _codPais = ds.Tables[0].Rows[0]["nomPais"].ToString();
                        _descripcion = ds.Tables[0].Rows[0]["descripcion"].ToString();
                        _nombreEmp = ds.Tables[0].Rows[0]["nombEmp"].ToString();
                        _detalleEmpresa = ds.Tables[0].Rows[0]["detalleEmp"].ToString();
                        _telefono = ds.Tables[0].Rows[0]["telefonoEmp"].ToString();
                        _cedJuridica = ds.Tables[0].Rows[0]["cedJuridicaEmp"].ToString();                        
                        // _imagen = (byte[])(ds.Tables[0].Rows[0]["logoEmpresa"]);
                        // _imagen = (byte[])(ds.Tables[0].Rows[0]["imagenMarca"]);

                    }
                    else
                    {
                        _nombreMarca = "Error";
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
                sql = "Select valor From Consecutivos WHERE tipo='Marcas'";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error cargar el consecutivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                sql = "Select prefijo From Consecutivos WHERE tipo='Marcas'";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);

                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error cargar el consecutivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Marcas'";

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

        /*public DataSet retorna_nombre_Pais(string nick)
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
        }*/

        public void guardar_imagen()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                sql = "Update Marcas set imagenMarca=@img, logoEmpresa=@img2 Where codMarca='" + _codMarca + "'";
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.guardar_imagen(conexion, sql, _imagen, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
            }
        }

        #endregion
    }
}

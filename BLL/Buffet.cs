using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Buffet
    {
        #region propiedades

        private string _codBuffet;

        public string codBuffet
        {
            get { return _codBuffet; }
            set { _codBuffet = value; }
        }
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _tipo;

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private decimal _precio;

        public decimal precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        private string _codMedida;

        public string codMedida
        {
            get { return _codMedida; }
            set { _codMedida = value; }
        }
        private string _codRestaurante;

        public string codRestaurante
        {
            get { return _codRestaurante; }
            set { _codRestaurante = value; }
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

        public DataSet carga_Buffet_especificos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select B.codBuffet, B.nombre, B.precio, B.tipo, UM.unidadMedida as nomMedida from Buffet B ";
                string condicion = "Where ";
                string join = "INNER JOIN UnidadesMedida UM ON B.CodMedida = UM.codMedida ";
                if (!string.IsNullOrEmpty(_codBuffet))
                {
                    sql1 += join + condicion + "B.codBuffet ='" + _codBuffet + "'";
                    condicion = "and ";
                }
                else
                {
                    if (!string.IsNullOrEmpty(_nombre))
                    {
                        sql1 += join +  condicion + "B.nombre ='" + _nombre + "'";
                        condicion = "and ";
                    }                    
                }
                sql = sql1 + " Order by B.codBuffet";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar la comida buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public DataSet carga_Buffet()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select B.codBuffet, B.nombre, B.precio, B.tipo, UM.unidadMedida as nomMedida from Buffet B INNER JOIN UnidadesMedida UM ON B.CodMedida = UM.codMedida Order by B.codBuffet";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar las comida buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool guardar_Buffet(string accion, string codigo)
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
                    ds = retorna_codigo_Restaurante(codigo);
                    codRest = Convert.ToString(ds.Tables[0].Rows[0]["codRest"]);
                    sql = "Insert into Buffet values(@codBuffet, @nombre, @precio, @tipo, @CodMedida, @codRest, null)";
                }
                else
                {
                    sql = "Update Buffet SET" +
                        " nombre=@nombre," +
                        " precio=@precio," +
                        " tipo=@tipo," +
                        " CodMedida=@CodMedida," +                       
                        " imagen=null" +
                        " where codBuffet=@codBuffet";
                }
                ParamStruct[] parametros = new ParamStruct[6];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codBuffet", SqlDbType.VarChar, _codBuffet);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@precio", SqlDbType.Money, _precio);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@tipo", SqlDbType.VarChar, _tipo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@CodMedida", SqlDbType.VarChar, _codMedida);                
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@codRest", SqlDbType.VarChar, codRest);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool eliminar_Buffet(string codBuf)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Buffet where codBuffet = @codBuffet";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codBuffet", SqlDbType.VarChar, codBuf);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void carga_info_Buffet(string codBuf)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombre = "Error";
            }
            else
            {
                sql = "Select B.nombre, B.precio, B.tipo, UM.unidadMedida as nomMedida, B.imagen" +
                      " from Buffet B INNER JOIN UnidadesMedida UM ON B.CodMedida = UM.codMedida where codBuffet=@codBuf";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codBuf", SqlDbType.VarChar, codBuf);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener la informacion del buffet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombre = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {                        
                        _nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _tipo = ds.Tables[0].Rows[0]["tipo"].ToString();
                        _codMedida = ds.Tables[0].Rows[0]["CodMedida"].ToString();
                        _precio = Convert.ToDecimal(ds.Tables[0].Rows[0]["precio"]);                                         
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
                sql = "Select valor From Consecutivos WHERE tipo='Buffet'";

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
                sql = "Select prefijo From Consecutivos WHERE tipo='Buffet'";

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

                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Buffet'";

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

        public DataSet cargar_lista_unidadMedida()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codMedida,unidadMedida from UnidadesMedida Order by unidadMedida";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar las unidades de medida", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                sql = "Update Buffeta set imagen=@img Where codBuffet='" + _codBuffet + "'";
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.guardar_imagen(conexion, sql, _imagen, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
            }
        }

        #endregion
    }
}

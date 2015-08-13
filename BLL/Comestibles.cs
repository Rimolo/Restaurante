using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Comestibles
    {
        #region propiedades

        private string _codComestible;

        public string codComestible
        {
            get { return _codComestible; }
            set { _codComestible = value; }
        }
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private int _cantidad;

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        private string _tipo;

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private string _codRestaurante;

        public string codRestaurante
        {
            get { return _codRestaurante; }
            set { _codRestaurante = value; }
        }
        private string _codMarca;

        public string codMarca
        {
            get { return _codMarca; }
            set { _codMarca = value; }
        }
        private string _clase;

        public string clase
        {
            get { return _clase; }
            set { _clase = value; }
        }
        private string _linea;

        public string linea
        {
            get { return _linea; }
            set { _linea = value; }
        }
        private string _codMedida;

        public string codMedida
        {
            get { return _codMedida; }
            set { _codMedida = value; }
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

        public DataSet carga_Comestibles_especificos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select C.codComestible, C.nombre, C.cantidad, R.nombre as nomrest from Comestibles C ";
                string condicion = "Where ";
                string join = "INNER JOIN Restaurante R ON C.codRestaurante = R.codRestaurante ";
                if (!string.IsNullOrEmpty(_codComestible))
                {
                    sql1 += join + condicion + "C.codComestible ='" + _codComestible + "'";
                    condicion = "and ";
                }
                else
                {
                    if (!string.IsNullOrEmpty(_nombre))
                    {
                        sql1 += join +  condicion + "C.nombre ='" + _nombre + "'";
                        condicion = "and ";
                    }
                    if (!string.IsNullOrEmpty(_codRestaurante))
                    {
                        sql1 += join + condicion + "R.nombre ='" + _codRestaurante + "'";
                        condicion = "and ";
                    }
                }
                sql = sql1 + " Order by C.codComestible";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los comestibles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public DataSet carga_Comestibles()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select C.codComestible, C.nombre, C.cantidad, R.nombre as nomrest from Comestibles C INNER JOIN Restaurante R ON C.codRestaurante = R.codRestaurante Order by codComestible";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los comestibles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool guardar_Comestibles(string accion)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
           // string codRest = "";
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (accion.Equals("Insertar"))
                {
                   /* DataSet ds;
                    ds = retorna_Cod_Restaurante(Restaurante);
                    codRest = Convert.ToString(ds.Tables[0].Rows[0]["codRestaurante"]);*/
                    sql = "Insert into Comestibles values(@codComestible, @nombre, @cantidad, @tipo, @codRestaurante, @codMarca, @clase, @linea, @codMedida)";
                }
                else
                {
                    sql = "Update Comestibles SET" +
                        " nombre=@nombre," +
                        " cantidad=@cantidad," +
                        " tipo=@tipo," +
                        " codRestaurante=@codRestaurante," +
                        " codMarca=@codMarca," +
                        " clase=@clase," +
                        " linea=@linea," +
                        " codMedida=@codMedida" +
                        " where codComestible=@codComestible";
                }
                ParamStruct[] parametros = new ParamStruct[9];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codComestible", SqlDbType.VarChar, _codComestible);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@cantidad", SqlDbType.Int, _cantidad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@tipo", SqlDbType.VarChar, _tipo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@codRestaurante", SqlDbType.VarChar, _codRestaurante);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@codMarca", SqlDbType.VarChar, _codMarca);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@clase", SqlDbType.VarChar, _clase);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@linea", SqlDbType.VarChar, _linea);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@codMedida", SqlDbType.VarChar, _codMedida);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el comestible", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool eliminar_Comestibles(string codCom)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Comestibles where codComestible = @codComestible";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codComestible", SqlDbType.VarChar, codCom);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el comestible", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void carga_info_Comestibles(string codCom)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombre = "Error";
            }
            else
            {
                sql = "Select C.nombre, M.nombre as nomMarca, UM.unidadMedida as nomMedida, R.nombre as nomrest, C.tipo, C.cantidad, C.clase, C.linea" +
                      " from Comestibles C INNER JOIN Restaurante R ON C.codRestaurante = R.codRestaurante INNER JOIN UnidadesMedida UM ON C.codMedida = UM.codMedida INNER JOIN Marcas M ON C.codMarca = M.codMarca where C.codComestible = @codCom";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codCom", SqlDbType.VarChar, codCom);
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
                        _codMarca = ds.Tables[0].Rows[0]["nomMarca"].ToString();
                        _codMedida = ds.Tables[0].Rows[0]["nomMedida"].ToString();
                        _linea = ds.Tables[0].Rows[0]["linea"].ToString();                       
                        _codRestaurante= ds.Tables[0].Rows[0]["nomrest"].ToString();
                        _cantidad = Convert.ToInt32(ds.Tables[0].Rows[0]["cantidad"]);
                        _tipo = ds.Tables[0].Rows[0]["tipo"].ToString();
                        _clase = ds.Tables[0].Rows[0]["clase"].ToString();

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
                sql = "Select valor From Consecutivos WHERE tipo='Comestibles'";

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
                sql = "Select prefijo From Consecutivos WHERE tipo='Comestibles'";

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
                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Comestibles'";

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
       
        public DataSet cargar_lista_restaurantes()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codRestaurante,nombre from Restaurante";


                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los restaurantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public DataSet cargar_lista_Marcas()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codMarca,nombre from Marcas Order by nombre";

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

        #endregion
    }
}

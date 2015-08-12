using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Vinos
    {
        #region propiedades

        private string _codVino;

        public string codVino
        {
            get { return _codVino; }
            set { _codVino = value; }
        }
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _codMarca;

        public string codMarca
        {
            get { return _codMarca; }
            set { _codMarca = value; }
        }
        private decimal _precioU;

        public decimal precioU
        {
            get { return _precioU; }
            set { _precioU = value; }
        }
        private decimal _precioB;

        public decimal precioB
        {
            get { return _precioB; }
            set { _precioB = value; }
        }
        private string _codPais;

        public string codPais
        {
            get { return _codPais; }
            set { _codPais = value; }
        }
        private int _cosecha;

        public int cosecha
        {
            get { return _cosecha; }
            set { _cosecha = value; }
        }
        private string _codRestaurante;

        public string codRestaurante
        {
            get { return _codRestaurante; }
            set { _codRestaurante = value; }
        }
        private int _cantidad;

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
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

        public DataSet carga_Vinos_especificos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select V.codVino, V.nombre, V.precioUnitario, V.precioBotella, P.nombre as nomPais, V.añoCosecha from Vinos V ";
                string condicion = "Where ";
                string join2 = "INNER JOIN Restaurante R ON V.codRestaurante = R.codRestaurante INNER JOIN Pais P ON V.codPais = P.codigoPais ";
                string join = "INNER JOIN Pais P ON V.codPais = P.codigoPais ";
                if (!string.IsNullOrEmpty(_codVino))
                {
                    sql1 += join + condicion + "V.codVino ='" + _codVino + "'";                   
                }
                else
                {
                    if (!string.IsNullOrEmpty(_nombre))
                    {
                        sql1 += join + condicion + "V.nombre ='" + _nombre + "'";
                        condicion = "and ";
                    }
                   
                    if (_cosecha!=0)
                    {
                        sql1 += join + condicion + "V.añoCosecha ='" + _cosecha + "'";
                        condicion = "and ";
                    }
                    if (_precioU != 0)
                    {
                        sql1 += join + condicion + "V.precioUnitario ='" + _precioU + "'";
                        condicion = "and ";
                    }
                    if (_precioB != 0)
                    {
                        sql1 += join + condicion + "V.precioBotella ='" + _precioB + "'";
                        condicion = "and ";
                    }
                    if (!string.IsNullOrEmpty(_codRestaurante))
                    {
                        sql1 += join2 + condicion + "R.nombre ='" + _codRestaurante + "'";
                        condicion = "and ";
                    }
                }
                if (!string.IsNullOrEmpty(_codPais))
                {
                    sql1 += join + condicion + "P.nombre ='" + _codPais + "'";
                    condicion = "and ";
                }
                else {
                    sql1 += join;
                }

                sql = sql1 + " Order by V.codVino";
                
                    

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error+"  "+ sql, "Error al cargar los Vinos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    MessageBox.Show(sql, "Error al cargar los Vinos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    return ds;
                }
            }
        }

        public DataSet carga_Vinos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select V.codVino, V.nombre, V.precioUnitario, V.precioBotella, P.nombre as nomPais, V.añoCosecha from Vinos V INNER JOIN Pais P ON P.codigoPais = V.codPais Order by codVino";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los vinos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool guardar_Vinos(string accion, string Restaurante)
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
                    sql = "Insert into Vinos values(@codVino, @nombre, @codMarca, @precioU, @precioB, @codPais, @cosecha, @codRestaurante, @cantidad, @descripcion, null)";
                }
                else
                {
                    sql = "Update Vinos SET" +
                        " nombre=@nombre," +
                        " codMarca=@codMarca," +
                        " precioUnitario=@precioU," +
                        " precioBotella=@precioB," +
                        " codPais=@codPais," +
                        " añoCosecha=@cosecha," +
                        " cantidad=@cantidad," +
                        " descripcion=@descripcion," +
                        " imagen=null" +
                        " where codVino=@codVino";
                }
                ParamStruct[] parametros = new ParamStruct[10];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codVino", SqlDbType.VarChar, _codVino);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@codMarca", SqlDbType.VarChar, _codMarca);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@precioU", SqlDbType.Money, _precioU);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@precioB", SqlDbType.Money, _precioB);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@codPais", SqlDbType.VarChar, _codPais);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@cosecha", SqlDbType.Int, _cosecha);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@codRestaurante", SqlDbType.VarChar, codRest);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@cantidad", SqlDbType.Int, _cantidad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@descripcion", SqlDbType.VarChar, _descripcion);
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

        public bool eliminar_Vinos(string codVi)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Vinos where codVino = @codVino";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codVino", SqlDbType.VarChar, codVi);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el vino", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void carga_info_Vinos(string codVi)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombre = "Error";
            }
            else
            {
                sql = "Select V.nombre, M.nombre as nomMarca, P.nombre as nomPais, R.nombre as nomrest, V.precioUnitario,  V.precioBotella, V.añoCosecha, V.cantidad, V.descripcion, V.imagen" +
                      " from Vinos V INNER JOIN Restaurante R ON V.codRestaurante = R.codRestaurante INNER JOIN Pais P ON V.codPais = P.codigoPais INNER JOIN Marcas M ON V.codMarca = M.codMarca where codVino=@codVi";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codVi", SqlDbType.VarChar, codVi);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error+"   "+sql, "Error al obtener la informacion del producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombre = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {                        
                        _nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _codMarca = ds.Tables[0].Rows[0]["nomMarca"].ToString();
                        _codPais = ds.Tables[0].Rows[0]["nomPais"].ToString();
                        _precioU = Convert.ToDecimal(ds.Tables[0].Rows[0]["precioUnitario"]);
                        _precioB = Convert.ToDecimal(ds.Tables[0].Rows[0]["precioBotella"]);
                        _cosecha = Convert.ToInt32(ds.Tables[0].Rows[0]["añoCosecha"]);
                        _codRestaurante = ds.Tables[0].Rows[0]["nomrest"].ToString();
                        _cantidad = Convert.ToInt32(ds.Tables[0].Rows[0]["cantidad"]);
                        _descripcion = ds.Tables[0].Rows[0]["descripcion"].ToString();
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
                sql = "Select valor From Consecutivos WHERE tipo='Vinos'";

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
                sql = "Select prefijo From Consecutivos WHERE tipo='Vinos'";

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

                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Vinos'";

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

        public DataSet cargar_lista_nacionalidad()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codigoPais,nombre from Pais Order by nombre";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los paises", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void guardar_imagen()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                sql = "Update Vinos set imagen=@img Where codVino='" + _codVino + "'";
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.guardar_imagen(conexion, sql, _imagen, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
            }
        }

        #endregion
    }
}

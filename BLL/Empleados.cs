using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Empleados
    {
         #region propiedades
        private string _codigo;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private byte[] _foto;

        public byte[] foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        private string _cedula;

        public string cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
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

        private int _telefono1;

        public int telefono1
        {
            get { return _telefono1; }
            set { _telefono1 = value; }
        }

        private int _telefono2;

        public int telefono2
        {
            get { return _telefono2; }
            set { _telefono2 = value; }
        }

        private string _codPuesto;

        public string codPuesto
        {
            get { return _codPuesto; }
            set { _codPuesto = value; }
        }
        private string _codNacionalidad;

        public string codNacionalidad
        {
            get { return _codNacionalidad; }
            set { _codNacionalidad = value; }
        }
        private string _codRest;

        public string codRest
        {
            get { return _codRest; }
            set { _codRest = value; }
        }
        private string _codUsuario;

        public string codUsuario
        {
            get { return _codUsuario; }
            set { _codUsuario = value; }
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
        public bool guardar_empleado(string accion)
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
                    sql = "Insert into Empleados values(@cod,@ced,@nombre,@apellido1,@apellido2,@telefono1,@telefono2,null,@codNac,@codRest,@codPuesto,null)";
                }
                else
                {
                    sql = "Update Empleados SET" +
                        " nombre=@nombre," +
                        " cedula=@ced," +
                        " apellido1=@apellido1," +
                        " apellido2=@apellido2," +
                        " telefono1=@telefono1," +
                        " telefono2=@telefono2," +
                        " codNacionalidad=@codNac," +
                        " CodRestaurante=@codRest," +
                        " codPuesto=@codPuesto,"+
                        " foto=null" +
                        " where codEmpleado=@cod";
                }
                ParamStruct[] parametros = new ParamStruct[10];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ced", SqlDbType.VarChar, _cedula);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@apellido1", SqlDbType.VarChar, _apellido1);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@apellido2", SqlDbType.VarChar, _apellido2);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@telefono1", SqlDbType.Int, _telefono1);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@telefono2", SqlDbType.Int, _telefono2);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@codNac", SqlDbType.VarChar, _codNacionalidad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@codRest", SqlDbType.VarChar, _codRest);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@codPuesto", SqlDbType.VarChar, _codPuesto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@cod", SqlDbType.VarChar, _codigo);



                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void guardar_imagen()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                sql = "Update Empleado set foto=@img Where codEmpleado='"+_codigo+"'";
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.guardar_imagen(conexion, sql,_foto,ref mensaje_error,ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
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
                sql = "Select valor From Consecutivos WHERE tipo='Empleados'";

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
                sql = "Select prefijo From Consecutivos WHERE tipo='Empleados'";

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

                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Empleados'";

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

        public DataSet carga_empleados()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codEmpleado,cedula,nombre,apellido1,apellido2 from Empleados Order by codEmpleado";

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

        //Faltara revisar despues
        public DataSet carga_empleado_especifico()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select codEmpleado,cedula,nombre,apellido1,apellido2 from Empleados ";
                string condicion = "Where ";

                if (!string.IsNullOrEmpty(_codigo))
                {
                    sql1 += condicion + "codEmpleado ='" + _codigo + "'";
                    condicion = " and ";
                }
                if (!string.IsNullOrEmpty(_nombre))
                {
                    sql1 += condicion + "nombre ='" + _nombre + "'";

                }

                sql = sql1 + " Order by codEmpleado";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool eliminar_empleado(string codEmp)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Empleados where codEmpleado = @cod";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, codEmp);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el pais", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
     

        public void carga_info_empleado(string cod_pais)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombre = "Error";
            }
            else
            {
                sql = "Select e.nombre,e.apellido1,e.apellido2,e.cedula,e.telefono1,e.telefono2,p.nombre as codP,pp.nombre as codPa,r.nombre as codRest" +
                      " from Empleados e join Puestos p on e.codPuesto = p.codPuesto join Pais pp on e.codNacionalidad = pp.codigoPais join Restaurante r on e.CodRestaurante = r.codRestaurante where e.codEmpleado=@cod";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, cod_pais);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener el pais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombre = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                        _cedula = ds.Tables[0].Rows[0]["cedula"].ToString();
                        _apellido1 = ds.Tables[0].Rows[0]["apellido1"].ToString();
                        _apellido2 = ds.Tables[0].Rows[0]["apellido2"].ToString();
                        _telefono1 = Convert.ToInt32(ds.Tables[0].Rows[0]["telefono1"].ToString());
                        _telefono2 = Convert.ToInt32(ds.Tables[0].Rows[0]["telefono2"].ToString());
                        _codNacionalidad = ds.Tables[0].Rows[0]["codPa"].ToString();
                        _codPuesto = ds.Tables[0].Rows[0]["codP"].ToString();
                        _codRest = ds.Tables[0].Rows[0]["codRest"].ToString();
                        _foto = (byte[])(ds.Tables[0].Rows[0]["foto"]);
                       
                    }
                    else
                    {
                        _nombre = "Error";
                    }
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

        public DataSet cargar_lista_puestos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codPuesto,nombre from Puestos";
                


                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los puestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public DataSet cargar_lista_paises()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codigoPais,nombre from Pais";


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
        #endregion

    }
}

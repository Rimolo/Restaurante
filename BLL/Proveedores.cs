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
    public class Proveedores
    {
         #region propiedades
        private string _codigo;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _nombreP;

        public string nombreP
        {
            get { return _nombreP; }
            set { _nombreP = value; }
        }
        private string _nombreC;

        public string nombreC
        {
            get { return _nombreC; }
            set { _nombreC = value; }
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

        private string _telefono;

        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _oficina;

        public string oficina
        {
            get { return _oficina; }
            set { _oficina = value; }
        }
        private string _celular;

        public string celular
        {
            get { return _celular; }
            set { _celular = value; }
        }
        private string _fax;

        public string fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        private string _fecha;

        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private string _correo;

        public string correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        private string _direccionP;

        public string direccionP
        {
            get { return _direccionP; }
            set { _direccionP = value; }
        }
        private string _direccionC;

        public string direccionC
        {
            get { return _direccionC; }
            set { _direccionC = value; }
        }
        private string _codRest;

        public string codRest
        {
            get { return _codRest; }
            set { _codRest = value; }
        }

        private string _listaPedidos;

        public string listaPedidos
        {
            get { return _listaPedidos; }
            set { _listaPedidos = value; }
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
        public bool guardar_Proveedor(string accion)
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
                    sql = "Insert into Proveedores values(@cod, @nombreP, @ced, @fecha, @correo, @direccionP, @telefono, @celular, @fax, @apellido1, @apellido2, @nombreC, @direccionC, @oficina, null)";
                }
                else
                {
                    sql = "Update Proveedores SET" +
                        " nombreProveedor=@nombreP," +
                        " cedula=@ced," +
                        " fechaIngreso=@fecha," +
                        " correo=@correo," +
                        " direccionProveedor=@direccionP," +
                        " telefono=@telefono," +
                        " celular=@celular," +
                        " fax=@fax," +                       
                        " primerApellido=@apellido1," +
                        " segundoApellido=@apellido2," +
                        " nombreContacto=@nombreC," +
                        " direccionContacto=@direccionC," +
                        " oficina=@oficina,"+
                        " foto=null" +
                        " where codProveedor=@cod";
                }
                ParamStruct[] parametros = new ParamStruct[14];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, _codigo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombreP", SqlDbType.VarChar, _nombreP);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@ced", SqlDbType.VarChar, _cedula);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@fecha", SqlDbType.VarChar, _fecha);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@correo", SqlDbType.VarChar, _correo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@direccionP", SqlDbType.VarChar, _direccionP);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@telefono", SqlDbType.VarChar, _telefono);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@celular", SqlDbType.VarChar, _celular);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@fax", SqlDbType.VarChar, _fax);                
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@apellido1", SqlDbType.VarChar, _apellido1);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 10, "@apellido2", SqlDbType.VarChar, _apellido2);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 11, "@nombreC", SqlDbType.VarChar, _nombreC);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 12, "@direccionC", SqlDbType.VarChar, _direccionC);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 13, "@oficina", SqlDbType.VarChar, _oficina);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar el Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                sql = "Update Proveedor set foto=@img Where codProveedor='"+_codigo+"'";
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
                sql = "Select valor From Consecutivos WHERE tipo='Proveedor'";

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
                sql = "Select prefijo From Consecutivos WHERE tipo='Proveedor'";

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
                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Proveedor'";

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

        public DataSet carga_Proveedores()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codProveedor, nombreProveedor, primerApellido, segundoApellido, oficina, fax, celular from Proveedores Order by codProveedor";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        //Faltara revisar despues
        public DataSet carga_Proveedor_especifico()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select codProveedor, nombreProveedor, primerApellido, segundoApellido, oficina, fax, celular from Proveedores ";
                string condicion = "Where ";

                if (!string.IsNullOrEmpty(_codigo))
                {
                    sql1 += condicion + "codProveedor ='" + _codigo + "'";
                    condicion = " and ";
                }
                if (!string.IsNullOrEmpty(_nombreP))
                {
                    sql1 += condicion + "nombreProveedor ='" + _nombreP + "'";
                    condicion = " and ";
                }
                if (!string.IsNullOrEmpty(_direccionP))
                {
                    sql1 += condicion + "direccionProveeddor ='" + _direccionP + "'";
                    condicion = " and ";
                }
                if (!string.IsNullOrEmpty(_cedula))
                {
                    sql1 += condicion + "cedula ='" + _cedula + "'";
                }

                sql = sql1 + " Order by codProveedor";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public bool eliminar_Proveedor(string codProv)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                sql = "Delete from Proveedor where codProveedor = @cod";

                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, codProv);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al eliminar el proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
     

        public void carga_info_empleado(string codP)
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombreP = "Error";
            }
            else
            {
                sql = "Select nombreProveedor, cedula, fecha, correo, direccionProveedor, telefono, celular, fax, primerApellido, segundoApellido, nombreContacto, direccioContacto, oficina, imagen" +
                      " from Proveedor where codProveedor=@cod";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, codP);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener el empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombreP = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _nombreP = ds.Tables[0].Rows[0]["nombreProveedor"].ToString();
                        _cedula = ds.Tables[0].Rows[0]["cedula"].ToString();
                        _apellido1 = ds.Tables[0].Rows[0]["primerApellido"].ToString();
                        _fecha = ds.Tables[0].Rows[0]["fechaIngreso"].ToString();
                        _apellido2 = ds.Tables[0].Rows[0]["segundoApellido"].ToString();
                        _telefono = ds.Tables[0].Rows[0]["telefono"].ToString();
                        _celular = ds.Tables[0].Rows[0]["celular"].ToString();
                        _nombreC = ds.Tables[0].Rows[0]["nombreContacto"].ToString();
                        _oficina = ds.Tables[0].Rows[0]["oficina"].ToString();
                        _fax = ds.Tables[0].Rows[0]["fax"].ToString();
                        _correo = ds.Tables[0].Rows[0]["correo"].ToString();
                        _direccionP = ds.Tables[0].Rows[0]["direccionProveedor"].ToString();
                        _direccionC = ds.Tables[0].Rows[0]["direccionContacto"].ToString();
                        if (!string.IsNullOrEmpty(ds.Tables[0].Rows[0]["foto"].ToString()))
                        {
                            _foto = (byte[])(ds.Tables[0].Rows[0]["foto"]);
                        }
                        else
                        {
                            _foto = null;
                        }                      
                    }
                    else
                    {
                        _nombreP = "Error";
                    }
                }

            }
        }

        public DataSet cargar_lista_ProductosR()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {                
                sql = "SELECT STUFF((select ',' + nombre from Comestibles for xml path ('')), 1, 1,'') as productosR";

                // "select concat(concat(concat(concat(concat(U.Nombre,' '), T.nombre), L.nombre), E.nombre), C.nombre) as productos from Restaurante R INNER JOIN Comestibles C on C.codRestaurante= R.codRestaurante INNER JOIN Limpieza L on  L.codRestaurante= R.codRestaurante INNER JOIN Utencilios U on U.codRestaurante= R.codRestaurante INNER JOIN Tecnologia T  on T.codRestaurante= R.codRestaurante INNER JOIN on DesechablesEmpaques E on E.codRestaurante= R.codRestaurante";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public DataSet cargar_lista_ProductosP()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "select nombreProductos as productosP from ProveedorRestaurante";
              
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar los productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public void agregar_productos(string nombre, string nick)
        {
            string codRest = "";
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataSet ds;
                ds = retorna_codigo_Restaurante(nick);
                codRest = Convert.ToString(ds.Tables[0].Rows[0]["codRest"]);
                sql = "Insert into ProveedorRestaurante values(@codProveedor, @codRestaurante, @nombreProducto)";
                ParamStruct[] parametros = new ParamStruct[14];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codProveedor", SqlDbType.VarChar, _codigo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@codRestaurante", SqlDbType.VarChar, codRest);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@nombreProducto", SqlDbType.VarChar, nombre);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
            }
        }

        public void remover_productos(string nombreProd, string nick)
        {
            string codRest = "";
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DataSet ds;
                ds = retorna_codigo_Restaurante(nick);
                codRest = Convert.ToString(ds.Tables[0].Rows[0]["codRest"]);
                sql = "Delete from ProveedorRestaurante  Where codProveedor='" + _codigo + "' and codRestaurante='"+ codRest + "' and nombreProductos='" + nombreProd + "'";
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.guardar_imagen(conexion, sql, _foto, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
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

                if (nombreP != "Error")
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
        #endregion

    }
}

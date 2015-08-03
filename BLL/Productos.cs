using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace BLL
{
   public class Productos
   {
       #region propiedades
       private int _codigo;

       public int codigo
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
       private int _proveedor;

       public int proveedor
       {
           get { return _proveedor; }
           set { _proveedor = value; }
       }
       private int _linea;

       public int linea
       {
           get { return _linea; }
           set { _linea = value; }
       }
       private bool _descontinuado;

       public bool descontinuado
       {
           get { return _descontinuado; }
           set { _descontinuado = value; }
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
       public DataSet carga_lista_productos()
       {           
           conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
           if (conexion == null)
           {
               MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return null;
           }
           else
           {
               sql = "Select Cod_Producto, nombre_producto, descontinuado" +
                     " from productos" +
                     " Order by Cod_Producto";

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

       public DataSet carga_lineas()
       {
           conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
           if (conexion == null)
           {
               MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return null;
           }
           else
           {
               sql = "Select Cod_Linea, descripcion_linea" +
                     " from Lineas" +
                     " Order by Descripcion_Linea";

               ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
               if (numero_error != 0)
               {
                   MessageBox.Show(mensaje_error, "Error al cargar las lineas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return null;
               }
               else
               {
                   return ds;
               }
           }
       }

       public DataSet carga_proveedores()
       {
           conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
           if (conexion == null)
           {
               MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return null;
           }
           else
           {
               sql = "Select Cod_Proveedor, nombre_proveedor" +
                     " from proveedores" +
                     " Order by Nombre_proveedor";

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

       public void carga_info_producto(int cod_producto)
       {
           conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
           if (conexion == null)
           {
               MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
               _nombre = "Error";
           }
           else
           {
               sql = "Select Nombre_Producto,Cod_Linea,Cod_Proveedor,Descontinuado" +
                     " from Productos where cod_producto=@cod";
               ParamStruct[] parametros = new ParamStruct[1];
               cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.Int, cod_producto);
               ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
               if (ds == null)
               {
                   MessageBox.Show(mensaje_error, "Error al obtener el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   _nombre = "Error";
               }
               else
               {
                   if (ds.Tables[0].Rows.Count > 0)
                   {
                       _nombre = ds.Tables[0].Rows[0]["Nombre_Producto"].ToString();
                       _linea = Convert.ToInt32(ds.Tables[0].Rows[0]["Cod_Linea"]);
                       _proveedor = Convert.ToInt32(ds.Tables[0].Rows[0]["Cod_Proveedor"]);
                       _descontinuado = Convert.ToBoolean(ds.Tables[0].Rows[0]["Descontinuado"]);
                   }
                   else
                   {
                       _nombre = "Error";
                   }
               }

           }
       }

       public bool guardar_producto(string accion)
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
                   sql = "Insert into Productos values(@cod,@nombre,@cod_linea,@cod_proveedor,@descontinuado)";
               }
               else
               {
                   sql = "Update Productos SET" +
                       " nombre_producto=@nombre," +
                       " cod_linea=@cod_linea," +
                       " cod_proveedor=@cod_proveedor," +
                       " descontinuado=@descontinuado" +
                       " where cod_producto=@cod";
               }
               ParamStruct[] parametros = new ParamStruct[5];
               cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, _nombre);
               cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@cod_linea", SqlDbType.Int, _linea);
               cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@cod_proveedor", SqlDbType.Int, _proveedor);
               cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@descontinuado", SqlDbType.Bit, _descontinuado);
               cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@cod", SqlDbType.Int, _codigo);
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

       public bool eliminar_producto(int cod_producto)
       {
           conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
           if (conexion == null)
           {
               MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
           }
           else
           {
               sql = "Delete from Productos where cod_producto=@cod";
               ParamStruct[] parametros = new ParamStruct[1];
               cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.Int, cod_producto);
               cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
               cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
               if (numero_error != 0)
               {
                   MessageBox.Show(mensaje_error, "Error al eliminar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

       #endregion  
   }
}

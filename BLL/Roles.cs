﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Roles
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
        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
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

         public bool guardar_rol(string accion)
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
                   sql = "Insert into Roles values(@cod,@nombre,@descripcion)";
               }
               else
               {
                   sql = "Update Roles SET" +
                       " nombre=@nombre," +
                       " Descripcion=@descripcion"+
                       " where CodRol=@cod";
               }
               ParamStruct[] parametros = new ParamStruct[3];
               cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, _nombre);
               cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@descripcion", SqlDbType.VarChar, _descripcion);
               cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@cod", SqlDbType.VarChar, _codigo);
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
        #endregion
    }
}
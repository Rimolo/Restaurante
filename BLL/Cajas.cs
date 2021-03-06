﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class Cajas
    {
        #region propiedades
        private string _codigo;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _codRest;

        public string codRest
        {
            get { return _codRest; }
            set { _codRest = value; }
        }
        private string _fecha;

        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private int _apertura;

        public int apertura
        {
            get { return _apertura; }
            set { _apertura = value; }
        }

        private int _cierre;

        public int cierre
        {
            get { return _cierre; }
            set { _cierre = value; }
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

        public bool guardar_caja(string accion)
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
                    if (apertura > cierre)
                    {
                        sql = "Insert into Caja values(@cod,@codR,convert(datetime,@fecha,103),@apertura,0,'Apertura de Caja')";
                    }
                    else {
                        sql = "Insert into Caja values(@cod,@codR,convert(datetime,@fecha,103),@cierre,0,'Cierre de Caja')";
                    }
                    
                }
               
                ParamStruct[] parametros = new ParamStruct[5];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@codR", SqlDbType.VarChar, _codRest);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fecha", SqlDbType.VarChar, _fecha);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@apertura", SqlDbType.VarChar, _apertura);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@cierre", SqlDbType.VarChar, _cierre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@cod", SqlDbType.VarChar, _codigo);



                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al guardar la caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public DataSet carga_cajas()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select c.codCaja,c.fecha,c.descripcion,c.montoApertura as monto,c.montoCierre as monto,case  When c.descripcion ='Apertura de caja' then 1 else 0 end as ap,case When c.descripcion ='Cierre de caja' then 1 else 0 end as cr,r.nombre from Caja c  join Restaurante r on c.codRestaurante = r.codRestaurante   Order by codCaja";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar las cajas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }
        public string obtener_cod_rest(string nombre)
        {
            string codigoR = "";
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select codRestaurante from Restaurante where nombre=@nombre";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre", SqlDbType.VarChar, nombre);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener el pais", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        codigoR = ds.Tables[0].Rows[0]["codRestaurante"].ToString();


                    }

                }
                return codigoR;
            }
        }
        //Faltara revisar despues
        public DataSet carga_cajas_especificos()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                string sql1 = "Select c.codCaja,c.fecha,c.descripcion,c.montoApertura as monto,c.montoCierre as monto,case  When c.descripcion ='Apertura de caja' then 1 else 0 end as ap,case When c.descripcion ='Cierre de caja' then 1 else 0 end as cr,r.nombre from Caja c  join Restaurante r on c.codRestaurante = r.codRestaurante ";
                string condicion = "Where ";

                if (!string.IsNullOrEmpty(_codigo))
                {
                    sql1 += condicion + "c.codCaja ='" + _codigo + "'";
                    condicion = " and ";
                }
                if (!string.IsNullOrEmpty(_codRest))
                {
                    sql1 += condicion + "r.codRestaurante ='" + _codRest + "'";
                    condicion = " and ";
                }
                if (_apertura==1)
                {
                    sql1 += condicion + "c.descripcion='Apertura de caja'";
                    condicion = " and ";
                }
                if (_cierre==1)
                {
                    sql1 += condicion + "c.descripcion='Cierre de caja'";
                }
                if (!string.IsNullOrEmpty(_fecha)){
                    sql1 += condicion + "convert(datetime,'" + _fecha + "',103)";
                }
                sql = sql1 + " Order by c.codCaja";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar las cajas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
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
                sql = "Select valor From Consecutivos WHERE tipo='Cajas'";

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
                sql = "Select prefijo From Consecutivos WHERE tipo='Cajas'";

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

                sql = "Update Consecutivos SET valor=@valor WHERE tipo='Cajas'";

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
        #endregion
    }
}

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

        private bool _apertura;

        public bool apertura
        {
            get { return _apertura; }
            set { _apertura = value; }
        }

        private bool _cierre;

        public bool cierre
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
                sql = "Select c.codCaja,c.fecha,m.descripcion,m.saldoActual-m.saldoAnterior as monto,c.montoApertura,c.montoCierre,r.nombre from Caja c join Movimientos m on c.codCaja = m.codCaja join Restaurante r on c.codRestaurante = r.codRestaurante   Order by codCaja";

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
                        codigoR = ds.Tables[0].Rows[0]["nombre"].ToString();


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
                string sql1 = "Select c.codCaja,c.fecha,m.descripcion,m.saldoActual-m.saldoAnterior as monto,c.montoApertura,c.montoCierre,r.nombre from Caja c join Movimientos m on c.codCaja = m.codCaja join Restaurante r on c.codRestaurante = r.codRestaurante ";
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
                if (_apertura)
                {
                    sql1 += condicion + "m.descripcion='Apertura de caja'";
                    condicion = " and ";
                }
                if (_cierre)
                {
                    sql1 += condicion + "m.descripcion='Cierre de caja'";
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
        #endregion
    }
}

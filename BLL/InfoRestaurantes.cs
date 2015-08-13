using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace BLL
{
    public class InfoRestaurantes
    {
        #region propiedades
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

        private string _nombreEspecial;

        public string nombreEspecial
        {
            get { return _nombreEspecial; }
            set { _nombreEspecial = value; }
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
        public int cargar_mesasOcupadas()
        {
            int num = -1;
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else
            {
                sql = "Select count(*) as numero from ClienteReserva cr join Cliente c on c.codCliente = cr.codCliente join Restaurante r on c.codRestaurante = r.codRestaurante where c.estadoFactura = 'Sin pagar' and c.fecha =@fecha and r.codRestaurante=@cod";

                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, _codRest);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fecha", SqlDbType.VarChar, _fecha);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener las mesas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        num = Convert.ToInt32(ds.Tables[0].Rows[0]["numero"].ToString());


                    }

                }
                return num;
            }
        }
        public int cargar_barra()
        {
            int num = -1;
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else
            {
                sql = "Select count(*) as numero from ClienteBarra cr join Cliente c on c.codCliente = cr.codCliente join Restaurante r on c.codRestaurante = r.codRestaurante where c.estadoFactura = 'Sin pagar' and c.fecha =@fecha and r.codRestaurante=@cod";

                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, _codRest);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fecha", SqlDbType.VarChar, _fecha);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener las barras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        num = Convert.ToInt32(ds.Tables[0].Rows[0]["numero"].ToString());


                    }

                }
                return num;
            }
        }
        public int cargar_reservadas()
        {
            int num = -1;
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            else
            {
                sql = "Select count(*) as numero from ClienteReserva cr join Cliente c on c.codCliente = cr.codCliente join Restaurante r on c.codRestaurante = r.codRestaurante where c.reserva = 1 and c.fecha =@fecha and r.codRestaurante=@cod";

                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, _codRest);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@fecha", SqlDbType.VarChar, _fecha);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener las mesas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        num = Convert.ToInt32(ds.Tables[0].Rows[0]["numero"].ToString());


                    }

                }
                return num;
            }
        }


        public DataSet carga_especiales()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                sql = "Select nombre,precio from Especiales Where codRestaurante ='" + _codRest + "'";


                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    MessageBox.Show(mensaje_error, "Error al cargar las especialidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }
        }

        public void cargar_imagen()
        {
            conexion = cls_DAL.trae_conexion("Progra4", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                MessageBox.Show(mensaje_error, "Error al obtener cadena de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _nombreEspecial = "Error";
            }
            else
            {
                sql = "Select nombre,imagen" +
                      " from Especiales where nombre=@nombre and CodRestaurante=@cod";
                ParamStruct[] parametros = new ParamStruct[2];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@cod", SqlDbType.VarChar, _codRest);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@nombre", SqlDbType.VarChar, _nombreEspecial);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, false, parametros, ref mensaje_error, ref numero_error);
                if (ds == null)
                {
                    MessageBox.Show(mensaje_error, "Error al obtener el especial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _nombreEspecial = "Error";
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
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
                        _nombreEspecial = "Error";
                    }
                }

            }
        }

        #endregion
    }
}


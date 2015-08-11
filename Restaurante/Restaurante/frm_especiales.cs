﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Restaurante
{
    public partial class frm_especiales : Form
    {
        Especiales obj_especiales = new Especiales();

        private string _accion;

        public string accion
        {
            get { return _accion; }
            set { _accion = value; }
        }

        private string _codigo;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _nick;

        public string nick
        {
            get { return _nick; }
            set { _nick = value; }
        }

        public frm_especiales()
        {
            InitializeComponent();
        }

        private void b_borrar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_ingredientes.Text = "";
            txt_precio.Text = "";
            txt_detalle.Text = "";
            pb_foto.Image = null;
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (!cls_validacion.validar(txt_nombre))
            {
                MessageBox.Show("Por favor digite el nomnre del especial", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_detalle))
            {
                MessageBox.Show("Por favor escriba los detalle del especial", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_detalle.Focus();
                return;
            }

            if (!cls_validacion.validar(txt_ingredientes))
            {
                MessageBox.Show("Por favor digite los ingredientes del especial", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ingredientes.Focus();
                return;
            }
            if (!cls_validacion.validar(txt_precio))
            {
                MessageBox.Show("Por favor digite el precio del especial", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_precio.Focus();
                return;
            }

            obj_especiales.codEspeciales = txt_codigo.Text;
            obj_especiales.nombre = txt_nombre.Text;
            obj_especiales.detalle = txt_detalle.Text;
            obj_especiales.precio = Convert.ToDecimal(txt_precio.Text);
            obj_especiales.ingredientes = txt_ingredientes.Text;

            if (error = obj_especiales.guardar_Especiales(_accion, _nick) && _accion != "Editar")
            {
                int valor = 0;
                try
                {
                    DataSet ds;
                    ds = obj_especiales.retorna_consecutivo_valor();
                    valor = Convert.ToInt32(ds.Tables[0].Rows[0]["valor"]);
                    valor++;


                    if (obj_especiales.actualizar_consecutivo(valor))
                    {

                        MessageBox.Show("Especial insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar el consecutivo");
                }

            }
            else
            {
                if (!error)
                {
                    MessageBox.Show("Especial insertado con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_foto_Click(object sender, EventArgs e)
        {

        }

        private void frm_especiales_Load(object sender, EventArgs e)
        {
            this.mostar_consecutivo();
            if (accion.Equals("Editar"))
            {
                carga_info();
            }
        }

        private void carga_info()
        {
            obj_especiales.carga_info_Especiales(_codigo);
            if (obj_especiales.nombre != "Error")
            {
                txt_codigo.Text = _codigo;
                txt_nombre.Text = obj_especiales.nombre;
                txt_detalle.Text = obj_especiales.detalle;
                txt_precio.Text = obj_especiales.precio.ToString();
                txt_ingredientes.Text = obj_especiales.ingredientes;
            }
        }

        private void mostar_consecutivo()
        {
            try
            {
                DataSet ds1;
                ds1 = obj_especiales.retorna_consecutivo_valor();
                string valor = ds1.Tables[0].Rows[0]["valor"].ToString();

                DataSet ds2;
                ds2 = obj_especiales.retorna_consecutivo_prefijo();
                string pre = ds2.Tables[0].Rows[0]["prefijo"].ToString();
                txt_codigo.Text = pre + valor;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el consecutivo");
            }

        }
    }
}

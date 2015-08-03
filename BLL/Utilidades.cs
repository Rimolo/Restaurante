using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    //es una prueba
    public static class cls_validacion
    {
        public static bool validar(DateTimePicker dtp)
        {
            if (dtp.Checked)
                return true;
            else
                return false;
        }
        
        public static bool validar(TextBox txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
                return false;
            else
                return true;
        }

        public static bool validar(MaskedTextBox msk)
        {
            if (!msk.MaskFull)
                return false;
            else
                return true;
        }

        public static bool validar(ComboBox cb)
        {
            if (cb.SelectedIndex == -1)
                return false;
            else
                return true;
        }

        public static bool validar(CheckBox chk)
        {
            if (chk.Checked == true)
                return true;
            else
                return false;
        }

        public static bool estavaciodatagridview(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
                return true;
            else
                return false;
        }

        public static bool esdecimal(TextBox txt)
        {
            try
            {
                decimal valor = 0;
                valor = Convert.ToDecimal(txt.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool esentero(TextBox txt)
        {
            try
            {
                int valor = 0;
                valor = Convert.ToInt32(txt.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new frm_login());
            //Application.Run(new frm_tipoBebida());
            //Application.Run(new frm_listaConsecutivos());
          //Application.Run(new frm_listaRoles());
        }
    }
}

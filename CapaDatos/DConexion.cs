﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CapaDatos
{
    class DConexion
    {
        public static string Cn = Properties.Settings.Default.dbbasculaConnectionString;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos
{
    public class ConnectionManager
    {
        protected SqlConnection _conexion;

        public ConnectionManager(string connectionString)
        {
            _conexion = new SqlConnection(connectionString);
        }
        public void Open()
        {
            
            _conexion.Open();
        }
        public void Close()
        {
            _conexion.Close();
        }
    }
}

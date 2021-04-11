using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using pryEntidad;

namespace pryDatos
{
    public class Conexion
    {
        private SqlConnection cnx = new SqlConnection("server=.; database=bdG_VENTAS; uid=sa; pwd=123456;");
        
        public SqlConnection Conectar 
        {
            get { return cnx; }
        }
    }
}

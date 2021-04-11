using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//Para Manejo de Datos
using System.Data;
using System.Data.SqlClient;
using System.Web.Management;

namespace pryWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        SqlConnection cn = new SqlConnection("server=.; database=BDSenati; uid=sa; pwd=123456");

        public DataSet ListarCliente()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListarCliente", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet ListarDireccion()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListarDireccion", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}

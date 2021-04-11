using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Web.Management;
using System.Web.UI;

namespace pryWCFVentas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFVenta : IWCFVenta
    {
        SqlConnection cn = new SqlConnection("server=.; database=bdG_VENTAS; uid=sa; pwd=123456;");

        public DataSet ListarCliente() 
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListarCliente", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public DataSet ListarDistrito() 
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListarDistrito", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public String AgregarCliente(Cliente cli)
        {
            String mensaje = "";
            SqlCommand cmd = new SqlCommand("SP_AgregarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", cli.codCli);
            cmd.Parameters.AddWithValue("@nom", cli.nombreCli);
            cmd.Parameters.AddWithValue("@apellido", cli.apellidoCli);
            cmd.Parameters.AddWithValue("@dni", cli.dni);
            cmd.Parameters.AddWithValue("@genero", cli.genero);
            cmd.Parameters.AddWithValue("@telef", cli.telfCli);
            cmd.Parameters.AddWithValue("@codD", cli.codDire);

            //ABRIMNOS CONNEXION
            cn.Open();

            try
            {
                int num_reg = cmd.ExecuteNonQuery();
                mensaje = num_reg.ToString() + " Registro Agregado";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;

            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }

        public String ActualizarCliente(Cliente cli)
        {
            String mensaje = "";
            SqlCommand cmd = new SqlCommand("SP_ActualizarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", cli.codCli);
            cmd.Parameters.AddWithValue("@nom", cli.nombreCli);
            cmd.Parameters.AddWithValue("@apellido", cli.apellidoCli);
            cmd.Parameters.AddWithValue("@dni", cli.dni);
            cmd.Parameters.AddWithValue("@genero", cli.genero);
            cmd.Parameters.AddWithValue("@telef", cli.telfCli);
            cmd.Parameters.AddWithValue("@codD", cli.codDire);

            //ABRIMNOS CONNEXION
            cn.Open();

            try
            {
                int num_reg = cmd.ExecuteNonQuery();
                mensaje = num_reg.ToString() + " Registro Actualizado";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;

            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }

        public String EliminarCliente(Cliente cli)
        {
            String mensaje = "";
            SqlCommand cmd = new SqlCommand("SP_EliminarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", cli.codCli);

            //ABRIMNOS CONNEXION
            cn.Open();

            try
            {
                int num_reg = cmd.ExecuteNonQuery();
                mensaje = num_reg.ToString() + " Registro Eliminado";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;

            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }

        ////////////////////////////////////////////////////////////////////


        public DataSet ListarTotalVenta() 
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListarTotalVenta", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet ListarProducto()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListarProducto", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public String AgregarVenta(Venta ven)
        {
            String mensaje = "";
            SqlCommand cmd = new SqlCommand("SP_AgregarVenta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ven.codVenta);
            cmd.Parameters.AddWithValue("@cantidad", ven.cantidad);
            cmd.Parameters.AddWithValue("@fecha", ven.fecha);
            cmd.Parameters.AddWithValue("@codCli", ven.codCli);
            cmd.Parameters.AddWithValue("@codPro", ven.codPro);

            //ABRIMNOS CONNEXION
            cn.Open();

            try
            {
                int num_reg = cmd.ExecuteNonQuery();
                mensaje = num_reg.ToString() + " Registro Agregado";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;

            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }

        public String ActualizarVenta(Venta ven)
        {
            String mensaje = "";
            SqlCommand cmd = new SqlCommand("SP_ActualizarVenta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ven.codVenta);
            cmd.Parameters.AddWithValue("@cantidad", ven.cantidad);
            cmd.Parameters.AddWithValue("@fecha", ven.fecha);
            cmd.Parameters.AddWithValue("@codCli", ven.codCli);
            cmd.Parameters.AddWithValue("@codPro", ven.codPro);

            //ABRIMNOS CONNEXION
            cn.Open();

            try
            {
                int num_reg = cmd.ExecuteNonQuery();
                mensaje = num_reg.ToString() + " Registro Actualizado";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;

            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }

        public String EliminarVenta(Venta ven)
        {
            String mensaje = "";
            SqlCommand cmd = new SqlCommand("SP_EliminarVenta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ven.codVenta);
            

            //ABRIMNOS CONNEXION
            cn.Open();

            try
            {
                int num_reg = cmd.ExecuteNonQuery();
                mensaje = num_reg.ToString() + " Registro Eliminado";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;

            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }
    }

}

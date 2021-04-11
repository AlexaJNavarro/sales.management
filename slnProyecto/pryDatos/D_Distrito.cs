using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using pryEntidad;

namespace pryDatos
{
    public class D_Distrito
    {
        Conexion cn = new Conexion();

        public DataTable ListarDistrito()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_ListarDistrito", cn.Conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public string AgregarDistrito(E_Distrito e_dis)
        {
            cn.Conectar.Open();
            String mensaje = "";

            using (SqlTransaction tr = cn.Conectar.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_AgregarDistrito", cn.Conectar, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", e_dis.nombreDire);

                try
                {
                    int nreg = cmd.ExecuteNonQuery();
                    tr.Commit();
                    mensaje = nreg.ToString() + " Distrito Registrado. ";
                }
                catch (SqlException ex)
                {

                    tr.Rollback();
                    mensaje = ex.Message;
                }
                finally
                {
                    cn.Conectar.Close();
                }

            }

            return mensaje;
        }

        public string ActualizarDistrito(E_Distrito e_dis)
        {
            cn.Conectar.Open();
            String mensaje = "";

            using (SqlTransaction tr = cn.Conectar.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_ActualizarDistrito", cn.Conectar, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cod", e_dis.codDire);
                cmd.Parameters.AddWithValue("@nombre", e_dis.nombreDire);

                try
                {
                    int nreg = cmd.ExecuteNonQuery();
                    tr.Commit();
                    mensaje = nreg.ToString() + " Registro Actualizado. ";
                }
                catch (SqlException ex)
                {

                    tr.Rollback();
                    mensaje = ex.Message;
                }
                finally
                {
                    cn.Conectar.Close();
                }

            }

            return mensaje;
        }

        public string EliminarDistrito(E_Distrito e_dis)
        {
            cn.Conectar.Open();
            String mensaje = "";

            using (SqlTransaction tr = cn.Conectar.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_EliminarDistrito", cn.Conectar, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cod", e_dis.codDire);

                try
                {
                    int nreg = cmd.ExecuteNonQuery();
                    tr.Commit();
                    mensaje = nreg.ToString() + " Registro Eliminado. ";
                }
                catch (SqlException ex)
                {

                    tr.Rollback();
                    mensaje = ex.Message;
                }
                finally
                {
                    cn.Conectar.Close();
                }

            }

            return mensaje;
        }

    }
}

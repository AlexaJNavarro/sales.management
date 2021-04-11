using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using pryDatos;
using pryEntidad;

namespace pryNegocio
{
    public class N_Distrito
    {
        private D_Distrito d_dis = new D_Distrito();

        private static void ValidarRegistro(E_Distrito e_dis) 
        {
            if (String.IsNullOrEmpty(e_dis.nombreDire)) 
            {
                throw new ArgumentException("No debe estar vacio el nombre del Distrito.");
            }

            if (e_dis.nombreDire.Length==1) 
            {
                throw new ArgumentException("El nombre del Distrito no es válido.");
            }
        }

        public DataTable Listar() 
        {
            return d_dis.ListarDistrito();
        }

        public String Agregar(E_Distrito e_dis) 
        {
            try
            {
                ValidarRegistro(e_dis);
                return d_dis.AgregarDistrito(e_dis);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Actualizar(E_Distrito e_dis) 
        {
            return d_dis.ActualizarDistrito(e_dis);
        }

        public String Eliminar(E_Distrito e_dis) 
        {
            return d_dis.EliminarDistrito(e_dis);
        }
    }
}

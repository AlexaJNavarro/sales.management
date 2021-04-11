using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Data;
using System.Data.Sql;

namespace pryWCFVentas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWCFVenta
    {
        //DEFINIMOS MÉTODOS
        [OperationContract]
        DataSet ListarCliente();

        [OperationContract]
        DataSet ListarDistrito();

        [OperationContract]
        string AgregarCliente(Cliente cli);

        [OperationContract]
        string ActualizarCliente(Cliente cli);

        [OperationContract]
        string EliminarCliente(Cliente cli);

        //////////////////////////////////////////////
        [OperationContract]
        DataSet ListarProducto();

        [OperationContract]
        DataSet ListarTotalVenta();

        [OperationContract]
        string AgregarVenta(Venta ven);

        [OperationContract]
        string ActualizarVenta(Venta ven);

        [OperationContract]
        string EliminarVenta(Venta ven);

    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Cliente
    {
        //ATRIBUTOS
        [DataMember]
        public String codCli { get; set; }
       
        [DataMember]
        public String nombreCli { get; set; }

        [DataMember]
        public String apellidoCli { get; set; }

        [DataMember]
        public String dni { get; set; }

        [DataMember]
        public String genero { get; set; }

        [DataMember]
        public String telfCli { get; set; }

        [DataMember]
        public String codDire { get; set; }


    }

    [DataContract]
    public class Venta 
    {
        [DataMember]
        public String codVenta { get; set; }

        [DataMember]
        public int cantidad { get; set; }

        [DataMember]
        public DateTime fecha { get; set; }

        [DataMember]
        public String codCli { get; set; }

        [DataMember]
        public String codPro { get; set; }
    }
}

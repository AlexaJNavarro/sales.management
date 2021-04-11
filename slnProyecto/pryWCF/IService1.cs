using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace pryWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        //METODOS DE CLIENTE
        [OperationContract]
        DataSet ListarCliente();

        //[OperationContract]
        //string RegistrarCliente(Cliente cli);

        //[OperationContract]
        //string ActualizarCliente(Cliente cli);

        //[OperationContract]
        //string EliminarCliente(Cliente cli);

        //METODOS DE DIRECCION

        [OperationContract]
        DataSet ListarDireccion();
        


    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]

    //CLIENTE

    public class Cliente
    {
        [DataMember]
        public String codCli { get; set; }

        [DataMember]
        public String nombreCli { get; set; }

        [DataMember]
        public String apellidoCli { get; set; }

        [DataMember]
        public String telfCli { get; set; }

        [DataMember]
        public String codDire { get; set; }

    }
}

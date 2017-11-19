using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.Dominio;
using WCFServices.Errores;

namespace WCFServices
{
    [ServiceContract]
    public interface IClientes
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Cliente CrearCliente(Cliente clienteACrear);

        [OperationContract]
        Cliente ObtenerCliente(string CorreoElectronico);

        [OperationContract]
        Cliente ModficarCliente(Cliente clienteAModificar);

        [OperationContract]
        void EliminarCliente(string CorreoElectronico);

        [OperationContract]
        List<Cliente> ListarCliente();
    }
}

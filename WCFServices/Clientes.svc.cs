using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFServices.Dominio;
using WCFServices.Errores;
using WCFServices.Persistencia;

namespace WCFServices
{
    public class Clientes : IClientes
    {
        private ClienteDAO clienteDAO = new ClienteDAO();
        public Cliente CrearCliente(Cliente clienteACrear)
        {
            if(clienteDAO.Obtener(clienteACrear.CorreoElectronico) != null)
            {
                throw new FaultException<RepetidoException>(
                    new RepetidoException()
                    {
                        Codigo = "101",
                        Descripcion = "El cliente ya existe"
                    }, 
                    new FaultReason("Error al intentar crear cliente"));
            }
            return clienteDAO.Crear(clienteACrear);
        }

        public Cliente ObtenerCliente(string CorreoElectronico)
        {
            return clienteDAO.Obtener(CorreoElectronico);
        }

        public Cliente ModficarCliente(Cliente clienteAModificar)
        {
            return clienteDAO.Modificar(clienteAModificar);
        }

        public void EliminarCliente(string CorreoElectronico)
        {
            clienteDAO.Eliminar(CorreoElectronico);
        }

        public List<Cliente> ListarCliente()
        {
            return clienteDAO.Listar();
        }
    }
}

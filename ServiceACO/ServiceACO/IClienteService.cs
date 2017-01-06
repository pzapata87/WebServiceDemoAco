using System.ServiceModel;
using ServiceACO.Core;

namespace ServiceACO
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        ACOWebServiceResponse InsertarNuevoCliente(string dni, string nombre, string apellido, string direccion, string email);

        [OperationContract]
        ACOWebServiceResponse EliminarCliente(int id);
    }
}
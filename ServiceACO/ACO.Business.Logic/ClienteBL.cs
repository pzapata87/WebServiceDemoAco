using ACO.Business.Entity;
using Core.Singleton;

namespace ACO.Business.Logic
{
    public class ClienteBL : Singleton<ClienteBL>
    {
        public int Add(Cliente respuesta)
        {
            return EncuestaRepository.Instancia.Add(respuesta);
        }
    }
}
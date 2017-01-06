using ACO.Business.Entity;
using ACO.DataAccess;
using Core.Singleton;

namespace ACO.Business.Logic
{
    public class ClienteBL : Singleton<ClienteBL>
    {
        public int Add(Cliente cliente)
        {
            return ClienteRepository.GetInstance().Add(cliente);
        }

        public void Remove(int id)
        {
            ClienteRepository.GetInstance().Remove(id);
        }
    }
}
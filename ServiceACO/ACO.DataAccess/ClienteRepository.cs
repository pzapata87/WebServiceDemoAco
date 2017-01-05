using System;
using System.Data;
using ACO.Business.Entity;
using Core.Singleton;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace ACO.DataAccess
{
    public class ClienteRepository : Singleton<ClienteRepository>
    {
        #region Attributos

        private readonly Database _database = new DatabaseProviderFactory().Create("DefaultConnection");

        #endregion

        #region Métodos

        public int Add(Cliente cliente)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand("Insert_PreguntaEncuestaSolicitud"))
            {
                _database.AddInParameter(comando, "@Dni", DbType.String, cliente.Dni);
                _database.AddInParameter(comando, "@Nombre", DbType.String, cliente.Nombre);
                _database.AddInParameter(comando, "@Apellido", DbType.String, cliente.Apellido);
                _database.AddInParameter(comando, "@Direccion", DbType.String, cliente.Direccion);
                _database.AddInParameter(comando, "@Email", DbType.String, cliente.Email);

                id = Convert.ToInt32(_database.ExecuteScalar(comando));
            }

            return id;
        }

        #endregion
    }
}
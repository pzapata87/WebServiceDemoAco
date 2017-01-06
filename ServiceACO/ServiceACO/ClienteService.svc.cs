using System;
using System.Collections.Generic;
using ACO.Business.Entity;
using ACO.Business.Logic;
using ServiceACO.Core;

namespace ServiceACO
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ClienteService : IClienteService
    {
        public ACOWebServiceResponse InsertarNuevoCliente(string dni, string nombre, string apellido, string direccion, string email)
        {
            var response = new ACOWebServiceResponse {ejecucionExitosa = false};

            try
            {
                int id = ClienteBL.GetInstance().Add(new Cliente
                {
                    Dni = dni,
                    Nombre = nombre,
                    Apellido = apellido,
                    Direccion = direccion,
                    Email = email
                });

                response.ejecucionExitosa = id > 0;
                response.mensaje = "Cliente agregado correctamente";
                response.respuestaWebService = new List<ParametroWebService>
                {
                    new ParametroWebService
                    {
                        nombre = "Id",
                        valor = id.ToString()
                    }
                };
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
            }

            return response;
        }

        public ACOWebServiceResponse EliminarCliente(int id)
        {
            var response = new ACOWebServiceResponse { ejecucionExitosa = false };

            try
            {
                ClienteBL.GetInstance().Remove(id);

                response.ejecucionExitosa = true;
                response.mensaje = "Cliente eliminado correctamente";
            }
            catch (Exception ex)
            {
                response.mensaje = ex.Message;
            }

            return response;
        }
    }
}
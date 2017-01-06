using System.Collections.Generic;

namespace ServiceACO.Core
{
    public class ACOWebServiceResponse
    {
        public bool ejecucionExitosa { get; set; }

        public string mensaje { get; set; }

        public List<ParametroWebService> respuestaWebService { get; set; }
    }
}
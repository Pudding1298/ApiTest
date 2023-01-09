using DA.Models;
using DA.Providers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VistaController
    {
        [HttpGet("GetVista")]

        public async Task<string> GetVista() { 
            TestProvider vista = new TestProvider();
            IEnumerable<vTimeSeries> resultado = await vista.LeerVista();
            return JsonConvert.SerializeObject(resultado);
        }
    }
}

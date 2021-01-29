using MicroServiceAPI.BLL;
using MicroServiceAPI.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {        
        [HttpPost]
        public async Task<string> Post(string value, string identificador)
        {            
            ServicesBLL servicesBLL = new ServicesBLL();
            return await servicesBLL.Inserir(value, identificador);
        }

        [HttpGet]
        public async Task<Services> Get(string requisicao)
        {            
            Services service = new Services();
            ServicesBLL servicesBLL = new ServicesBLL();
            service = await servicesBLL.ConsultarPorRequisicao(requisicao);
            return service;
        }

        [HttpGet("Envios")]
        public async Task<List<Services>> GetEnvios()
        {            
            List<Services> services = new List<Services>();
            ServicesBLL servicesBLL = new ServicesBLL();
            services = await servicesBLL.ConsultarEnvios();
            return services;
        }

        [HttpGet("TotalEnvios")]
        public async Task<int> GetTotalEnvios()
        {
            ServicesBLL servicesBLL = new ServicesBLL();
            return await servicesBLL.ConsultarTotalEnvios();;
        }

        [HttpPost("ZerarBase")]
        public async Task<string> PostZerarBase()
        {            
            ServicesBLL servicesBLL = new ServicesBLL();
            return await servicesBLL.ZerarBase();
        }
    }
}

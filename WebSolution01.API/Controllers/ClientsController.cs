using Microsoft.AspNetCore.Mvc;
using WebSolution01.Application.Interfaces;
using WebSolution01.Domain.Models;

namespace WebSolution01.API.Controllers
{
    [Route("v1/api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientServices _clientServices;

        public ClientsController(IClientServices clientServices)
        {
            this._clientServices = clientServices;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var clients = _clientServices.GetAll();
            
            if (clients.Count == 0)
            {
                return NoContent();
            }
            return Ok(clients);
        }        
        
        [HttpPost]
        public IActionResult Add(Client client) 
        {
            var result = _clientServices.Save(client);
            
            return Ok(result);
        }
    }
}

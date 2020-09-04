using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectDDD.Application.DTOs;
using ProjectDDD.Application.Interfaces;

namespace ProjectDDD.API.Controllers
{
    [Route("v1/cliente")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IClienteApplicationService _clienteApp;
        public ClienteController(IClienteApplicationService clienteApp)
        {
            _clienteApp = clienteApp;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_clienteApp.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_clienteApp.GetAll());
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _clienteApp.Add(clienteDTO);
                return Ok("Cliente cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

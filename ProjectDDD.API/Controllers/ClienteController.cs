using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_clienteApp.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                var cliente = _clienteApp.GetById(id);
                if (cliente == null)
                    return NotFound();
                return Ok(cliente);
            }
            catch (Exception)
            {
                return NotFound();
            }
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

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDTO clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();
                _clienteApp.Update(clienteDTO);
                return Ok("Cliente atualizado com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ClienteDTO clienteDTO)
        {
            if (clienteDTO == null)
                return NotFound();
            _clienteApp.Remove(clienteDTO);
            return Ok("Cliente removido com sucesso");
        }
    }
}

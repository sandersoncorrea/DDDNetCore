using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDDD.Application.DTOs;
using ProjectDDD.Application.Interfaces;

namespace ProjectDDD.API.Controllers
{
    [Route("v1/produto")]
    [ApiController]
    public class EstoqueController : Controller
    {
        private readonly IEstoqueApplicationService _estoqueApp;
        public EstoqueController(IEstoqueApplicationService estoqueApp)
        {
            _estoqueApp = estoqueApp;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_estoqueApp.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                var estoque = _estoqueApp.GetById(id);
                if (estoque == null)
                    return NotFound();
                return Ok(estoque);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] EstoqueDTO estoqueDTO)
        {
            try
            {
                if (estoqueDTO == null)
                    return NotFound();

                _estoqueApp.Add(estoqueDTO);
                return Ok("Estoque cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] EstoqueDTO estoqueDTO)
        {
            try
            {
                if (estoqueDTO == null)
                    return NotFound();
                _estoqueApp.Update(estoqueDTO);
                return Ok("Estoque atualizado com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] EstoqueDTO estoqueDTO)
        {
            if (estoqueDTO == null)
                return NotFound();
            _estoqueApp.Remove(estoqueDTO);
            return Ok("Estoque removido com sucesso");
        }
    }
}

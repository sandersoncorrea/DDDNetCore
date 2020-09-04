using ProjectDDD.Application.DTOs;
using ProjectDDD.Application.Mappers.Interfaces;
using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectDDD.Application.Mappers
{
    public class EstoqueMapper : IEstoqueMapper
    {
        public Estoque MapperDtoToEntity(EstoqueDTO estoqueDTO)
        {
            return new Estoque()
            {
                Codigo = estoqueDTO.Codigo,
                Nome = estoqueDTO.Nome,
                Venda = estoqueDTO.Venda
            };
        }

        public EstoqueDTO MapperEntityToDto(Estoque estoque)
        {
            return new EstoqueDTO()
            {
                Codigo = estoque.Codigo,
                Nome = estoque.Nome,
                Venda = estoque.Venda
            };
        }

        public IEnumerable<EstoqueDTO> MapperListEstoquesDto(IEnumerable<Estoque> estoques)
        {
            return estoques.Select(est => new EstoqueDTO()
            {
                Codigo = est.Codigo,
                Nome = est.Nome,
                Venda = est.Venda
            });
        }
    }
}

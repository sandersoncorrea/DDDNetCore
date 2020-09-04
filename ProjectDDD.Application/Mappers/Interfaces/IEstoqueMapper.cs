using ProjectDDD.Application.DTOs;
using ProjectDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjectDDD.Application.Mappers.Interfaces
{
    public interface IEstoqueMapper
    {
        Estoque MapperDtoToEntity(EstoqueDTO estoqueDTO);
        IEnumerable<EstoqueDTO> MapperListEstoquesDto(IEnumerable<Estoque> estoques);
        EstoqueDTO MapperEntityToDto(Estoque estoque);
    }
}

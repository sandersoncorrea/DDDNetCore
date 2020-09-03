using ProjectDDD.Application.DTOs;
using System.Collections.Generic;

namespace ProjectDDD.Application.Interfaces
{
    public interface IEstoqueApplicationService
    {
        void Add(EstoqueDTO estoqueDTO);
        void Update(EstoqueDTO estoqueDTO);
        void Remove(EstoqueDTO estoqueDTO);
        IEnumerable<EstoqueDTO> GetAll();
        EstoqueDTO GetById(int codigo);
    }
}

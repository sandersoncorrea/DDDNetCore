using ProjectDDD.Application.DTOs;
using ProjectDDD.Application.Interfaces;
using ProjectDDD.Application.Mappers.Interfaces;
using ProjectDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDDD.Application
{
    public class EstoqueApplicationService : IEstoqueApplicationService
    {
        private readonly IEstoqueService _estoqueService;
        private readonly IEstoqueMapper _estoqueMapper;
        public EstoqueApplicationService(IEstoqueService estoqueService, IEstoqueMapper estoqueMapper)
        {
            _estoqueMapper = estoqueMapper;
            _estoqueService = estoqueService;
        }
        public void Add(EstoqueDTO estoqueDTO)
        {
            _estoqueService.Add(_estoqueMapper.MapperDtoToEntity(estoqueDTO));
        }

        public IEnumerable<EstoqueDTO> GetAll()
        {
            return _estoqueMapper.MapperListEstoquesDto(_estoqueService.GetAll());
        }

        public EstoqueDTO GetById(int codigo)
        {
            return _estoqueMapper.MapperEntityToDto(_estoqueService.GetById(codigo));
        }

        public void Remove(EstoqueDTO estoqueDTO)
        {
            _estoqueService.Remove(_estoqueMapper.MapperDtoToEntity(estoqueDTO));
        }

        public void Update(EstoqueDTO estoqueDTO)
        {
            _estoqueService.Update(_estoqueMapper.MapperDtoToEntity(estoqueDTO));
        }
    }
}

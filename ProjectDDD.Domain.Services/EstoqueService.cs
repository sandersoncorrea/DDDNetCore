using ProjectDDD.Domain.Core.Interfaces.Repositorys;
using ProjectDDD.Domain.Core.Interfaces.Services;
using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDDD.Domain.Services
{
    public class EstoqueService : ServiceBase<Estoque>, IEstoqueService
    {
        private readonly IEstoqueRepository _repository;
        public EstoqueService(IEstoqueRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}

using ProjectDDD.Domain.Core.Interfaces.Repositorys;
using ProjectDDD.Domain.Core.Interfaces.Services;
using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _repository;
        public ClienteService(IClienteRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}

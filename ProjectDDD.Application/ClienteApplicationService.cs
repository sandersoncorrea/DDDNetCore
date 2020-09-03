using ProjectDDD.Application.DTOs;
using ProjectDDD.Application.Interfaces;
using ProjectDDD.Application.Mappers.Interfaces;
using ProjectDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDDD.Application
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteService _clienteService;
        private readonly IClienteMapper _clienteMapper;
        public ClienteApplicationService(IClienteService clienteService, IClienteMapper clienteMapper)
        {
            _clienteMapper = clienteMapper;
            _clienteService = clienteService;
        }
        public void Add(ClienteDTO clienteDTO)
        {
            _clienteService.Add(_clienteMapper.MapperDtoToEntity(clienteDTO));
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            return _clienteMapper.MapperListClientesDto(_clienteService.GetAll());
        }

        public ClienteDTO GetById(int codigo)
        {
            return _clienteMapper.MapperEntityToDto(_clienteService.GetById(codigo));
        }

        public void Remove(ClienteDTO clienteDTO)
        {
            _clienteService.Remove(_clienteMapper.MapperDtoToEntity(clienteDTO));
        }

        public void Update(ClienteDTO clienteDTO)
        {
            _clienteService.Update(_clienteMapper.MapperDtoToEntity(clienteDTO));
        }
    }
}

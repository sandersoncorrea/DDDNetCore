using ProjectDDD.Application.DTOs;
using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDDD.Application.Mappers.Interfaces
{
    public interface IClienteMapper
    {
        Cliente MapperDtoToEntity(ClienteDTO clienteDTO);
        IEnumerable<ClienteDTO> MapperListClientesDto(IEnumerable<Cliente> clientes);
        ClienteDTO MapperEntityToDto(Cliente cliente);
    }
}

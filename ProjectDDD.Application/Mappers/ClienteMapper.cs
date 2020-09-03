using ProjectDDD.Application.DTOs;
using ProjectDDD.Application.Mappers.Interfaces;
using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectDDD.Application.Mappers
{
    public class ClienteMapper : IClienteMapper
    {
        IEnumerable<ClienteDTO> clienteDTOs = new List<ClienteDTO>();
        public Cliente MapperDtoToEntity(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente()
            {
                Codigo = clienteDTO.Codigo,
                Nome = clienteDTO.Nome,
                Email = clienteDTO.Email,
                Cadastro = clienteDTO.Cadastro
            };

            return cliente;
        }

        public ClienteDTO MapperEntityToDto(Cliente cliente)
        {
            ClienteDTO clienteDTO = new ClienteDTO()
            {
                Codigo = cliente.Codigo,
                Nome = cliente.Nome,
                Email = cliente.Email,
                Cadastro = cliente.Cadastro
            };

            return clienteDTO;
        }

        public IEnumerable<ClienteDTO> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(cliente => new ClienteDTO
            {
                Codigo = cliente.Codigo,
                Nome = cliente.Nome,
                Email = cliente.Email,
                Cadastro = cliente.Cadastro
            });

            return dto;
        }
    }
}

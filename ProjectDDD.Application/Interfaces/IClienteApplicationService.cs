using ProjectDDD.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDDD.Application.Interfaces
{
    public interface IClienteApplicationService
    {
        void Add(ClienteDTO clienteDTO);
        void Update(ClienteDTO clienteDTO);
        void Remove(ClienteDTO clienteDTO);
        IEnumerable<ClienteDTO> GetAll();
        ClienteDTO GetById(int codigo);
    }
}

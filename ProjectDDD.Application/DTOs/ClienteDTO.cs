using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDDD.Application.DTOs
{
    public class ClienteDTO
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Cadastro { get; set; }
    }
}

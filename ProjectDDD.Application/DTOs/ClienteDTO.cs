using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectDDD.Application.DTOs
{
    public class ClienteDTO
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Cadastro { get; set; }
    }
}

using System;

namespace ProjectDDD.Domain.Entities
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Cadastro { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDDD.Application.DTOs
{
    public class EstoqueDTO
    {
        public int? Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Venda { get; set; }
    }
}

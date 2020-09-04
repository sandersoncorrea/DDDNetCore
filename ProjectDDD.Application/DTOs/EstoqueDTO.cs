using System.ComponentModel.DataAnnotations;

namespace ProjectDDD.Application.DTOs
{
    public class EstoqueDTO
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Venda { get; set; }
    }
}

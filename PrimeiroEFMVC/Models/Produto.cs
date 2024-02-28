using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PrimeiroEFMVC.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nome do produto")]
        public string Nome { get; set; }

        [Required]
        public int Qtd { get; set; }
    }
}

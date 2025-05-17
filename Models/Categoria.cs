using System.ComponentModel.DataAnnotations;

namespace api_netcore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(250)]
        public string Descricao { get; set; }
    }
}
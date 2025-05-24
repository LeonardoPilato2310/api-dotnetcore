using System.ComponentModel.DataAnnotations;

namespace api_netcore.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Nome { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }
    }
}
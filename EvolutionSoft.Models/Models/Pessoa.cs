using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionSoft.Models.Models
{
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "Este campo deve ter 14 caracteres")]
        public string CPF { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Este campo deve ter de 5 a 150 caractéres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Este campo deve ter no máximo 100 caracteres.")]
        public string Email { get; set; }

        [StringLength(30, ErrorMessage = "Este campo deve ter no máximo 30 caracteres.")]
        public string? CEP { get; set; }

        [StringLength(50, ErrorMessage = "Este campo deve ter no máximo 50 caracteres.")]
        public string? Logradouro { get; set; }

        [StringLength(50, ErrorMessage = "Este campo deve ter no máximo 50 caracteres.")]
        public string? Complemento { get; set; }

        [StringLength(100, ErrorMessage = "Este campo deve ter no máximo 100 caracteres.")]
        public string? Bairro { get; set; }

        [StringLength(2)]
        public string? UF { get; set; }

        public List<Contato>? Contatos { get; set; }


    }
}

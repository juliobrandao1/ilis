using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ilis.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        public string RG { get; set; }

        [Required]
        public string CPF { get; set; }

        public string CNS { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Cidade { get; set; }

        public DateTime? DtaNascimento { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }

        public bool Preferencial { get; set; }

        public string CodAcesso { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }
    }
}
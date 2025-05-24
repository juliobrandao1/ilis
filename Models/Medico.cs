using System.ComponentModel.DataAnnotations;

namespace ilis.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(50)]
        public string? Endereco { get; set; }

        [MaxLength(50)]
        public string? Bairro { get; set; }

        [MaxLength(9)]
        public string? Cep { get; set; }

        [MaxLength(50)]
        public string? Cidade { get; set; }

        [MaxLength(50)]
        public string? Telefone { get; set; }

        public int? TipoConselho { get; set; }

        [MaxLength(10)]
        public string? CRM { get; set; }

        [Required, MaxLength(1)]
        public string? Sexo { get; set; }

        [MaxLength(1)]
        public string? Porc { get; set; }

        [Required]
        public decimal Interno { get; set; }

        [Required]
        public decimal Externo { get; set; }

        [MaxLength(20)]
        public string? CodUnimed { get; set; }

        [MaxLength(2)]
        public string? VinUnimed { get; set; }

        [MaxLength(3)]
        public string? EspUnimed { get; set; }

        [MaxLength(20)]
        public string? CodSUS { get; set; }

        [MaxLength(20)]
        public string? CBOS { get; set; }

        [MaxLength(10)]
        public string? SenhaInternet { get; set; }

        [MaxLength(1)]
        public string? Estrangeiro { get; set; }

        [MaxLength(1)]
        public string? StAtivo { get; set; }
    }
}
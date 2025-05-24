namespace ilis.Models
{
    public class Cadastro
    {
        public string Numero { get; set; }
        public string Cliente { get; set; }
        public string Medico { get; set; }
        public string Posto { get; set; }
        public string Contrato { get; set; }
        public string Plano { get; set; }
        public DateTime DataPedido { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string NumeroCarteirinha { get; set; }
        public DateTime ValidadeCarteirinha { get; set; }       
        public string Leito { get; set; }        
        public DateTime DtaNascimento { get; set; }
        public string Medicamentos { get; set; }
        public string Observacao { get; set; }


    }
}
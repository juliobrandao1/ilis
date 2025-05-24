namespace ilis.Models
{
    public class Pedido
    {

        public int Chave { get; set; }
        public string Paciente { get; set; }
        public string Origem { get; set; }
        public string CNS { get; set; }
        public string Altera { get; set; }
        public string mSexo { get; set; }
        public string mCarteirinha { get; set; }
        public string mCodigoAcesso { get; set; }
        public string mTelefone { get; set; }
        public string mEmail { get; set; }
        public string mCelular { get; set; }
        public string mCPF { get; set; }
        public DateTime? mNascimento { get; set; }

        public int Anos { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }
    }
}
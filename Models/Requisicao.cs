using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ilis.Models
{
    public class Requisicao
    {
        [Key]
        public int codRequisicao { get; set; }

        public int pedido { get; set; }
        public int posto { get; set; }
        public int computador { get; set; }  
        public string acessoInternet  { get; set; }
         public string internet { get; set; }
        public string medico  { get; set; }
        public string guia  { get; set; }
        public string guiaPrincipal  { get; set; }
        public string guiaData  { get; set; }
        public string guiaDataAutorizacao  { get; set; }
        public string guiaSenha  { get; set; }
        public string guiaSenhaValidade  { get; set; }
        public string plano  { get; set; }
        public string carteirinha  { get; set; }
        public string validadeCarteirinha  { get; set; }
        public string leito  { get; set; }
        public string observacao  { get; set; }
        public string obsMedicamento  { get; set; }
        public string previsaoEntrega  { get; set; }
        public int paciente { get; set; }
        public int contrato { get; set; }
        public int fatura   { get; set; }
        public string lancamento  { get; set; }
        public string faturamento  { get; set; }
        public string origem { get; set; }
        public int postosus { get; set; }
        public string urgente { get; set; }
        public string parcial { get; set; }
        public double bruto { get; set; }
        public double desconto { get; set; }
        public double acrescimo { get; set; }
        public double coleta { get; set; }
        public double total { get; set; }
        public string pago { get; set; }
        public string particular { get; set; }
        public int usuarioCad { get; set; }
        public string obsBio { get; set; }
        public string podeAssinar { get; set; }
        public string bloqueado { get; set; }
        public string faturavel { get; set; }
        public int statusId { get; set; }

        // Adicione outras propriedades conforme necessário
    }
}
using System;

namespace Pagamento.Domain.Entities
{
    public abstract class Pagamento 
    //abstract nao deixa estancia direto, pede um dos tipos a baixa junto.
    {
        protected Pagamento(DateTime dataPagamento, DateTime dataExpira, decimal total, decimal totalpago, string pagador, string documento, string endereco, string email)
        {
            Numero = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            DataPagamento = dataPagamento;
            DataExpira = dataExpira;
            Total = total;
            Totalpago = totalpago;
            Pagador = pagador;
            Documento = documento;
            Endereco = endereco;
            Email = email;
        }

        public string Numero { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public DateTime DataExpira { get; private set; }
        public decimal Total { get; private set; }
        public decimal Totalpago { get; private set; }
        public string Pagador { get; private set; }
        public string Documento { get; private set; }
        public string Endereco { get; private set; }
        public string Email { get; private set; }

    }
    public class Boleto : Pagamento
    {
        public string CodigoBarra { get; set; }
        public string NumeroBoleto { get; set; }

    }
    public class Cartao : Pagamento
    {
        public string NomeTitular { get; set; }
        public string NumeroCartao { get; set; } //so os 4 ultimos digitor
        public string NumeroUltimaTranzacao { get; set; }
    }
    public class PayPay : Pagamento
    {
        public string CodigoTranzacao { get; set; }
    }
}
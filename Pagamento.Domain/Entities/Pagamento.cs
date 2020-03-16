using System;
using Pagamento.Domain.ValidadandoObjetos;

namespace Pagamento.Domain.Entities
{
    public abstract class Pagamento 
    //abstract nao deixa estancia direto, pede um dos tipos a baixa junto.
    {
        //segue mesmo modelo estruturado na entiti "Estudante"
        protected Pagamento(DateTime dataPagamento, DateTime dataExpira, decimal total, decimal totalpago, string pagador, Documento documento, string endereco, string email)
        {
           //NewGuid - Gerando Id da entiti
           //ToString - Converte pra string
           //Replace - Remove "-" e deixa " " vazio.
           //Substring - Pega os 10 primeiros caracteres
           //ToUpper - Deixa em caixa Alta 
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

        //https://app.balta.io/player/1975/modules/1/classes/8

        public string Numero { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public DateTime DataExpira { get; private set; }
        public decimal Total { get; private set; }
        public decimal Totalpago { get; private set; }
        public string Pagador { get; private set; }
        public Documento Documento { get; private set; }
        public string Endereco { get; private set; }
        public string Email { get; private set; }

    }
    
}

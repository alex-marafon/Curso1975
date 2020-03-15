using System;

namespace Pagamento.Domain.Entities
{
   public class Cartao : Pagamento
    {
        public Cartao(
            string nomeTitular, 
            string numeroCartao, 
            string numeroUltimaTranzacao, 
            DateTime dataPagamento, 
            DateTime dataExpira, 
            decimal total, 
            decimal totalpago, 
            string pagador, 
            string documento, 
            string endereco, 
            string email): base( 
                dataPagamento,  
                dataExpira,  
                total,  
                totalpago, 
                pagador,  
                documento,  
                endereco,  
                email)
        {
            NomeTitular = nomeTitular;
            NumeroCartao = numeroCartao;
            NumeroUltimaTranzacao = numeroUltimaTranzacao;
        }

        public string NomeTitular { get; private set; }
        public string NumeroCartao { get; private set; } //so os 4 ultimos digitor
        public string NumeroUltimaTranzacao { get; private set; }
    }
}
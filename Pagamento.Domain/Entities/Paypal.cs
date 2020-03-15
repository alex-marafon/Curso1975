using System;

namespace Pagamento.Domain.Entities
{
    public class PayPay : Pagamento
    {
        public PayPay(string codigoTranzacao,
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
            CodigoTranzacao = codigoTranzacao;
        }

        public string CodigoTranzacao { get; private set; }
    }
}
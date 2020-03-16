using System;
using Pagamento.Domain.ValidadandoObjetos;

namespace Pagamento.Domain.Entities
{ 
    public class Boleto : Pagamento
    {
        //Quando vc herda de uma Entiti que tem Construtor declarado, vc tem que informar as propriedades
        // junta as propriedades declaradas vc informa as propriedades da entiti que esta berdando
        // e apos o fechamento declara  " : base() " e informa a variavel que esta recebedo. 
        // como mostrado no exemplo a baixa  que a Entiti "Boleto" herda de "Pagamento" que por sua vez
        // deve conter as mesmas declaração do construtor da Entiti Pagamento. Como demostrado a baixo.
        public Boleto(
            string codigoBarra, 
            string numeroBoleto, 
            DateTime dataPagamento, 
            DateTime dataExpira, 
            decimal total, 
            decimal totalpago, 
            string pagador, 
            Documento documento,
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
            CodigoBarra = codigoBarra;
            NumeroBoleto = numeroBoleto;
        }

        public string CodigoBarra { get; private set; }
        public string NumeroBoleto { get; private set; }

    }
}
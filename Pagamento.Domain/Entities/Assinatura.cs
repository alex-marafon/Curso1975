using System;
using System.Collections.Generic;

namespace Pagamento.Domain.Entities
{
   
    public class Assinatura
    {

         //segue o mesmo padrao aplicado na Entiti Estudante. 
        private IList<Pagamento> _pagamentos; //"Passo 1"
        public Assinatura( DateTime? dataEspiracao)
        {
            DataCriacao = DateTime.Now;
            DataAtualizacao = DateTime.Now;
            DataEspiracao = dataEspiracao;
            Ativo = true;
            _pagamentos = new List<Pagamento>(); //"Passo 2"
        }

        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        public DateTime? DataEspiracao { get; private set; }
        public bool Ativo  { get; private set; } 
        public IReadOnlyCollection<Pagamento> Pagamentos { get; private set;}
        //"Passo 3"   definimos como privado e Mudamos "List<>" para "IReadOnlyCollection" 



        //Esses metodos estao sendo chamados no Pagamento.Tests
        public void AddPagamento(Pagamento pagamentos){//Metodo para adicionar pagamento passando por validação
            _pagamentos.Add(pagamentos);
        }
        public void Ativador(){//Metodo para Definir Assinatura "ativa ou nao" passando por validação.
            Ativo= true;
            DataAtualizacao = DateTime.Now;

        }
        public void Dezativador(){//Metodo para Definir Assinatura "ativa ou nao" passando por validação.
            Ativo= false;
            DataAtualizacao = DateTime.Now;

        }
    }
}
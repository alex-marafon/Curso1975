using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pagamento.Domain.Entities;

namespace Pagamento.Tests.Entities
{
    [TestClass]
    public class TestEstudantes
    {
      [TestMethod]
      public void TestMethod1()
       {
           //Obs Lembrando que class abstract nao pode ser "Estanciada" direto
           //No nosso caro a Entiti "Pagamento" esta declarada como "Abstract" essa declaração foi feita para corrigir um falha de negocio,
           // dessa forma vc fecha ela, forçando a pessoa a usar a regra ne negocio, os metodos que estao declarados na Entidade "Pagamento"
           // que sao as 3 formas de pagamento .. Boleto, Cartao e Paypal com seus respectivos juntamente com seus parametros 
           //Exemplo       ->    var paypa = new Boleto("Parametros","..",..);
           var estudante =new Estudante("Alex","Marafon","123456","lambari@gmail.com");

            var assinatura = new Assinatura(null);
            estudante.AddAssinatura(assinatura);
            
        }  
    }
}
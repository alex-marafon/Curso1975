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
           var estudante =new Estudante("Alex","Marafon","123456","lambari@gmail.com");

            var assinatura = new Assinatura(null);
            estudante.AddAssinatura(assinatura);
        }  
    }
}
using System.Collections.Generic;
using System.Linq;
using Pagamento.Domain.ValidadandoObjetos;

namespace Pagamento.Domain.Entities
{
    public class Estudante
    {
        private IList<Assinatura> _assinaturas; //"Passo 1"
        //criamos uma lista privada e atrobuimos a '_assinaturas'
        public Estudante(Nome nome, string sobreNome, Documento documento, string email)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();  //"Passo 2"
            //Iniciamos ela junto ao construtor 
        }

        public Nome Nome { get; private set; }
        public string SobreNome { get;  private set; }
        public Documento Documento { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }

        //public List<Assinatura> Assinaturas { get; private set; }  //List<> tem uma infinidade de recurso
        public IReadOnlyCollection<Assinatura> Assinaturas { get {return _assinaturas.ToArray();}}  //"Passo 3" //Muda o "private set;" por...
        //IReadOnlyCollection tem menos metodos, nao tem o metodo Add.
        //Ao utilizar ele vc perde a metodo "Add" para corrigira isso segue  passos " Passo 0"  
        public void AddAssinatura(Assinatura assinatura){
            //valida informação.
            //se ja tiver uma assinatura ativa, cancela.

            //Cancela todas as outras assiaturas, e deixa essa como principal
            foreach (var ass in Assinaturas)
            {
                ass.Dezativador(); //Ou Ativa de acordo com a necessidade - Observe que isso foi definido na entiti "Assinatura"
            }
            _assinaturas.Add(assinatura);  //"Passo 4"
            //Utilizando o retorno da propriedade "_assinaturas" 


        }
    }
}
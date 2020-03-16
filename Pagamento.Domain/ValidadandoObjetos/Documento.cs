using Pagamento.Domain.Enums;

namespace Pagamento.Domain.ValidadandoObjetos
{
    public class Documento
    {
        public Documento(string numero, EDocumento Tipo)
        {
            Numero = numero;
            Tipo = Tipo;

        }

        public string Numero { get; private set; }
        public EDocumento Tipo { get; private set; }
        
    }
}
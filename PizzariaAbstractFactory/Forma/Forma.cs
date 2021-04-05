using PizzariaAbstractFactory.Enum;
using System;

namespace PizzariaAbstractFactory
{
    public abstract class Forma
    {

        public Tamanho Tamanho { get; set; }

        protected Forma(Tamanho tamanho)
        {
            Tamanho = tamanho;
        }

        public abstract void Enformar(Pizza pizza);


        public static Forma SelecionarForma(Tamanho tamanho)
        {
            switch (tamanho)
            {
                case Tamanho.Pequena:
                    return new FormaPequena(tamanho);
                case Tamanho.Media:
                    return new FormaMedia(tamanho);
                case Tamanho.Grande:
                    return new FormaGrande(tamanho);
                default:
                    throw new ApplicationException("Tamanho da forma desconhecido.");
            }
        }

    }
}

using PizzariaAbstractFactory.Enum;
using System;

namespace PizzariaAbstractFactory
{
    public class PedidoPizza
    {

        public static Pizza Montar(string sabor, Tamanho tamanho)
        {
            switch (tamanho)
            {
                case Tamanho.Mini:
                    return new PizzaMini(sabor, tamanho);
                case Tamanho.Pequena:
                    return new PizzaPequena(sabor, tamanho);
                case Tamanho.Media:
                    return new PizzaMedia(sabor, tamanho);
                case Tamanho.Grande:
                    return new PizzaGrande(sabor, tamanho);
                default:
                    throw new ApplicationException("Tamanho da pizza desconhecido.");
            }
        }

    }
}

using PizzariaAbstractFactory.Enum;
using PizzariaAbstractFactory.MontarPizza;
using System;

namespace PizzariaAbstractFactory
{
    public class Pizzaria
    {

        private readonly Pizza _pizza;
        private readonly Forma _forma;


        public Pizzaria(PizzariaFactory factory, Pizza pizza)
        {
            _pizza = factory.FazerPizza(pizza.Sabor, pizza.Tamanho);
            _forma = factory.SelecionarForma();
        }


        public void RealizarAtendimento()
        {
            _forma.Enformar(_pizza);
        }

        public static Pizzaria MontarPizza(Pizza pizza)
        {
            switch (pizza.Tamanho)
            {
                case Tamanho.Mini:
                    return new Pizzaria(new MontarPizzaMiniFactory(), pizza);
                case Tamanho.Pequena:
                    return new Pizzaria(new MontarPizzaPequenaFactory(), pizza);
                case Tamanho.Media:
                    return new Pizzaria(new MontarPizzaMediaFactory(), pizza);
                case Tamanho.Grande:
                    return new Pizzaria(new MontarPizzaGrandeFactory(), pizza);
                default:
                    throw new ApplicationException("Não foi possível identificar a pizza");
            }
        }
    }
}

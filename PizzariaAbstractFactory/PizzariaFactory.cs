using PizzariaAbstractFactory.Enum;

namespace PizzariaAbstractFactory
{
    public abstract class PizzariaFactory
    {

        public abstract Forma SelecionarForma();

        public abstract Pizza FazerPizza(string sabor, Tamanho tamanho);
    }
}

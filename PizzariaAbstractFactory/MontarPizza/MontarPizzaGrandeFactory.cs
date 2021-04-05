using PizzariaAbstractFactory.Enum;

namespace PizzariaAbstractFactory
{
    public class MontarPizzaGrandeFactory : PizzariaFactory
    {
        public override Pizza FazerPizza(string sabor, Tamanho tamanho)
        {
            return PedidoPizza.Montar(sabor, tamanho);
        }

        public override Forma SelecionarForma()
        {
            return Forma.SelecionarForma(Tamanho.Grande);
        }
    }
}
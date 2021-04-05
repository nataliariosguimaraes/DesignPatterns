using PizzariaAbstractFactory.Enum;

namespace PizzariaAbstractFactory.MontarPizza
{
    public class MontarPizzaMiniFactory : PizzariaFactory
    {
        public override Pizza FazerPizza(string sabor, Tamanho tamanho)
        {
            return PedidoPizza.Montar(sabor, tamanho);
        }

        public override Forma SelecionarForma()
        {
            return Forma.SelecionarForma(Tamanho.Pequena);
        }
    }
}

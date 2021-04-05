using PizzariaAbstractFactory.Enum;
using System.Collections.Generic;


namespace PizzariaAbstractFactory.MontarPizza
{
    public class MontarPizzaFacoty
    {
        public static void Executar()
        {
            var pizzaSabor = new List<Pizza>
            {
                PedidoPizza.Montar("Calabressa", Tamanho.Pequena),
                PedidoPizza.Montar("Mussarela", Tamanho.Media),
                PedidoPizza.Montar("Lombo com abacaxi", Tamanho.Grande)
            };

            pizzaSabor.ForEach(v => Pizzaria.MontarPizza(v).RealizarAtendimento());
        }
    }
}

using PizzariaAbstractFactory.Enum;
using System;

namespace PizzariaAbstractFactory
{
    public class FormaMedia : Forma
    {
        public FormaMedia(Tamanho tamanho) : base(tamanho) { }
        public override void Enformar(Pizza pizza)
        {
            Console.WriteLine("Enformando pizza media " + pizza.Tamanho);
        }
    }
}

using PizzariaAbstractFactory.Enum;
using System;

namespace PizzariaAbstractFactory
{
    public class FormaPequena : Forma
    {

        public FormaPequena(Tamanho tamanho) : base(tamanho) { }
        public override void Enformar(Pizza pizza)
        {
            Console.WriteLine("Enformando pizza pequena " + pizza.Tamanho);
        }
    }
}

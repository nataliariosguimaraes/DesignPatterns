using PizzariaAbstractFactory.Enum;
using System;

namespace PizzariaAbstractFactory
{
    public class FormaGrande : Forma
    {
        public FormaGrande(Tamanho tamanho) : base(tamanho) { }
        public override void Enformar(Pizza pizza)
        {
            Console.WriteLine("Enformando pizza grande " + pizza.Tamanho);
        }
    }
}

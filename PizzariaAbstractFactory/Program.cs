using PizzariaAbstractFactory.MontarPizza;
using System;

namespace PizzariaAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Montar Pizza");

            MontarPizzaFacoty.Executar();

            Console.ReadKey();
            Console.Clear();
        }
    }
}

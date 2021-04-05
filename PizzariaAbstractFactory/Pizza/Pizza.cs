using PizzariaAbstractFactory.Enum;

namespace PizzariaAbstractFactory
{
    public class Pizza
    {
        public Tamanho Tamanho { get; set; }
        public string Sabor { get; set; }

        protected Pizza(string sabor, Tamanho tamanho)
        {
            Tamanho = tamanho;
            Sabor = sabor;
        }

    }
}
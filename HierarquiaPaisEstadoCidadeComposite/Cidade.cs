using HierarquiaPaisEstadoCidadeComposite.Interface;
using System;

namespace HierarquiaPaisEstadoCidadeComposite
{
    public class Cidade : ILocal
    {
        public string Localidade { get; set; }

        public Cidade(string localidade)
        {
            Localidade = localidade;
        }
        public void ExibirHierarquia(int sub)
        {
            Console.WriteLine(new string('-', sub) + Localidade);
        }
    }
}

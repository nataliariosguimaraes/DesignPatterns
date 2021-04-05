using HierarquiaPaisEstadoCidadeComposite.Interface;
using System;

namespace HierarquiaPaisEstadoCidadeComposite
{
    public class Estado : ILocal
    {
        public string Localidade { get; set; }

        public Estado(string localidade)
        {
            Localidade = localidade;
        }
        public void ExibirHierarquia(int sub)
        {
            Console.WriteLine(new string('-', sub) + Localidade);
        }
    }
}

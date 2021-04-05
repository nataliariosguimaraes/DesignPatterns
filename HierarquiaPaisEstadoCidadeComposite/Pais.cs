using HierarquiaPaisEstadoCidadeComposite.Interface;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HierarquiaPaisEstadoCidadeComposite
{
    public class Pais : ILocal, IEnumerable<ILocal>
    {
     
        private readonly List<ILocal> _lista = new List<ILocal>();
        public string Localidade { get; set; }

        public Pais(string localidade)
        {
            Localidade = localidade;
        }

        public void AdicionarHierarquiaFilha(ILocal hierarquiaFilha)
        {
            _lista.Add(hierarquiaFilha);
        }


        public void ExibirHierarquia(int sub)
        {
            Console.WriteLine(new string('-', sub) + Localidade);

            foreach (var localidade in _lista)
            {
                localidade.ExibirHierarquia(sub + 2);
            }
        }

        public IEnumerator<ILocal> GetEnumerator()
        {
            return ((IEnumerable<ILocal>)_lista).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<ILocal>)_lista).GetEnumerator();
        }
    }
}

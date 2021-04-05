using System;
using System.Collections.Generic;
using System.Text;

namespace PadraoTomadaAdapter
{
    public class TomadaAdapter : IPadraoTomadaA 
    {

        private readonly IPadraoTomadaB _padraoTomadaB;

        public TomadaAdapter(IPadraoTomadaB padraoTomadaB)
        {
            _padraoTomadaB = padraoTomadaB;
        }

      
        public void EncaixeUniversal()
        {
            _padraoTomadaB.EncaixeEuropeu();
        }
    }
}

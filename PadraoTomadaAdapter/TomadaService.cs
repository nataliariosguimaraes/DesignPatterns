using System;

namespace PadraoTomadaAdapter
{
    internal class TomadaService 
    {
        private readonly IPadraoTomadaA _padraoTomadaA;

        public TomadaService(IPadraoTomadaA padraoTomadaA)
        {
            _padraoTomadaA = padraoTomadaA;
        }

        public void LigarTomada()
        {
            _padraoTomadaA.EncaixeUniversal();
        }
    }
}
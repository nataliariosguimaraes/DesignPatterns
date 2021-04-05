namespace PadraoTomadaAdapter
{
    public class ExecucaoAdapter
    {
        public static void Executar()
        {
            var tomadaPadraoA = new TomadaService(new PadraoTomadaA());
            tomadaPadraoA.LigarTomada();
                        

            var tomadaPadraoB = new TomadaService(new TomadaAdapter(new PadraoTomadaB()));
            tomadaPadraoB.LigarTomada();
        }
    }
}

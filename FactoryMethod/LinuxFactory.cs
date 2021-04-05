namespace SistemaOperacionalFactoryMethod
{
    public class LinuxFactory : SistemaOperacionalFactory
    {
        public override SistemaOperacionaIInicializar CriarInicializacaoSistemaOperacional(string sistemaOperacional)
        {
            return new LinuxInicializar(sistemaOperacional);
        }
    }
}
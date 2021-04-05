namespace SistemaOperacionalFactoryMethod
{
    public class WindowsFactory : SistemaOperacionalFactory
    {
        public override SistemaOperacionaIInicializar CriarInicializacaoSistemaOperacional(string sistemaOperacional)
        {
            return new WindowsInicializar(sistemaOperacional);
        }
    }
}
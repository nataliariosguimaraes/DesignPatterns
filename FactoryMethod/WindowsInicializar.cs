using System;

namespace SistemaOperacionalFactoryMethod
{
    internal class WindowsInicializar : SistemaOperacionaIInicializar
    {
        public WindowsInicializar(string sistemaOperacional) : base(sistemaOperacional)
        {
            SistemaOperacional = sistemaOperacional;
        }


        public override ExecucaoSistemaOperacional Iniciar()
        {
            Console.WriteLine("Iniciando Windows");
            var inicicializar = new ExecucaoSistemaOperacional(SistemaOperacional);
            inicicializar.IniciarSistemaOperacional();
            return inicicializar;
        }
    }
}
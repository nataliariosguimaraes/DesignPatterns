using System;

namespace SistemaOperacionalFactoryMethod
{
    internal class LinuxInicializar : SistemaOperacionaIInicializar
    {
        public LinuxInicializar(string sistemaOperacional) : base(sistemaOperacional)
        {
            SistemaOperacional = sistemaOperacional;
        }

        public override ExecucaoSistemaOperacional Iniciar()
        {
            Console.WriteLine("Iniciando Linux");
            var inicicializar = new ExecucaoSistemaOperacional(SistemaOperacional);
            inicicializar.IniciarSistemaOperacional();
            return inicicializar;
        }
    }
    
}
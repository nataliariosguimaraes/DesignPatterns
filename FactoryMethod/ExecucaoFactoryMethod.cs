using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaOperacionalFactoryMethod
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sistemaOperacionalWindows = SistemaOperacionalFactory.Sistemaoperacional(SistemaOperacional.Windows)
                                 .CriarInicializacaoSistemaOperacional("abrir windows")
                                 .Iniciar();

            sistemaOperacionalWindows.ExecutarSistemaOperacional("executar inicializacao windows");
            sistemaOperacionalWindows.IniciarSistemaOperacional();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            var sistemaOperacionalLinux = SistemaOperacionalFactory.Sistemaoperacional(SistemaOperacional.Linux)
                                  .CriarInicializacaoSistemaOperacional("abrir linux")
                                  .Iniciar();

            sistemaOperacionalLinux.ExecutarSistemaOperacional("executar inicializacao linux");
            sistemaOperacionalLinux.IniciarSistemaOperacional();

        }
    }
}

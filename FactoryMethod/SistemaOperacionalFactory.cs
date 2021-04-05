using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaOperacionalFactoryMethod
{
    public abstract class SistemaOperacionalFactory
    {

        public abstract SistemaOperacionaIInicializar CriarInicializacaoSistemaOperacional(string sistemaOperacional);


        public static SistemaOperacionalFactory Sistemaoperacional(SistemaOperacional sistemaOperacional)
        {
            if (sistemaOperacional == SistemaOperacional.Linux)
                return new LinuxFactory();
            if (sistemaOperacional == SistemaOperacional.Windows)
                return new WindowsFactory();

            throw new ApplicationException("Sistema Operacional não reconhecido.");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaOperacionalFactoryMethod
{
    public abstract class SistemaOperacionaIInicializar
    {
        protected string SistemaOperacional { get; set; }
        protected SistemaOperacionaIInicializar (string sistemaOperacional)
        {
            SistemaOperacional = sistemaOperacional;
        }

        public abstract ExecucaoSistemaOperacional Iniciar();
    }
}

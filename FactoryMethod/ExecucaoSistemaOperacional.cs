using System;

namespace SistemaOperacionalFactoryMethod
{
    public class ExecucaoSistemaOperacional
    {
        public string Execucao { get; set; }
        public bool Opened { get; set; }

        public ExecucaoSistemaOperacional(string execucao)
        {
            Execucao = execucao;
        }

        public void ExecutarSistemaOperacional(string execucao)
        {
            Console.WriteLine("Executando Commando: " + execucao);
        }

        public void IniciarSistemaOperacional()
        {
            Console.WriteLine("Iniciar Sistema Operacional");
        }

        public void ReiniciarSistemaOperacional()
        {
            Console.WriteLine("Reiniciar Sistema Operacional");
        }

        public void DesligarSistemaOperacional()
        {
            Console.WriteLine("Desliga Sistema Operacional");
        }
    }
}
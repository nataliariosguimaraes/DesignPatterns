using System;

namespace CampeonatoStategy
{
    public class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Brasileirao");
            Console.WriteLine("2 - Liberadores");
            Console.WriteLine("3 - Copa do Brasil");
            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            var campeonato = new CampeonatoContext();
         
         


            switch (opcao.KeyChar)
            {
                case '1':
                    campeonato.EscolherCampeonato(new Brasileirao());
                    break;
                case '2':
                    campeonato.EscolherCampeonato(new Libertadores());
                    break;
                case '3':
                    campeonato.EscolherCampeonato(new CopaDoBrasil());
                    break;
            }

            campeonato.ParticiparCampeonato();

            Console.ReadKey();
            Console.Clear();
          

        }


    }
}


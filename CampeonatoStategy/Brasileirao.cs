using System;

namespace CampeonatoStategy
{
    public class Brasileirao : ICampeonato
    {
        public void DisputarCampeonato(ICampeonato campeonato)
        {
            Console.WriteLine("Disputa com times do Brasil 1 divisao");
        }
    }
}

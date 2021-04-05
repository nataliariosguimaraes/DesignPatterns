using System;

namespace CampeonatoStategy
{
    public  class Libertadores : ICampeonato
    {
        public void DisputarCampeonato(ICampeonato campeonato)
        {
            Console.WriteLine("Disputa com times da America");
        }
    }
}

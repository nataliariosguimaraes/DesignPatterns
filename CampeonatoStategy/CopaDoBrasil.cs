using System;
using System.Collections.Generic;
using System.Text;

namespace CampeonatoStategy
{
    public class CopaDoBrasil : ICampeonato
    {
        public void DisputarCampeonato(ICampeonato campeonato)
        {
            Console.WriteLine("Disputa com times do Brasil 1,2,3 4 divisão");
        }
    }
}

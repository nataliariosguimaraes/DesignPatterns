using System;
using System.Collections.Generic;

namespace CampeonatoStategy
{
    public class CampeonatoContext
    {

        private ICampeonato _campeonato;


        public CampeonatoContext() { }
        public CampeonatoContext(ICampeonato campeonato)
        {
            _campeonato = campeonato;
        }


        public void EscolherCampeonato(ICampeonato campeonato)
        {
            _campeonato = campeonato;
        }


        public void ParticiparCampeonato()
        {
            _campeonato.DisputarCampeonato(_campeonato);

     

        }


    }
}

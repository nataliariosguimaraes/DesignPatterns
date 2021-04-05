using System;
using System.Collections.Generic;
using System.Text;

namespace HierarquiaPaisEstadoCidadeComposite.Interface
{
    public interface ILocal
    {
        string Localidade { get; set; }
        void ExibirHierarquia(int sub);
    }
}

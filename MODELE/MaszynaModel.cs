using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAPR_POLCA.MODELE
{
    /// <summary>
    /// Maszyna/Miejsce na której są wykonywane wykonania operacji
    /// </summary>
    public class MaszynaModel
    {
        public int NrMaszyny { get; set; }
        public string Nazwa { get; set; }

        public MaszynaModel()
        {

        }

        public MaszynaModel (int _numer, string _nazwa)
        {
            this.Nazwa = _nazwa;
            this.NrMaszyny = _numer; 
        }

    }
}

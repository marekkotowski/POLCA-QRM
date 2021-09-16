using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAPR_POLCA.MODELE
{
    /// <summary>
    /// Wyrob/Przedmio produkcji
    /// </summary>
    public class WyrobModel
    {
        public int IDWyrobu { get; set; }
        public string NumerRysunku { get; set; }
        public string NazwaWyrobu { get; set; }
        public List<OperacjaTechnologiczna> Operacje { get; set; }


        public WyrobModel()
        {
            this.Operacje = new List<OperacjaTechnologiczna>(); 
        }

        /// <summary>
        /// Tworzy nowy wyrób o określonym numerze rysunku
        /// </summary>
        /// <param name="_nrRysunku"></param>
        public WyrobModel(string _nrRysunku)
        {
            this.NumerRysunku = _nrRysunku;
            this.Operacje = new List<OperacjaTechnologiczna>();
        }

        /// <summary>
        /// Tworzy nowy wyrób o określonym numerze rysunku i nazwie wyrobu
        /// </summary>
        /// <param name="_nrRysunku"></param>
        /// <param name="_nazwaWyrobu"></param>
        public WyrobModel(string _nrRysunku, string _nazwaWyrobu)
        {
            this.NumerRysunku = _nrRysunku;
            this.NazwaWyrobu = _nazwaWyrobu;
            this.Operacje = new List<OperacjaTechnologiczna>();
        }

    }
}

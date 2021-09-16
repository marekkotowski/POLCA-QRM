using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAPR_POLCA.MODELE
{
    /// <summary>
    /// Pozycja zlecenia
    /// </summary>
    public class PozycjaZleceniaModel
    {
        public int ID { get; set; }
        public string NumerRysunku { get; set; }
        public decimal IloscZamowiona { get; set; }
        public decimal IloscWykonana { get; set; }
        public string NumerZlecenia { get; set; }

        public string DanePozycjizlecenia { 
            get => $"{NumerRysunku} {IloscZamowiona}";
            set { } }

        public PozycjaZleceniaModel()
        { 
        }

        /// <summary>
        /// Tworzy nową pozycje dla Zlecenia z numrem rysunku i ilością do wykonania
        /// </summary>
        /// <param name="_NumerZlecenia"></param>
        /// <param name="_NumerRysunku"></param>
        /// <param name="_iloscZam"></param>
        public PozycjaZleceniaModel(string _NumerZlecenia, string _NumerRysunku, decimal _iloscZam)
        {
            this.NumerRysunku = _NumerRysunku;
            this.NumerZlecenia = _NumerZlecenia;
            this.IloscZamowiona = _iloscZam;
            this.IloscWykonana = 0; 
        }

    }
}

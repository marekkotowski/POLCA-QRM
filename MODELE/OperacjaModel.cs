using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAPR_POLCA.MODELE
{
    /// <summary>
    /// Operacja w Proceseie Technologicznym Zlecenia
    /// Określa zlecenia, wyrob, stanowisko i ilośc do wykonania
    /// </summary>
    public class OperacjaModel
    {
        public string NrZlecenia { get; set; }
        public string NumerRysunku { get; set; }
        public int NrOperacji { get; set; }
        public decimal  Ilosc { get; set; }
        public int CzasOperacjiMinuty { get; set; }
        public DateTime TerminWykonania { get; set; }
        public string Stanowisko { get; set; }
        public bool Wykonana { get; set; }

        public ZlecenieModel Zlecenie { get; set;  }
        public OperacjaTechnologiczna  KartaTechnologiczna { get; set; }


        public OperacjaModel()
        { 
        
        }

        /// <summary>
        /// Tworzy operację dla zlecenia na podstawie Operacji Technologicznej wyrobu na zleceniu
        /// </summary>
        /// <param name="_zlec"></param>
        /// <param name="_karta"></param>
        /// <param name="_terminwykonania"></param>
        public OperacjaModel(ZlecenieModel _zlec, OperacjaTechnologiczna _karta, DateTime _terminwykonania)
        {
            this.NrZlecenia = _zlec.NumerZlecenia;
            this.NumerRysunku = _zlec.Wyrob.NumerRysunku;
            this.KartaTechnologiczna = _karta;
            this.NrOperacji = _karta.NrOperacji;
            this.Ilosc = _zlec.IloscZamowiona;
            this.Stanowisko = _karta.SymbolStanowiska; 
            this.TerminWykonania = _terminwykonania;
            this.CzasOperacjiMinuty = (int) _karta.CzasPrzygotowawczyS/60 + (int)this.Ilosc*(_karta.CzasJednostkowyS/60 );
            this.Zlecenie = _zlec;
            this.Wykonana = false; 

        }

        /// <summary>
        /// Lista operacji dla wybranego zlecenia
        /// </summary>
        /// <param name="_zlec"></param>
        /// <returns></returns>
        public static List<OperacjaModel> OperacjeDlaZlecenia(ZlecenieModel _zlec)
        {
            List<OperacjaModel> Operacje = new List<OperacjaModel>();
            DateTime terminWykoania = _zlec.PlanowanaDataZakonczenia; 

            foreach (OperacjaTechnologiczna karta in _zlec.Wyrob.Operacje.OrderByDescending(x => x.NrOperacji))
            {
                OperacjaModel operacja = new OperacjaModel(_zlec, karta, terminWykoania);
                terminWykoania = terminWykoania.AddMinutes(-1 * operacja.CzasOperacjiMinuty);
                Operacje.Add(operacja);
            }

            return Operacje.OrderBy(x => x.NrOperacji).ToList(); ;        
        }









    }
}

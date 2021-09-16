using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAPR_POLCA.MODELE
{
    /// <summary>
    /// KartaPOLCA paruje dwie kolejne operacje w procesie produkcyjnym
    /// Termin wykonania karty to termin wykonania drugiej operaci
    /// CzasPrzejsciaMInuty - łączny czas realizacji obu operacji
    /// Pierwsza KartaPOLCA w procesie produkcyjnym zlecenia otrzymuje CzyPierwsza  = true; 
    /// </summary>
    public class KartaPolcaModel
    {
        public string NumerZlecenia { get; set; }
        public int NumerPierwszejOperacji { get; set; }
        public int NumerDrugiejOperacji { get; set; }
        public string StanowiskoPierwszejOperacji { get; set; }
        public string StanowiskoDrugiejOperacji { get; set; }
        public string RealizownaNaStanowisku { get; set; }
        public DateTime TerminWykonania { get; set; }
        public int CzasPrzejsciaKartyMinuty { get; set; }
        public bool Wykonana { get; set; }
        public bool CzyPierwsza { get; set; }
        public int OczekujaceNaNastepnymStanowisku { get; set; }

        public ZlecenieModel Zlecenie { get; set; }
        public OperacjaModel OperacjaPierwsza { get; set; }
        public OperacjaModel OperacjaDruga { get; set;}


        public KartaPolcaModel()
        { 
        
        }

        /// <summary>
        /// Tworzy Kartę POLCA dla zlecenia z dwóch kolejnych operacji
        /// </summary>
        /// <param name="_zlec"></param>
        /// <param name="_pierwszaOperacja"></param>
        /// <param name="_drugaOperacja"></param>
        public KartaPolcaModel( ZlecenieModel _zlec, OperacjaModel _pierwszaOperacja, OperacjaModel _drugaOperacja)
        {
            this.NumerZlecenia = _zlec.NumerZlecenia;
            this.NumerPierwszejOperacji = _pierwszaOperacja.NrOperacji;
            this.NumerDrugiejOperacji = _drugaOperacja.NrOperacji;
            this.StanowiskoPierwszejOperacji = _pierwszaOperacja.Stanowisko;
            this.StanowiskoDrugiejOperacji = _drugaOperacja.Stanowisko;
            this.CzasPrzejsciaKartyMinuty = _pierwszaOperacja.CzasOperacjiMinuty + _drugaOperacja.CzasOperacjiMinuty;
            this.Wykonana = false;
            this.Zlecenie = _zlec;
            this.OperacjaPierwsza = _pierwszaOperacja;
            this.OperacjaDruga = _drugaOperacja;
            this.TerminWykonania = _drugaOperacja.TerminWykonania;
            this.RealizownaNaStanowisku = ""; 
            this.CzyPierwsza = false; 
        }

        /// <summary>
        /// Sprawdza ilość kart POLCA oczekujących na wykonanie
        /// Karty których stanowisko jest na drugiej operacji 
        /// </summary>
        /// <param name="_kodStanowiska"></param>
        /// <returns></returns>
        public int PoliczOczekujaceNaStanowisku(string _kodStanowiska)
        {
            int ileOczekujacych = 0;
            List<KartaPolcaModel> KartyOczekujace = APP.APP.KartyPOLCA.Where(x => x.StanowiskoDrugiejOperacji == _kodStanowiska && x.Wykonana == false && x.RealizownaNaStanowisku=="" && x.OperacjaPierwsza.Wykonana).ToList();
            return KartyOczekujace.Count; 
        }

        /// <summary>
        /// Zlicza czas reazliacji Kart POLCA oczekujących na wybranym stanowisku 
        /// </summary>
        /// <param name="_kodStanowiska"></param>
        /// <returns></returns>
        public int PoliczCzasOczekujacychNaKolejnymStanowisku (string _kodStanowiska)
        {
            int IleMinutZajete = 0;
            List<KartaPolcaModel> KartyOczekujace = APP.APP.KartyPOLCA.Where(x => x.StanowiskoDrugiejOperacji == _kodStanowiska && x.Wykonana == false && x.RealizownaNaStanowisku == "" && x.OperacjaPierwsza.Wykonana).ToList();

            foreach (KartaPolcaModel karta in KartyOczekujace)
            {
                IleMinutZajete += karta.OperacjaDruga.CzasOperacjiMinuty; 
            }

            return IleMinutZajete; 
        }

        /// <summary>
        /// Wyszkuje kolejną Kartę POLCA w procesie produkcyjnym dla zlecenia
        /// </summary>
        /// <returns></returns>
        public KartaPolcaModel ZnajdzKolejnaKartePOLCA()
        {
            try
            {
                KartaPolcaModel NastepnaKarta = APP.APP.KartyPOLCA.First(x => x.NumerZlecenia == this.NumerZlecenia && x.StanowiskoPierwszejOperacji == this.StanowiskoDrugiejOperacji);
                return NastepnaKarta;
            }
            catch 
            {
            
            }
            return null; 

        }


        public string KolejneStanowisko()
        {
            if (this.CzyPierwsza) return this.StanowiskoDrugiejOperacji;

            try
            {
                return ZnajdzKolejnaKartePOLCA().StanowiskoDrugiejOperacji;
            }
            catch (Exception)
            {

                return "";
            }

            
        }


    }
}

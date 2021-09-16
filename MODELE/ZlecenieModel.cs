using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAPR_POLCA.MODELE
{
    /// <summary>
    /// Zlecenie Produkcyjne
    /// </summary>
    public class ZlecenieModel
    {
        public int ID { get; set; }
        public string NumerZlecenia { get; set; }
        public string NazwaZlecenia { get; set; }
        public string OpisZlecenia { get; set; }
        public string NumerRysunku { get; set; }
        public DateTime PlanowanaDataRozpoczecia { get; set; }
        public DateTime PlanowanaDataZakonczenia { get; set; }
        public StatusZlecenia Status { get; set; }
        public WyrobModel Wyrob { get; set; }
        public decimal IloscZamowiona { get; set; }
        public string NumerIIlosc 
        {
            get { return NumerZlecenia + "  " + IloscZamowiona.ToString(); }
            set { value = NumerZlecenia + "  " + IloscZamowiona.ToString();  }        
        }

        public System.Drawing.Color KolorZlecenia; 




        public ZlecenieModel()
        {
         
        }

        /// <summary>
        /// Tworzy nowe zlecenie dla wybranego wyrobu
        /// </summary>
        /// <param name="_wyrob"></param>
        public ZlecenieModel(WyrobModel _wyrob)
        {
            this.Wyrob = _wyrob;
            this.NumerRysunku = _wyrob.NumerRysunku;
            this.Status = StatusZlecenia.O; 
            this.NumerZlecenia = UtworzNumerZlecenia();

        }

        /// <summary>
        /// Tworzy nowe zlecenie dla określonym parametrów 
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="_nazwazlecenia">Nazwa Zlecenia</param>
        /// <param name="_opiszlecenia">Opis zlecenia</param>
        /// <param name="_planDataRozp">Planowana data rozpoczęcia</param>
        /// <param name="_planDataZak">Planowana data zakończenia</param>
        /// <param name="_status">Status zlecenia</param>
        /// <param name="_wyrob">wyrob na zleceniu</param>
        /// <param name="_iloscZamowiona">Ilość </param>
        public ZlecenieModel(int _id,  string _nazwazlecenia, string _opiszlecenia, DateTime _planDataRozp, DateTime _planDataZak, StatusZlecenia _status, WyrobModel _wyrob, decimal _iloscZamowiona)
        {
            this.ID = _id;
            this.NumerZlecenia = UtworzNumerZlecenia() ;
            this.NazwaZlecenia = _nazwazlecenia;
            this.OpisZlecenia = _opiszlecenia;
            this.PlanowanaDataRozpoczecia = _planDataRozp;
            this.PlanowanaDataZakonczenia = _planDataZak;
            this.NumerRysunku = _wyrob.NumerRysunku; 
            this.Wyrob = _wyrob;
            this.IloscZamowiona = _iloscZamowiona;
            this.Status = _status;
            //PozycjeZlecenia = new List<PozycjaZleceniaModel>();
            
        }


        /// <summary>
        /// Wyliczenie numeru zlecenia wg schematu rr-%n6  
        /// rr - ostatnie dwie liczby roku
        /// %n6 - kolejny numer zlecenia w roku uzupełniony do sześciu miejsc
        /// </summary>
        /// <returns></returns>
        public static string UtworzNumerZlecenia()
        {
            string lsNumer;
            int ilMiejsc = 6;

            string rok = DateTime.Now.Year.ToString();
            rok = rok.Substring(rok.Length - 2, 2);

            int ktoreZlecenie = APP.APP.KartotekaZlecen.Where(x=> x.NumerZlecenia.StartsWith(rok)).Count() + 1;
            lsNumer = $"{rok}{WypelnijNumer(ktoreZlecenie, ilMiejsc)}";

            return lsNumer;
        }

        /// <summary>
        /// wypełnia ciąg do określonej liczy znaków wiodącymi zerami
        /// </summary>
        /// <param name="liczba"></param>
        /// <param name="il_miejsc"></param>
        /// <returns></returns>
        static string WypelnijNumer(int liczba, int il_miejsc)
        {
            StringBuilder lsWypelnienie = new StringBuilder();
            string sliczba = liczba.ToString();

            for (int i=0; i < il_miejsc - sliczba.Length; i++)
            {
                lsWypelnienie.Append("0");
            }
            lsWypelnienie.Append(liczba.ToString()); 
            return lsWypelnienie.ToString(); 
        }
        



    }


    public enum StatusZlecenia
    { 
        O,  // Zarejestrowane,  - Opened
        S,  // Rozpoczęte,     - Started 
        C,   //Anulowane,     - Canceled
        E,   //Wyprodukowane,  - Ended 
        X  //Zamknięte       - Exit
    }
}

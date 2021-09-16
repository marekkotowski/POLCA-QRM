using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAPR_POLCA.MODELE
{
    /// <summary>
    /// Operacja Technologiczna dla wyrobu    /// 
    /// </summary>
    public class OperacjaTechnologiczna
    {
        public int ID { get; set; }
        public int NrOperacji { get; set; }
        public string OpisOperacji { get; set; }
        public int IDWyrobu { get; set; }
        public string SymbolStanowiska  { get; set; }
        public int CzasJednostkowyS { get; set; }
        public int CzasPrzygotowawczyS { get; set; }

        public OperacjaTechnologiczna()
        { 
        }

        /// <summary>
        /// Tworzy Operację Technologiczną dla wyrobu o zadanym numerze operacji, stanowisku, czasem jednostkowym i czasem przygotowawczym
        /// </summary>
        /// <param name="_idWyrobu"></param>
        /// <param name="_numerOperacji"></param>
        /// <param name="_stanowisko"></param>
        /// <param name="_tpj"></param>
        /// <param name="_tpz"></param>
        public OperacjaTechnologiczna(int _idWyrobu, int _numerOperacji, string _stanowisko, int _tpj, int _tpz)
        {
            this.IDWyrobu = _idWyrobu;
            this.NrOperacji = _numerOperacji;
            this.SymbolStanowiska = _stanowisko;
            this.CzasJednostkowyS = _tpj;
            this.CzasPrzygotowawczyS = _tpz; 
        }


    }
}

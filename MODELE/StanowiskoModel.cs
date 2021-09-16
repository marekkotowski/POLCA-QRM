using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAPR_POLCA.MODELE
{
    /// <summary>
    /// Stanowisko/Gniazdo Maszyn które jest docelowym miejscem wykonania operacji 
    /// </summary>
    public class StanowiskoModel
    {
        public int ID { get; set; }
        public string Symbol { get; set; }
        public string Nazwa { get; set;  }
        public List<MaszynaModel> Maszyny { get; set; }  //Lista Maszyn na Stanowisku

        public StanowiskoModel()
        {
            this.Maszyny = new List<MaszynaModel>(); 
        }

        public StanowiskoModel(string _symbol)
        {
            this.Symbol = _symbol;
            this.Maszyny = new List<MaszynaModel>();
        }

        /// <summary>
        /// Tworzy nowe stawisko o określonym symbolu/oznaczeniu i nazwie
        /// </summary>
        /// <param name="_symbol"></param>
        /// <param name="_nazwa"></param>
        public StanowiskoModel(string _symbol, string _nazwa)
        {
            this.Symbol = _symbol;
            this.Nazwa = _nazwa;
            this.Maszyny = new List<MaszynaModel>();
        }

    }
}

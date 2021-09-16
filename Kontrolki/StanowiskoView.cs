using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZAPR_POLCA.Kontrolki
{
    public partial class StanowiskoView : UserControl
    {
        public MODELE.StanowiskoModel Stanowisko;
        public MODELE.OperacjaModel Operacja;
        public MODELE.KartaPolcaModel KartaPolca; 
        public List<MODELE.KartaPolcaModel> KartyOczekujace = new List<MODELE.KartaPolcaModel>();

        public StanowiskoView()
        {
            InitializeComponent();
        }



        private void StanowiskoView_Load(object sender, EventArgs e)
        {
            //operacjaModelBindingSource.DataSource = Operacja;
            
        }

        public void Odswiez(MODELE.StanowiskoModel _stanowisko)
        {
            this.Stanowisko = _stanowisko;
            this.stanowiskoModelBindingSource.DataSource = this.Stanowisko;
            
            /*if (Stanowisko.KartaRealizowana != null)
            {
                KartaPolca = Stanowisko.KartaRealizowana;
            }
            else
            {
                pRealizowana.Controls.Clear(); 
            }
            */
            PobierzKartyOczekujace();
            ZnajdzRealizowanaOperacje();
        }

        public void PobierzKartyOczekujace()
        {
            string kolejneStanowisko=""; 
            KartyOczekujace.Clear();
            foreach (MODELE.KartaPolcaModel _kartPolca in APP.APP.KartyPOLCA.Where(x => x.Wykonana == false && x.RealizownaNaStanowisku == "" && ((x.CzyPierwsza && x.StanowiskoPierwszejOperacji == Stanowisko.Symbol && !x.OperacjaPierwsza.Wykonana ) ||(x.OperacjaPierwsza.Wykonana && x.StanowiskoDrugiejOperacji == Stanowisko.Symbol)))) 
            {
                if (_kartPolca.OperacjaPierwsza != Operacja && _kartPolca.OperacjaPierwsza != Operacja)
                {
                    if (_kartPolca.CzyPierwsza && !_kartPolca.OperacjaPierwsza.Wykonana )
                    {
                        kolejneStanowisko = _kartPolca.StanowiskoDrugiejOperacji;
                    }
                    else
                    {
                        MODELE.KartaPolcaModel NastepnaKarta = _kartPolca.ZnajdzKolejnaKartePOLCA();
                        if (NastepnaKarta != null)
                        {
                            kolejneStanowisko = NastepnaKarta.StanowiskoDrugiejOperacji;
                            // _kartPolca.OczekujaceNaNastepnymStanowisku = _kartPolca.PoliczCzasOczekujacychNaKolejnymStanowisku(kolejneStanowisko);                            
                        } 
                    }
                    if (kolejneStanowisko != "")
                    {
                        _kartPolca.OczekujaceNaNastepnymStanowisku = _kartPolca.PoliczOczekujaceNaStanowisku(kolejneStanowisko);
                    }
                    else
                    {
                        _kartPolca.OczekujaceNaNastepnymStanowisku = 0;
                    }
                    
                    KartyOczekujace.Add(_kartPolca);
                }
                
            }

            pKartyOczekujace.Controls.Clear(); 
            KartyOczekujace = KartyOczekujace.OrderBy(x => x.OczekujaceNaNastepnymStanowisku).ThenBy(x => x.TerminWykonania).ToList();
            foreach (MODELE.KartaPolcaModel _karta in KartyOczekujace)
            {
                KartaPOLCAView vKarta = new KartaPOLCAView(_karta);
                vKarta.BorderStyle = BorderStyle.None;
                vKarta.BackColor = _karta.Zlecenie.KolorZlecenia; 
                vKarta.Click += new EventHandler(vKarta_Clicked);
                pKartyOczekujace.Controls.Add(vKarta);
            }


        }

        private void btnWykonano_Click(object sender, EventArgs e)
        {
            Operacja.Wykonana = true;
            //Stanowisko.KartaRealizowana = null; 
            KartaPolca.RealizownaNaStanowisku = "";
            if (KartaPolca.CzyPierwsza)
            {
                KartaPolca.OperacjaPierwsza.Wykonana = true; 
            }
            else
            {
                KartaPolca.OperacjaDruga.Wykonana = true; 
            }

            if (KartaPolca.OperacjaPierwsza.Wykonana && KartaPolca.OperacjaDruga.Wykonana) { KartaPolca.Wykonana = true; }
            pRealizowana.Controls.Clear(); 
            this.Operacja = null;
            btnRozpocznij.Enabled = true;
            //operacjaModelBindingSource.DataSource = null; 
            PobierzKartyOczekujace();
        }

        private void ZnajdzRealizowanaOperacje()
        {            
            if (APP.APP.KartyPOLCA.Count > 0)
            {
                try
                {
                    KartaPolca = APP.APP.KartyPOLCA.First(x => x.RealizownaNaStanowisku == Stanowisko.Symbol);
                    PokazKartePOLCArealizowana(KartaPolca);    
                }
                catch 
                {
                    pRealizowana.Controls.Clear();
                    btnRozpocznij.Enabled = true;
                    btnWykonano.Enabled = false; 
                }                
            }
        }

        private void PokazKartePOLCArealizowana(MODELE.KartaPolcaModel _kartaPolca)
        {
            pRealizowana.Controls.Clear();
            KartaPOLCAView vKartaPolca = new KartaPOLCAView(KartaPolca);
            pRealizowana.Controls.Add(vKartaPolca);
            btnRozpocznij.Enabled = false;
            btnWykonano.Enabled = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KartaPolca != null)
            {
                if (KartaPolca.OperacjaPierwsza.Stanowisko == Stanowisko.Symbol)
                {
                    Operacja = KartaPolca.OperacjaPierwsza;
                }
                else
                {
                    Operacja = KartaPolca.OperacjaDruga;
                }
                KartaPolca.RealizownaNaStanowisku = Stanowisko.Symbol;
                PokazKartePOLCArealizowana(KartaPolca);
            }
            PobierzKartyOczekujace(); 
                       
        }

        private void pKartyOczekujace_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pKartyOczekujace_Click(object sender, EventArgs e)
        {

            try
            {
                FlowLayoutPanel Panel = (FlowLayoutPanel)sender;

                KartaPOLCAView _view = (KartaPOLCAView)sender;

            }
            catch
            { }
        }

        private void vKarta_Clicked(object sender, EventArgs e)
        {
            foreach (Control kontrolka in pKartyOczekujace.Controls)
            {
                Type t = kontrolka.GetType();
                if (t.Equals(typeof(Kontrolki.KartaPOLCAView)))
                {
                    Kontrolki.KartaPOLCAView kartaPolcaV = (Kontrolki.KartaPOLCAView)kontrolka;
                    kartaPolcaV.BorderStyle = BorderStyle.None; 
                   
                }            
            }

            KartaPOLCAView _kliknieta = (KartaPOLCAView)sender;
            _kliknieta.BorderStyle = BorderStyle.FixedSingle;
            KartaPolca = (MODELE.KartaPolcaModel)_kliknieta.KartaPolca;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

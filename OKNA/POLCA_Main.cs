using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ZAPR_POLCA.OKNA
{
    
    public partial class POLCA_Main : Form
    {
        List<MODELE.ZlecenieModel> Zlecenia;
        List<MODELE.WyrobModel> Wyroby;

        MODELE.ZlecenieModel Zlecenie; 

        public POLCA_Main()
        {
            InitializeComponent();
        }

        private void cListaStanowisk2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MODELE.StanowiskoModel _Stanowisko = (MODELE.StanowiskoModel)cListaStanowisk2.SelectedItem;
            vStanowisko2.Odswiez(_Stanowisko);
        }

        #region Zdarzenia 

        private void POLCA_Main_Load(object sender, EventArgs e)
        {
            APP.APP.PrzygotujDane();
            //TestowoTworzeZlecenia(); 
            Wyroby = APP.APP.KartotekaWyrobow;
            Zlecenia = APP.APP.KartotekaZlecen;
            listWyroby.DataSource = APP.APP.KartotekaWyrobow;
            operacjaModelBindingSource.DataSource = APP.APP.Operacje;
            kartaPolcaModelBindingSource.DataSource = APP.APP.KartyPOLCA;

            PobierzStanowiska(cListaStanowisk1);
            PobierzStanowiska(cListaStanowisk2);
            /*
            cListaStanowisk1.DataSource = APP.APP.KartotekaStanowisk;
            cListaStanowisk1.DisplayMember = "Symbol";
            cListaStanowisk2.DataSource = APP.APP.KartotekaStanowisk;
            cListaStanowisk2.DisplayMember = "Symbol";
            */
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Zdarzenie tworzenia zlecenia dla Wyrobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Tworze Zlecenie
            MODELE.WyrobModel wyrob = (MODELE.WyrobModel)listWyroby.SelectedItem;
            ZlecenieForm EdycjaZlecenia = new ZlecenieForm(wyrob);

            DialogResult res = EdycjaZlecenia.ShowDialog();
            if (res == DialogResult.OK)
            {
                PokazZlecenia();
                zlecenieModelBindingSource.DataSource = null;
                zlecenieModelBindingSource.DataSource = APP.APP.KartotekaZlecen;
            }

        }

        private void listaZlecen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnStart.Enabled = false;
                int index = e.RowIndex;
                Zlecenie = APP.APP.KartotekaZlecen[index];
                if (Zlecenie.Status == MODELE.StatusZlecenia.O)
                {
                    btnStart.Enabled = true;
                }
            }
            catch { }
        }

        /// <summary>
        /// Uruchomienie Zlecenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            int lpOperacji = 1;
            List<MODELE.OperacjaModel> operacje_zlecenia = MODELE.OperacjaModel.OperacjeDlaZlecenia(Zlecenie);


            foreach (MODELE.OperacjaModel tmp_operacja in operacje_zlecenia.OrderBy(x => x.NrOperacji))
            {
                APP.APP.Operacje.Add(tmp_operacja);
                if (lpOperacji < operacje_zlecenia.Count)
                {
                    MODELE.KartaPolcaModel kartaPOLCA = new MODELE.KartaPolcaModel(Zlecenie, tmp_operacja, operacje_zlecenia[lpOperacji]);
                    if (lpOperacji == 1) kartaPOLCA.CzyPierwsza = true;
                    APP.APP.KartyPOLCA.Add(kartaPOLCA);
                    lpOperacji++;
                }
            }
            Zlecenie.Status = MODELE.StatusZlecenia.S;
            PokazZlecenia(); 
            kartaPolcaModelBindingSource.DataSource = null;
            kartaPolcaModelBindingSource.DataSource = APP.APP.KartyPOLCA;
        }

        /// <summary>
        /// Wybor Stanowisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cListaStanowisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            MODELE.StanowiskoModel _Stanowisko = (MODELE.StanowiskoModel)cListaStanowisk1.SelectedItem;
            vStanowisko1.Odswiez(_Stanowisko);
        }

        /// <summary>
        /// Zaznaczenie zlecenia na liście
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZaznaczZlecenie(object sender, EventArgs e)
        {
            Kontrolki.ZlecenieView zlecenieklikniete = (Kontrolki.ZlecenieView)sender;
            this.Zlecenie = zlecenieklikniete.PobierzZlecenie();
            if (this.Zlecenie.Status == MODELE.StatusZlecenia.O)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
        }
        #endregion Zdarzenia 

        #region Funkcje

        private void PobierzStanowiska(ComboBox cmbListaStanowisk)
        {
            cmbListaStanowisk.Items.Clear();
            foreach (MODELE.StanowiskoModel stanowisko in APP.APP.KartotekaStanowisk)
            {
                cmbListaStanowisk.Items.Add(stanowisko);
            }
            cmbListaStanowisk.DisplayMember = "Symbol";
        }


        /// <summary>
        /// Wyświetla zlecenia Kartoteki zleceń
        /// </summary>
        private void PokazZlecenia()
        {
            pListaZlecen.Controls.Clear(); 
            foreach (MODELE.ZlecenieModel zlecenie in APP.APP.KartotekaZlecen)
            {
                Kontrolki.ZlecenieView vZlecenie = new Kontrolki.ZlecenieView(zlecenie);
                vZlecenie.BackColor = zlecenie.KolorZlecenia;
                vZlecenie.Click += new EventHandler(ZaznaczZlecenie);
                pListaZlecen.Controls.Add(vZlecenie);
            
            }
        }


        #endregion Funkcje 


    }
}

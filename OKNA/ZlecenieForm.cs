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
    public partial class ZlecenieForm : Form
    {
        MODELE.ZlecenieModel Zlecenie;
        MODELE.WyrobModel Wyrob;

        bool DaneOK = true; 

        public ZlecenieForm()
        {
            InitializeComponent();
        }

        public ZlecenieForm(MODELE.WyrobModel _wyrob)
        {
            InitializeComponent();
            Wyrob = _wyrob; 
            Zlecenie = new MODELE.ZlecenieModel(_wyrob);
            Zlecenie.PlanowanaDataRozpoczecia = DateTime.Today;
           // System.TimeSpan duration = new System.TimeSpan(30, 0, 0, 0);   //doliczam dni, godziny, minuty, sekundy
            Zlecenie.PlanowanaDataZakonczenia = Zlecenie.PlanowanaDataRozpoczecia.AddDays(30);
            wyrobModelBindingSource.DataSource = Wyrob;
            bindingZlecenie.DataSource = Zlecenie;

        }

        private void Zlecenie_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SprawdzDane();
            if (DaneOK)
            {
                Zlecenie.KolorZlecenia = WygenerujKolor(); 
                APP.APP.KartotekaZlecen.Add(Zlecenie);

                Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel; 
            }
        }

        private void ZlecenieForm_Validating(object sender, CancelEventArgs e)
        {

        }

        private void SprawdzDane()
        {
            if (nIlosc.Value == 0)
            {
                MessageBox.Show("Ilość zamówiona musi być większa od zera");
                DaneOK = false;
            }
        }

        private Color WygenerujKolor()
        {
            int R, G, B;
            Random rand = new Random();
            R = rand.Next(0, 255);
            G = rand.Next(0, 255);
            B = rand.Next(0, 255);

            return Color.FromArgb(R, G, B);

        }
    }
}

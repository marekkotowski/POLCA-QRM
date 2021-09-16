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
    public partial class KartaPOLCAView : UserControl
    {
        public MODELE.KartaPolcaModel KartaPolca; 
        public KartaPOLCAView()
        {
            InitializeComponent();
        }

        public KartaPOLCAView(MODELE.KartaPolcaModel _kartaPOLCA)
        {
            InitializeComponent();
            this.KartaPolca = _kartaPOLCA; 
        }

        private void KartaPOLCAView_Load(object sender, EventArgs e)
        {
            if (this.KartaPolca != null)
            {
                this.bindingKartaPOLCA.DataSource = this.KartaPolca;
                if (this.KartaPolca.OperacjaPierwsza.Wykonana)
                {
                    lDoWykonania.Text = this.KartaPolca.OperacjaDruga.Ilosc.ToString();
                }
                else
                {
                    lDoWykonania.Text = this.KartaPolca.OperacjaPierwsza.Ilosc.ToString();
                }
            }
        }
    }
}

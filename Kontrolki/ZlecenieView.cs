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

    public partial class ZlecenieView : UserControl
    {
        MODELE.ZlecenieModel Zlecenie;

        public ZlecenieView()
        {
            InitializeComponent();
        }

        public ZlecenieView(MODELE.ZlecenieModel _zlec)
        {
            InitializeComponent();
            this.Zlecenie = _zlec;
            if (this.Zlecenie != null)
            {
                zlecenieModelBindingSource.DataSource = Zlecenie; 
            }
        }

        public MODELE.ZlecenieModel PobierzZlecenie()
        {
            return this.Zlecenie; 
        }

        private void ZlecenieView_Load(object sender, EventArgs e)
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRisingSun
{
    public partial class FrmDrinks : Form
    {
        public FrmDrinks()
        {
            InitializeComponent();
        }

        private void pbSpirits_Click(object sender, EventArgs e)
        {
            //display list of spirits
        }

        private void pbDraughts_Click(object sender, EventArgs e)
        {
            //display list of draughts
        }

        private void pbBottles_Click(object sender, EventArgs e)
        {
            //display list of bottled drinks
        }

        private void pbSoftDrinks_Click(object sender, EventArgs e)
        {
            //display list of non-alcholoic and mixers
        }

        private void pbWine_Click(object sender, EventArgs e)
        {
            //display list of wines
        }

        private void pbSundries_Click(object sender, EventArgs e)
        {
            //display list of all sundries
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormProvider.FrmMain.Show();
            this.Hide();
        }
    }
}

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
    public partial class FrmDisplayDrinks : Form
    {
        public FrmDisplayDrinks()
        {
            InitializeComponent();
        }

        internal void Show(int selection)
        {
            throw new NotImplementedException();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Application.DoEvents();
            //dsDrinks.Clear();
            FormProvider.FrmDrinks.Show();
            this.Hide();
        }
    }
}

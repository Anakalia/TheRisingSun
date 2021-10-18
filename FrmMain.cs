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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProvider.FrmDisplayDrinks.Show();
            this.Hide();
        }

        private void btnF1_Click(object sender, EventArgs e) //user clicks front table one
        {
            FormProvider.FrmDrinks.Show();
            this.Hide();
        }
    }
}

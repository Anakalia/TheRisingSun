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

        public static string drinkType;
        public static string table;

        //Drinks objDrinks;
        //DataSet dsDrinks;
        public DataRow drDrinks;
        public int nCurrentRow;

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormProvider.FrmMain.Show();
            this.Hide();
        }

        public void runSearch()
        {
            try
            {
                Drinks objDrinks = new Drinks();
                DataSet dsDrinks = objDrinks.GetDrinks(drinkType);
                dgvDrinks.DataSource = dsDrinks.Tables[0];

                dgvDrinks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDrinks.MultiSelect = false;
                return;
            }

            catch
            {
                MessageBox.Show("There was a problem, please try again.", "Warning", MessageBoxButtons.OK);
                return;
            }
        }

        private void runAll()
        {
            try
            {
                Drinks objDrinks = new Drinks();
                DataSet dsDrinks = objDrinks.GetAllDrinks();
                dgvDrinks.DataSource = dsDrinks.Tables[0];

                dgvDrinks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDrinks.MultiSelect = false;
                return;
            }

            catch
            {
                MessageBox.Show("There was a problem, please try again.", "Warning", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            drinkType = "*";
            runAll();

        }

        private void btnSpirits_Click(object sender, EventArgs e)
        {
            //display list of spirits
            drinkType = "Spirit";
            runSearch();
        }

        private void btnDraughts_Click(object sender, EventArgs e)
        {
            //display list of draughts
            drinkType = "Draught";
            runSearch();

        }

        private void btnBottles_Click(object sender, EventArgs e)
        {
            //display list of bottled drinks
            drinkType = "Bottle";
            runSearch();
        }

        private void btnSoftDrinks_Click(object sender, EventArgs e)
        {
            //display list of non-alcholoic and mixers
            drinkType = "Non-Alcoholic";
            runSearch();
        }

        private void btnWines_Click(object sender, EventArgs e)
        {
            //display list of wines
            drinkType = "Wine";
            runSearch();
        }

        private void btnShots_Click(object sender, EventArgs e)
        {
            //display list of shots
            drinkType = "Shot";
            runSearch();
        }

        private void btnHot_Click(object sender, EventArgs e)
        {
            //display list of hot drinks
            drinkType = "Hot";
            runSearch();
        }

        private void btnDGBack_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}

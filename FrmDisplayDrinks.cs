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

        Drinks objDrinks;
        DataSet dsDrinks;
        public DataRow drDrinks;
        public int nCurrentRow;

        private void FrmDisplayDrinks_Load_1(object sender, EventArgs e)
        {
            objDrinks = new Drinks();
            dsDrinks = new DataSet();

            try
            {
                dsDrinks = objDrinks.GetDrinks();

                dgDrinks.DataSource = dsDrinks.Tables[0];
                //dgDrinks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dgDrinks.MultiSelect = false;

                if (dgDrinks.CurrentRow == null)
                {
                    MessageBox.Show("Sorry there are no results. \n Would you like to try again?", "No Results", MessageBoxButtons.OKCancel);
                    return;
                }
                else
                {
                    int CurrentRowIndex = dgDrinks.CurrentRow.Index;
                    drDrinks = dsDrinks.Tables[0].Rows[0];
                    return;
                }
            }

            catch
            {
                MessageBox.Show("There was a problem, please try again.", "Warning", MessageBoxButtons.OK);
                return;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}



        /*private void DisplayData()
        {
            //if needed
        }*/
    }
}

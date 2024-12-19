using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_App_2
{
    public partial class shoppingApp : Form
    {
        public static double due = 0, change;
        public shoppingApp()
        {
            InitializeComponent();
        }

        private void kendrickPbx_Click(object sender, EventArgs e)
        {
            slipRichTbx.Text = slipRichTbx.Text + "\nKendrick - To Pimp A Butterfly: R1050.00";
            due = due + 1050.00;
            dueLb.Text = "R" + due.ToString();
        }

        private void kaidiPbx_Click(object sender, EventArgs e)
        {
            slipRichTbx.Text = slipRichTbx.Text + "\nKaidi Tatham - In Search Of Hope:  R1200.00";
            due = due + 1200.00;
            dueLb.Text = "R" + due.ToString();
        }

        private void shafiqPbx_Click(object sender, EventArgs e)
        {
            slipRichTbx.Text = slipRichTbx.Text + "\nShafiq Husayn - The Loop: R1400.00";
            due = due + 1400.00;
            dueLb.Text = "R" + due.ToString();
        }

        private void solangePbx_Click(object sender, EventArgs e)
        {
            slipRichTbx.Text = slipRichTbx.Text + "\nSolange - When I get Home: R1000.00";
            due = due + 1000.00;
            dueLb.Text = "R" + due.ToString();
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            double cash = Convert.ToDouble(cashTxb.Text);
            change = cash - due;
            changelb.Text = "R" + change.ToString();

            if(change < 0)
            {
                MessageBox.Show("Not Enough Cash");
            }
            if (cashTxb.Text.Length < 0)
            {
                MessageBox.Show("Amount Required!");
            }
            
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            change = 0;
            due= 0;
            slipRichTbx.Text = "";
            dueLb.Text = "";
            cashTxb.Text = "";
            changelb.Text = change.ToString();


        }

        private void turntablePbx_Click(object sender, EventArgs e)
        {
            slipRichTbx.Text = slipRichTbx.Text + "\nTurn-table:   R5000.00";
            due = due + 5000.00;
            dueLb.Text = "R" + due.ToString();
        }
    }
}

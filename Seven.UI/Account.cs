using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seven.UI
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        BLL.BLLAccount blac = new BLL.BLLAccount();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTransferAmount_Click(object sender, EventArgs e)
        {
            DataTable dt = blac.GetAccountDetailsByAccountNo(txtFromAccountNo.Text);
            if(dt.Rows.Count>0)
            {
                decimal amountfrom = Convert.ToDecimal(dt.Rows[0]["Amount"].ToString());
                if (amountfrom > 1000)
                {
                    decimal amountaftertransfer = amountfrom - Convert.ToDecimal(txtAmountFrom.Text);
                    if (amountaftertransfer > 1000)

                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    //not sufficient amount

                }

                
            }
            else
            {
                //acount doesnt exist

            }
        }
    }
}

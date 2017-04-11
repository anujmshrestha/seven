using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seven.BLL;

namespace Seven.UI
{
    public partial class CreateCategory : Form
    {
        public CreateCategory()
        {
            InitializeComponent();
        }
        BLLCategory blc = new BLLCategory();
        int categoryid = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int i = blc.CreateCategory(txtCategoryName.Text);
            MessageBox.Show("Category" + " " + txtCategoryName.Text + " is Saved");
        //    MessageBox.Show("New category is entered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          //  int i=blc.DeleteCategory(dataGridView1.r)
        }

        private void CreateCategory_Load(object sender, EventArgs e)
        {
            LoadCategory();


        }

        private void LoadCategory()
        {
            DataTable dt = blc.GetAllCategory();
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}

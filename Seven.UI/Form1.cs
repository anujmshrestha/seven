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
using Seven.DAL;

namespace Seven.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BLLUser blu = new BLLUser();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text != "Update")
            {



                DataTable dt = blu.GetUserbyUsername(txtUsername.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("User Already Exists");
                }
                else
                {
                    //insert
                    int i = blu.CreateUser(txtUsername.Text, txtPassword.Text, comboBox1.Text, txtFullname.Text);
                    if (i > 0)
                    {
                        MessageBox.Show("User Created");
                        txtUsername.Text = string.Empty;
                        txtPassword.Text = "";
                        comboBox1.SelectedIndex = 0;
                        txtFullname.Clear();
                        LoadGrid();
                    }
                    //
                }
            }
            else
            {
                int i = blu.UpdateUser(txtUsername.Text, txtPassword.Text, comboBox1.Text, txtFullname.Text, userid);
               
                if(i>0)
                {
                    MessageBox.Show("Existing user updated");
                    LoadGrid();



                }
            }
        }

            

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGrid();
            btnDelete.Enabled = false;
            //count le euta table ma no of count lerauxa..jasma first rowko first colum ma value add hunxa
            DataTable dt = blu.CountUser();
            txtCount.Text = "total count is#" + " " + dt.Rows[0][0].ToString();
            

        }

        private void LoadGrid()
        {
            DataTable dt = blu.GetAllUser();
            dataGridView1.DataSource = dt;
          

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = blu.GetUserbyUsername(txtSearchy.Text);
            if(dt.Rows.Count>0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("not found");
            }
        }

        private void txtSearchy_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = blu.GetUserbyUsernameLike(txtUsername.Text);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = blu.DeleteUser(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
           if(i>0)
         {
             MessageBox.Show("deleted");
                LoadGrid();
            }
        }
        int userid = 0;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtFullname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            btnSave.Text = "Update";
            btnDelete.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
    }
}

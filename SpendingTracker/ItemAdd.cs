using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SpendingTracker
{
    public partial class ItemAdd : Form
    {
        //Different name needed
        SqlConnection con = new SqlConnection(@"Data Source=ANNIE\SQLEXPRESS;
Initial Catalog=Purchases;Integrated Security=True");
        int categoryID;
        bool addnew;
        public ItemAdd(bool addnew)
        {
            InitializeComponent();
            refreshcategory();
            this.addnew = addnew;
           
            if (addnew == false)
            {
                this.Text = "Edit Item";
            }
            else this.Text = "Add Item";
        }
        private void refreshcategory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Categories", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cbCategory.DisplayMember = "categoryName";
            cbCategory.ValueMember = "categoryID";
            cbCategory.DataSource = dt;
        }
        private void refreshcItem(int categoryID)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ItemsOfCategory where itemcategoryID = @categoryID", con);
            cmd.Parameters.AddWithValue("categoryID", categoryID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cbItem.DisplayMember = "itemName";
            cbItem.ValueMember = "itemID";
            cbItem.DataSource = dt;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text == "" && cbItem.Text == "not selected") || textBoxPrice.Text == "")
            {
                MessageBox.Show("Fill out the form!");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        public void buttonColor_Click(object sender, EventArgs e)
        {
            textBoxPrice.ForeColor = Color.Red;
            
        }
        private void cbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue.ToString() != null)
            {
                categoryID = Convert.ToInt32(cbCategory.SelectedValue.ToString());
                refreshcItem(categoryID);
            }
        }

    }
}

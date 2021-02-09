using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpendingTracker
{
    public partial class FormST : Form
    {
        public FormST()
        {
            InitializeComponent();
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            ItemAdd itemadd = new ItemAdd(true);
            if (itemadd.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem("");
                if (itemadd.cbItem.Text == "not selected")
                    item = new ListViewItem(itemadd.textBoxName.Text);
                else item = new ListViewItem(itemadd.cbItem.Text);
                item.SubItems.Add(itemadd.textBoxPrice.Text);
                item.SubItems.Add(itemadd.dateTimePiDate.Value.ToShortDateString().ToString());
                if (itemadd.textBoxPrice.ForeColor == Color.Red)
                {
                    item.BackColor = Color.Red;
                }
                myListView.Items.Add(item);
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (myListView.FocusedItem == null)
            {
                MessageBox.Show("You did not choose an item");
                return;
            }
            for (int i = 0; i < myListView.Items.Count; i++)
            {
                if (myListView.Items[i].Selected)
                {
                    myListView.Items[i].Remove();
                    i--;
                }
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (myListView.FocusedItem == null)
            {
                MessageBox.Show("You did not choose an item");
                return;
            }
            int n = myListView.FocusedItem.Index;           
            ItemAdd editform = new ItemAdd(false);
            editform.ShowDialog();
            myListView.Items.RemoveAt(n);
            ListViewItem item = new ListViewItem("");
            if (editform.cbItem.Text == "not selected")
                item = new ListViewItem(editform.textBoxName.Text);
            else item = new ListViewItem(editform.cbItem.Text);

            item.SubItems.Add(editform.textBoxPrice.Text);
            item.SubItems.Add(editform.dateTimePiDate.Value.ToShortDateString().ToString());
            if (editform.textBoxPrice.ForeColor == Color.Red)
            {
                item.BackColor = Color.Red;
            }
            myListView.Items.Insert(n, item);
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anya", "Developer", MessageBoxButtons.OK);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.TableName = "Info";
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Date");
            ds.Tables.Add(dt);
            foreach(ListViewItem l in myListView.Items)
            {
                DataRow row = ds.Tables["Info"].NewRow();
                row["Name"] = l.SubItems[0].Text;
                row["Price"] = l.SubItems[1].Text;
                row["Date"] = l.SubItems[2].Text;
                ds.Tables["Info"].Rows.Add(row);
            }
            ds.WriteXml("Xml.xml");
            MessageBox.Show(" The file saved successfully!");
            
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            myListView.Items.Clear();
            if (File.Exists("Xml.xml"))
            {
                ds.ReadXml("Xml.xml");
                foreach (DataRow item in ds.Tables["Info"].Rows)
                {
                    ListViewItem l = new ListViewItem(item[0].ToString());
                    l.SubItems.Add(item[1].ToString());
                    l.SubItems.Add(item[2].ToString());
                    myListView.Items.Add(l);
                }
            } else MessageBox.Show("Nothing to load!");

        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            File.Delete("Xml.xml");
            MessageBox.Show("File is empty now!");
            myListView.Items.Clear();
        }
        private async void buttonExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() {Filter = "Text Documents|.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter (new FileStream (sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (ListViewItem item in myListView.Items)
                        {
                            await tw.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1].Text
                                + "\t" + item.SubItems[2].Text);
                        }
                        MessageBox.Show("Your data has been successfully exported.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void buttonVS_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.ShowDialog();
        }
    }
}

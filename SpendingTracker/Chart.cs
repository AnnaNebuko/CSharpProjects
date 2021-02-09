using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SpendingTracker
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
           
        }
        private void Chart_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Xml.xml");
            chartPurchases.Series["Purchases"].XValueMember = "Name";
            chartPurchases.Series["Purchases"].YValueMembers = "Price";
            chartPurchases.DataSource = ds;
            chartPurchases.DataBind();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vglinskii.adoNet.Lab4_dataAdapterWizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northWindDataSet1.Customers;
            sqlDataAdapter1.Fill(northWindDataSet1.Customers);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(northWindDataSet1.Customers);
        }
    }
}

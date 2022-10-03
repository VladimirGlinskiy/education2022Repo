


namespace DatasetDesigner

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            NordwindDataset dataset = new NordwindDataset();
            NordwindDatasetTableAdapters.CustomersTableAdapter CustomersTableAdapter1 = new NordwindDatasetTableAdapters.CustomersTableAdapter();
            CustomersTableAdapter1.Fill(dataset.Customers);

            foreach (NordwindDataset.CustomersRow NWCustomer in dataset.Customers.Rows) {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }

        }
    }
}
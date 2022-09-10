using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace DBConnection
{

    
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();
     //   string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NorthWind;Data Source=DESKTOP-9JE1720\SQLEXPRESS";
        

        public Form1()
        {
            InitializeComponent();
            this.connection.StateChange += new
                System.Data.StateChangeEventHandler(this.connection_StateChange);
        }

        static string GetConnectionStringByName(string name) {

            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if(settings != null) 
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        String testConnect = GetConnectionStringByName("DBConnect.NorthWindConnectionString");

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e) {
            connectToDatabaseToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            disconnectDatabaseToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open); 
        }

        private void connectToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                {
                    MessageBox.Show("Соединение уже установлено");
                }
            }
            catch (OleDbException XcpSQL) {

                foreach (OleDbError serviceError in XcpSQL.Errors) {

                    MessageBox.Show(serviceError.Message, "SQL Error code " + serviceError.NativeError, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception Xcp)
            {

                MessageBox.Show(Xcp.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void disconnectDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else {
                MessageBox.Show("Соединение с базой данных уже закрыто");
            }
        }

        private void hostsListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null) {

                foreach (ConnectionStringSettings connectionString in settings) {
                    MessageBox.Show("name = " + connectionString.Name);
                    MessageBox.Show("providerName = " + connectionString.ProviderName);
                    MessageBox.Show("connectionString = " + connectionString.ConnectionString);
                
                }
            
            }


        }
    }
}

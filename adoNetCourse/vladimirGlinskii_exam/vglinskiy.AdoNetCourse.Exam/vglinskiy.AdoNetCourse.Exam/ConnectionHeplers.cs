using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;

namespace vglinskiy.AdoNetCourse.Exam
{
    public static class ConnectionHeplers
    {
       static String testConnect = ConnectionHeplers.GetConnectionStringByName("DBConnect.moderator_management_DB");

        public static void checkDBConnection()
        {
            if (Form1.connection.State == ConnectionState.Closed)
            {
                connectToDatabase();
            }
        }

        private static void connectToDatabase()
        {
            try
            {

                if (Form1.connection.State != ConnectionState.Open)
                {
                    Form1.connection.ConnectionString = testConnect;
                    Form1.connection.Open();
                }

            }
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError serviceError in XcpSQL.Errors)
                {
                    MessageBox.Show(serviceError.Message, "SQL Error code " + serviceError.NativeError, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GetConnectionStringByName(String connectionStringName)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[connectionStringName];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

    }
}

using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace vglinskiy.AdoNetCourse.Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showInformation();
        }

        public static OleDbConnection connection = new OleDbConnection();
        static CurrentInformation curInformation = new CurrentInformation();



        private void demoteButton_Click(object sender, EventArgs e)
        {
            DataHelpers.disableRights(curInformation);
            updateDataSet();
        }


        public void showInformation()
        {
            dataGridView1.DataSource = usersDataSet1.users_list;
            sqlDataAdapter1.Fill(usersDataSet1.users_list);
        }

        public void updateDataSet()
        {
            usersDataSet1.Clear();
            showInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateDataSet();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {

                if (curInformation.role_id != -1)
                {
                    DataHelpers.disableRights(curInformation);
                }

                String getItemName = "delete from users_list where user_id =" + curInformation.user_id;

                OleDbTransaction transaction = connection.BeginTransaction();
                OleDbCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = getItemName;
                    command.ExecuteNonQuery();
                    transaction.Commit();


                }

                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    try { transaction.Rollback(); }
                    catch (Exception rollbackException)
                    {
                        MessageBox.Show(rollbackException.Message);
                    }
                }

                updateDataSet();
        }


        private void addUserButton_Click(object sender, EventArgs e)
        {
            confirmButton.Visible = true;
            label1.Visible = true;
            userNameInput.Visible = true;
            CancellationButton.Visible = true;
            addUserButton.Visible = false;

        }



        private void changeUserRulesButton_Click(object sender, EventArgs e)
        {
            List<String> roles;

            changeUserRulesButton.Visible = false;
            label2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            comboBox1.Visible = true;

            roles = DataHelpers.getRolesList();

            foreach (String i in roles) {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
            roles.Clear();

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            String name = userNameInput.Text;
            DataHelpers.addNewUser(name);
            updateDataSet();

            confirmButton.Visible = false;
            label1.Visible = false;
            userNameInput.Visible = false;
            CancellationButton.Visible = false;
            addUserButton.Visible = true;
            userNameInput.Clear();
        }

        private void CancellationButton_Click(object sender, EventArgs e)
        {
            confirmButton.Visible = false;
            label1.Visible = false;
            userNameInput.Visible = false;
            CancellationButton.Visible = false;
            addUserButton.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int user_id = (int)dataGridView1.SelectedCells[0].Value;
            DataHelpers.getUserInformation(curInformation, user_id);

            if (curInformation.role_id == -1)
            {

                demoteButton.Enabled = false;
                changeUserRulesButton.Text = "Назначить модератором";

            }
            else
            {

                demoteButton.Enabled = true;
                changeUserRulesButton.Text = "Изменить права модератора";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (curInformation.role_id !=-1) {
                DataHelpers.disableRights(curInformation);
            }

            DataHelpers.addUserRights(curInformation, comboBox1.Text);

            changeUserRulesButton.Visible = true;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            comboBox1.Visible = false;

            comboBox1.Items.Clear();
            updateDataSet();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            changeUserRulesButton.Visible = true;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            comboBox1.Visible = false;
            comboBox1.Items.Clear();
        }
    }
}






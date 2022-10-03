using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vglinskiy.AdoNetCourse.Exam
{
    internal class DataHelpers
    {
        public static CurrentInformation getUserInformation(CurrentInformation currentInformation, int user_id)
        {
            ConnectionHeplers.checkDBConnection();
            currentInformation.user_id = user_id;
            String sqlString = "select user_id, role_id from moderators_list where user_id =" + user_id;

            OleDbCommand command = Form1.connection.CreateCommand();
            command.CommandText = sqlString;
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                currentInformation.role_id = (int)reader["role_id"];
            }
            else
            {
                currentInformation.role_id = -1;
            }

            Console.WriteLine("Current user info. ID: " + currentInformation.user_id + " Role ID: " + currentInformation.role_id);
            return currentInformation;
             
        }



        public static List<String> getRolesList()
        {
            List<String> roles = new List<String>();

            try
            {
                ConnectionHeplers.checkDBConnection();
                OleDbCommand command = Form1.connection.CreateCommand();
                command.CommandText = "SELECT role_name FROM roles_list;";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    roles.Add(reader.GetString(0));

                }

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return roles;
        }


        public static void disableRights(CurrentInformation currentInformation)
        {
            ConnectionHeplers.checkDBConnection();
            String disableRights = "delete from moderators_list where user_id =" + currentInformation.user_id;
            OleDbTransaction transaction = Form1.connection.BeginTransaction();
            OleDbCommand command = Form1.connection.CreateCommand();
            command.Transaction = transaction;

            try
            {
                command.CommandText = disableRights;
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
        }

        public static void addUserRights(CurrentInformation currentInformation, String role)
        {
            ConnectionHeplers.checkDBConnection();
            String addModerator = "insert into moderators_list (user_id, role_id) values ("+ currentInformation.user_id + ", (select role_id from roles_list where role_name = '"+ role + "'))";
            OleDbTransaction transaction = Form1.connection.BeginTransaction();
            OleDbCommand command = Form1.connection.CreateCommand();
            command.Transaction = transaction;

            try
            {
                command.CommandText = addModerator;
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
        }


        public static void addNewUser(String userName)
        {
            ConnectionHeplers.checkDBConnection();
            String insertNewUser = "insert into users_list (nickName) values ('" + userName + "')";
            OleDbTransaction transaction = Form1.connection.BeginTransaction();
            OleDbCommand command = Form1.connection.CreateCommand();
            command.Transaction = transaction;

            try
            {
                command.CommandText = insertNewUser;
                command.ExecuteNonQuery();
                transaction.Commit();

            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                try { 
                    transaction.Rollback(); 
                }
                catch (Exception rollbackException)
                {
                    MessageBox.Show(rollbackException.Message);
                }
            }
        }
    }
}

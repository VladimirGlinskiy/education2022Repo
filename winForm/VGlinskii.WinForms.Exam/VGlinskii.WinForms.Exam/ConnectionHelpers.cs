using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGlinskii.WinForms.Exam
{
    internal class ConnectionHelpers
    {

        static string connectionString = "Integrated Security = SSPI; Persist Security Info = False; " +
                "Initial Catalog = kartinker_database; Data Source = DESKTOP-9JE1720\\SQLEXPRESS;";

        static string userName = "";


        public static KartinkerForm.SImageInfo getImageRating(String pictureName, String userName)
        {
            KartinkerForm.SImageInfo result = new KartinkerForm.SImageInfo();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String getRatingRequest = $"SELECT picture_rate FROM dbo.rating where picture_name = '{pictureName}' " +
                    $"and user_name = '{userName}'";

                connection.Open();

                //Get current users rate
                SqlCommand command = new SqlCommand(getRatingRequest, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.pictureRate = Convert.ToInt32(reader["picture_rate"]);
                }
                reader.Close();

                //Get average rate
                String getAverageRatingRequest = $"SELECT AVG(Cast(picture_rate as Float)) as average FROM dbo.rating where picture_name = '{pictureName}'";
                SqlCommand nextCommand = new SqlCommand(getAverageRatingRequest, connection);
                reader = nextCommand.ExecuteReader();

                while (reader.Read())
                {

                    if (Convert.IsDBNull(reader["average"]))
                    {
                        result.averagePictureRate = 0;

                    }
                    else
                    {
                        result.averagePictureRate = Convert.ToDouble(reader["average"]);
                    }
                }
            }
            return result;
        }

        public static KartinkerForm.SImageInfo setImageRating(String pictureName, String userName, int rating)
        {
            KartinkerForm.SImageInfo result = new KartinkerForm.SImageInfo();
            result.pictureRate = rating;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String getRatingRequest = $"IF EXISTS (Select picture_rate FROM dbo.rating where " +
                    $"picture_name = '{pictureName}' and user_name = '{userName}') " +
                    $"BEGIN " +
                    $"UPDATE dbo.rating set picture_rate = {rating} where picture_name = '{pictureName}' " +
                    $"and user_name = '{userName}'; " +
                    $"END " +
                    $"ELSE " +
                    $"BEGIN " +
                    $"Insert into dbo.rating values('{userName}', getdate(), '{pictureName}', {rating}) " +
                    $"END";

                connection.Open();

                //Set picture rating
                SqlCommand command = new SqlCommand(getRatingRequest, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
                reader.Close();

                //Get average rate
                String getAverageRatingRequest = $"SELECT AVG(Cast(picture_rate as Float)) as average FROM dbo.rating where picture_name = '{pictureName}'";
                SqlCommand NextCommand = new SqlCommand(getAverageRatingRequest, connection);
                reader = NextCommand.ExecuteReader();

                while (reader.Read())
                {

                    if (Convert.IsDBNull(reader["average"]))
                    {
                        result.averagePictureRate = 0;
                    }
                    else
                    {
                        result.averagePictureRate = Convert.ToDouble(reader["average"]);
                    }
                }
            }

            return result;
        }


        public static bool checkLoginPassword(string userLogin, string password)
        {
            String foundLogin = null;
            bool areCredentialsProper = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String findLoginRequest =
                $"select name from sys.sql_logins where PWDCOMPARE('{password}', password_hash) = 1 or PWDCOMPARE('{password}', password_hash, 1) = 1;";
                connection.Open();

                SqlCommand command = new SqlCommand(findLoginRequest, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    foundLogin = reader[0].ToString();

                }
                reader.Close();
                connection.Close();
            }

            if (String.Compare(foundLogin, userLogin) == 0)
            {
                areCredentialsProper = true;
                userName = userLogin;
            }
            else
            {
                Console.WriteLine("Credentials are not proper");
            }
            return areCredentialsProper;
        }

        public static String getUserName()
        {
            return userName;
        }
    }
}
    

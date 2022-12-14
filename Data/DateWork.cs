using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using NFP_MVAA.Models;

namespace NFP_MVAA.Data
{

    public static class DateWork
    {
        static string  connectionString = "Server=(localdb)\\MSSQLLocalDB;Trusted_Connection=True;";
        static SqlConnection connection = new SqlConnection(connectionString);


        static void ConnectDate()
        {
            try
            {
                // Открываем подключение
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void Dispose()
        {
            if (connection.State == ConnectionState.Open)
            {
                // закрываем подключение
                connection.Close();
                MessageBox.Show("Соединение закрыто");
            }
        }


        static public bool UserEntry(string name, string password)
        {
            ConnectDate();
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[Users] WHERE Name='{name}' And  Password='{password}'";

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            int countUser=Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            if(countUser==0)
                return false;
            else
                return true;
        }


        static public string SearchBall(string result)
        {
            ConnectDate();
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[№4] WHERE Result={result}";

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            string ball =Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return ball;
        }


        static public string ForceSearchBall(string result, int selectNumberExercises)
        {
            ConnectDate();

            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[№{NameAndNumberExercisesbyqualities.ForceExercisesNameAndNumber[selectNumberExercises].Number}] WHERE Result='{result}'";

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            string ball = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return ball;
        }


        static public string SpeedSearchBall(string result, int selectNumberExercises)
        {
            ConnectDate();
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[№{NameAndNumberExercisesbyqualities.SpeedExercisesNameAndNumber[selectNumberExercises].Number}] WHERE Result='{result}'";

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            string ball = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return ball;
        }

        static public string EnduranceSearchBall(string result, int selectNumberExercises)
        {
            ConnectDate();
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[№{NameAndNumberExercisesbyqualities.EnduranceExercisesNameAndNumber[selectNumberExercises].Number}] WHERE Result='{result}'";

            SqlCommand command = new SqlCommand(sqlExpression, connection);

            string ball = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return ball;
        }

        static public List<Name_Exercises> SearchName_Exercises()
        {
            List<Name_Exercises> name_Exercises = new List<Name_Exercises>();

            ConnectDate();
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[Name_Exercises] ";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                   name_Exercises.Add( new Name_Exercises()
                    {
                        Number = reader.GetString(0),
                        Name = reader.GetString(1)
                    });
                };
            }
            connection.Close();
                  
            return name_Exercises;
        }



        static public List<BallResultExercisesForce> SearchBallExercisesForce()
        {
            string nameExercises = "AllBallResultForce";
           
            List<BallResultExercisesForce> ball_result = new List<BallResultExercisesForce>();

            ConnectDate();
 
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[{nameExercises}] ";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ball_result.Add(new BallResultExercisesForce()
                    {
                        Ball =(int)reader["Ball"],
                        Result_1 = reader["Result_1"].ToString(),
                        Result_2 = reader["Result_2"].ToString(),
                        Result_4 = reader["Result_4"].ToString(),
                        Result_5 = reader["Result_5"].ToString(),
                        Result_6 = reader["Result_6"].ToString(),
                        Result_7 = reader["Result_7"].ToString(),
                        Result_8_1 = reader["Result_8_1"].ToString(),
                        Result_8_2 = reader["Result_8_2"].ToString(),
                        Result_9 = reader["Result_9"].ToString(),
                        Result_10 = reader["Result_10"].ToString(),
                        Result_11_1 = reader["Result_11_1"].ToString(),
                        Result_11_2 = reader["Result_11_2"].ToString(),
                        Result_12_1 = reader["Result_12_1"].ToString(),
                        Result_12_2 = reader["Result_12_2"].ToString(),
                        Result_13_1 = reader["Result_13_1"].ToString(),
                        Result_13_2 = reader["Result_13_2"].ToString(),
                    });
                };
            }

            connection.Close();
            ball_result.Reverse();
            return ball_result;
        }



        static public List<BallResultExercisesSpeed> SearchBallExercisesSpeed()
        {
            string nameExercises = "AllBallResultSpeed";


            List<BallResultExercisesSpeed> ball_result = new List<BallResultExercisesSpeed>();

            ConnectDate();

            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[{nameExercises}] ";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    ball_result.Add(new BallResultExercisesSpeed()
                    {
                        Ball =(int)reader["Ball"],
                        Result_40 = reader["Result_40"].ToString(),
                        Result_41 = reader["Result_41"].ToString(),
                        Result_42 = reader["Result_42"].ToString(),
                        Result_43 = reader["Result_43"].ToString(),
                        Result_44 = reader["Result_44"].ToString()        
                    });
                };
            }

            connection.Close();
            ball_result.Reverse();
            return ball_result;
        }

        static public List<BallResultExercisesEndurance> SearchBallExercisesEndurance()
        {
            string nameExercises = "AllBallResultEndurance";


            List<BallResultExercisesEndurance> ball_result = new List<BallResultExercisesEndurance>();

            ConnectDate();

            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[{nameExercises}] ";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int i = 0;
                    ball_result.Add(new BallResultExercisesEndurance()
                    {
                        Ball =(int)reader["Ball"],
                        Result_45_1 = reader["Result_45_1"].ToString(),
                        Result_45_2 = reader["Result_45_2"].ToString(),
                        Result_46_1 = reader["Result_46_1"].ToString(),
                        Result_46_2 = reader["Result_46_2"].ToString(),
                        Result_47 = reader["Result_47"].ToString(),
                        Result_48 = reader["Result_48"].ToString(),
                        Result_53 = reader["Result_53"].ToString(),
                        Result_57_b = reader["Result_57_b"].ToString(),
                    });
                };
            }

            connection.Close();
            ball_result.Reverse();
            return ball_result;
        }


        static public List<CategoryMillitary> SearchCategory()
        {
            List<CategoryMillitary> category = new List<CategoryMillitary>(); 

            ConnectDate();
            string sqlExpression = $"SELECT * FROM [NFP].[dbo].[CategoryMillitary]";
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    category.Add(new CategoryMillitary()
                    {
                        Number = reader["Number"].ToString().Trim(),
                        Name = reader["Name"].ToString().Replace("\r\n", string.Empty)
                });
                };
            }
            connection.Close();

            return category;
        }
    }
}

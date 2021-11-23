using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MealApp
{
    public class DatabaseConnector
    {
        private static string connectionString = "Data Source=DESKTOP-62MKJ6O; Initial Catalog = DrummondMenu;User ID = mdrumm1104; Password=Sampson1";
        private SqlConnection sqlConnection;

        public List<string> ExecuteQuery(string query)
        {
            List<string> myList = new List<string>();
            using(sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using(SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                myList.Add(reader.GetString(0));
                            }

                        }
                    }
                }
            }
            return myList;
        }

        public int ExecuteQueryCount(string query)
        {
            int count = 0;
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                count = reader.GetInt32(0);
                            }

                        }
                    }
                }
            }
            return count;
        }

        public void ExecuteInsertStatement(string insertStatement)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, sqlConnection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ExecuteParameterizedMealInset(string insertStatement, Meal meal)
        {
            using(sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(insertStatement, sqlConnection))
                {
                    command.Parameters.Add("@mealName", System.Data.SqlDbType.Char);
                    command.Parameters.Add("@lastMadeDtTm", System.Data.SqlDbType.DateTime);
                    command.Parameters.Add("@kidApproved", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@favorite", System.Data.SqlDbType.Int);
                    command.Parameters.Add("@healthyRating", System.Data.SqlDbType.Int);

                    command.Parameters["@mealName"].Value = meal.MealName;
                    command.Parameters["@lastMadeDtTm"].Value = meal.LastMadeDateTime;
                    command.Parameters["@kidApproved"].Value = meal.KidApproved;
                    command.Parameters["@favorite"].Value = meal.FamilyFavorite;
                    command.Parameters["@healthyRating"].Value = meal.HealthyRating;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

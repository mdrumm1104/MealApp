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
        private string connectionString = "Data Source=DESKTOP-62MKJ6O; Initial Catalog = DrummondMenu;User ID = mdrumm1104; Password=Sampson1";
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
    }
}

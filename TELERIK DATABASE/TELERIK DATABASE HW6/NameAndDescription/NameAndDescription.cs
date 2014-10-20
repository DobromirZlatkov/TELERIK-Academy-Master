using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NameAndDescription
{
    class NameAndDescription
    {
        static void Main(string[] args)
        {
            SqlConnection dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dataBaseConnection.Open();

            using (dataBaseConnection) 
            {
                SqlCommand getCategories = new SqlCommand(
                    "SELECT CategoryName, Description FROM Categories", dataBaseConnection);

                SqlDataReader reader = getCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine((string)reader["CategoryName"] + " --> " + (string)reader["Description"]);
                    }
                }
            }
        }
    }
}

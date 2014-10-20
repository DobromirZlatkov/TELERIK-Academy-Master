using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AllProductCategoriesAndNames
{
    class AllProductCategoriesAndNames
    {
        static void Main(string[] args)
        {
            SqlConnection dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dataBaseConnection.Open();

            using (dataBaseConnection)
            {
                SqlCommand getCategories = new SqlCommand(
                    "SELECT c.CategoryName, p.ProductName FROM Categories c " +
                    "JOIN Products p " +
                    "ON c.CategoryID = p.CategoryID " +
                    "GROUP BY CategoryName, p.ProductName", dataBaseConnection);

                SqlDataReader reader = getCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine((string)reader["CategoryName"] + " --> " + (string)reader["ProductName"]);
                    }
                }
            }
        }
    }
}

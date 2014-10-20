using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadsStringFromCOnsole
{
    class ReadsStringFromCOnsole
    {
        static void Main(string[] args)
        {
            SqlConnection dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security=true");

            dataBaseConnection.Open();

            string searchString = Console.ReadLine().Replace("%", "[%]")
                                                    .Replace("_", "[_]");

            using (dataBaseConnection)
            {
                SqlCommand command = new SqlCommand(@"
                                                    SELECT c.CategoryName, p.ProductName FROM Products p 
	                                                    JOIN Categories c ON c.CategoryID = p.CategoryID
                                                    WHERE p.ProductName LIKE @searchString
                                                    ORDER BY c.CategoryName
                                                 ", dataBaseConnection);
                command.Parameters.AddWithValue("@searchString", "%" + searchString + "%");

                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {              
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string categoryDesc = (string)reader["ProductName"];

                        Console.WriteLine("Category name: {0} ----> Product name: {1}", categoryName, categoryDesc);
                    }
                }
            }
        }
    }
}

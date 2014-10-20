using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NumberOfRowsInTables
{
    class NumberOfRowsInTables
    {
        static void Main(string[] args)
        {
            SqlConnection dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dataBaseConnection.Open();

            using (dataBaseConnection)
            {
                SqlCommand numberOfCategories = new SqlCommand("SELECT COUNT(*) FROM Categories", dataBaseConnection);

                int cattegorieCount = (int)numberOfCategories.ExecuteScalar();

                Console.WriteLine(cattegorieCount);
            }

        }
    }
}

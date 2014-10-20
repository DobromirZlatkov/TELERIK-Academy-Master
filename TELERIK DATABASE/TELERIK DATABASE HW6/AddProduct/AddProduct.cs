using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AddProduct
{
    class AddProduct
    {
        static void Main(string[] args)
        {
            SqlConnection dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dataBaseConnection.Open();

            using (dataBaseConnection)
            {
                SqlParameter paramName = new SqlParameter();
                paramName.ParameterName = "@productName";
                paramName.Value = "pechurki";

                SqlParameter paramPrice = new SqlParameter();
                paramPrice.ParameterName = "@productPrice";
                paramPrice.Value = 100.2m;

                SqlCommand getCategories = new SqlCommand(
                    "INSERT INT Products (ProductName, UnitPrice) " +
                "VALUES (@productName, @productPrice)", dataBaseConnection);

                getCategories.Parameters.Add(paramName);
                getCategories.Parameters.Add(paramPrice);

                int rows = getCategories.ExecuteNonQuery();
                if (rows == 1)
                {
                    Console.WriteLine("Successfuly added.");
                }
                else
                {
                    Console.WriteLine("Error while adding");
                }

            }
        }
    }
}

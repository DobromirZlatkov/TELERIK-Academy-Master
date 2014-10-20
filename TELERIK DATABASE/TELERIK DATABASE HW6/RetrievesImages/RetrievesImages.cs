using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace RetrievesImages
{
    class RetrievesImages
    {
        static void Main(string[] args)
        {
            int fileOffset = 78;

            SqlConnection dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; Database=Northwind; Integrated Security = true");
            dataBaseConnection.Open();

            using (dataBaseConnection)
            {
                SqlCommand command = new SqlCommand(
                    "SELECT CategoryName, Picture " +
                    "FROM Categories", dataBaseConnection);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string catName = ((string)reader["CategoryName"]);
                        if (catName.Contains('/'))
                        {
                            catName = catName.Replace('/', ' ');
                        }
                        byte[] pictureBytes = reader["Picture"] as byte[];

                        MemoryStream stream = new MemoryStream(
                            pictureBytes, fileOffset,
                            pictureBytes.Length - fileOffset);

                        Image image = Image.FromStream(stream);
                        using (image)
                        {
                            image.Save("..\\..\\" + catName + ".jpg", ImageFormat.Jpeg);
                        }
                    }

                    Console.WriteLine("Images are in the project folder");
                }
            }
        }
    }
}

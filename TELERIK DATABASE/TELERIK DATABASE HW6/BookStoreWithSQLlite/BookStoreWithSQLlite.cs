using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

class Program
{
    static void CreateDB(MySqlConnection connection)
    {
        StreamReader sqlScript = new StreamReader("../../CreateBooksSQL.sql");

        MySqlCommand createDB = new MySqlCommand(sqlScript.ReadToEnd(), connection);

        createDB.ExecuteNonQuery();

        Console.WriteLine("Database Books is created.");
    }

    static void InsertBook(MySqlConnection connection, string author, string title, string ISBN, string publishDate)
    {
        string insertSql = @"USE Books; INSERT INTO BOOKS(ISBN, Title, Author, PublishDate)
                            VALUES(@ISBN, @Title, @Author, @PublishDate)";

        MySqlCommand insertBook = new MySqlCommand(insertSql, connection);

        insertBook.Parameters.AddWithValue("@ISBN", ISBN);
        insertBook.Parameters.AddWithValue("@Title", title);
        insertBook.Parameters.AddWithValue("@Author", author);
        insertBook.Parameters.AddWithValue("@PublishDate", publishDate);

        insertBook.ExecuteNonQuery();

        Console.WriteLine("The book is inserted successfully.");
    }

    static void ListAllBooks(MySqlConnection connection)
    {
        string insertSql = @"USE Books; SELECT ISBN, Title, Author, PublishDate FROM Books";

        MySqlCommand insertBook = new MySqlCommand(insertSql, connection);

        using (MySqlDataReader reader = insertBook.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine("{0} | {1} | {2} | {3}", reader[0], reader[1], reader[2], reader[3]);
            }
        }
    }

    static void FindBookByName(MySqlConnection connection, string title)
    {
        string insertSql = @"USE Books; SELECT ISBN, Title, Author, PublishDate FROM Books WHERE Title LIKE @bookName";

        MySqlCommand insertBook = new MySqlCommand(insertSql, connection);

        insertBook.Parameters.AddWithValue("@bookName", "%" + title + "%");
        Console.WriteLine(insertSql);
        using (MySqlDataReader reader = insertBook.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine("{0} | {1} | {2} | {3}", reader[0], reader[1], reader[2], reader[3]);
            }
        }
    }

    static void Main(string[] args)
    {
        string connToMySql = @"Server=localhost;Uid=root;Pwd=root;Allow User Variables=True;";

        MySqlConnection connect = new MySqlConnection(connToMySql);

        connect.Open();

        using (connect)
        {
            CreateDB(connect);

            InsertBook(connect, "Book1", "River draws potatoes", "Tosho", "2000, 01, 12");
            InsertBook(connect, "Book2", "River draws potatoes2", "Tosho1", "2000, 01, 12");
            InsertBook(connect, "Book3", "River draws potatoes3", "Tosho2", "2000, 01, 12");
            InsertBook(connect, "Book4", "River draws potatoes4", "Tosho", "2000, 01, 12");

            ListAllBooks(connect);

            Console.Write("Enter a search word:");
            string searchString = Console.ReadLine().Replace("%", "[%]")
                                                .Replace("_", "[_]");
            Console.WriteLine();
            FindBookByName(connect, searchString);
        }


    }
}

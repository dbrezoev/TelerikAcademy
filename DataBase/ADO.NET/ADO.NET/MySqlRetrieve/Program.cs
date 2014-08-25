namespace MySqlRetrieve
{
    using System;
    using MySql.Data.MySqlClient;

    public class Program
    {
        private const string Command = "SELECT * FROM Books";
        static void Main()
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=booksdb;Uid=root;Pwd=root;");
            connection.Open();

            using (connection)
            {
                MySqlCommand command = new MySqlCommand(Command, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string bookTitle = (string)reader["Title"];
                    string bookAuthor = (string)reader["Author"];

                    //TODO Use DateTime instead
                    string publishDate = (string)reader["PublishDate"];
                    string isbn = (string)reader["ISBN"];

                    Console.WriteLine("Book Title: {0}\nAuthor: {1}\nPublish Date: {2}\nISBN: {3}", bookTitle, bookAuthor, publishDate, isbn);

                }
            }
        }
    }
}

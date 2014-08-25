/*
 * ****************** TASK 8 *******************
 * Write a program that reads a string from the console and finds
 * all products that contain this string. Ensure you handle correctly characters like ', %, ", \ and _.
 */
namespace QueriesWithEscaping
{
    using System;
    using System.Data.SqlClient;

    public  class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(
                "Server=.; Database=Northwind; Integrated Security = true");

            string searchString = Console.ReadLine().Replace("%", "[%]")
                                                .Replace("_", "[_]"); 

            connection.Open();
            using (connection)
            {                
                SqlCommand getCategories = new SqlCommand(
                    "SELECT ProductName FROM Products " +
                    "WHERE ProductName LIKE @searchParameter", connection);

                getCategories.Parameters.AddWithValue("@searchParameter", "%" + searchString + "%");

                var reader = getCategories.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string line = string.Format("{0,25}",
                            (string)reader["ProductName"]);
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}

/*
 * ************FIRST TASK ****************
 *Write a program that retrieves from the Northwind
 *sample database in MS SQL
 *Server the number of  rows in the Categories table.
 */

/*
 ************ SECOND TASK ****************
 *Write a program that retrieves
 *the name and description of all categories in the Northwind DB.

 */

/*
 * ********* THIRD TASK ******************
 * Write a program that retrieves from the Northwind database all product
 * categories and the names of the products in each category.
 * Can you do this with a single SQL query (with table join)?
 */

/*
 *********** FOURTH TASK ****************
 *Write a method that adds a new product in the products table in the Northwind database.
 *Use a parameterized SQL command.
 */

/*
 ********** FIFTH TASK ****************
 *Write a program that retrieves the images for all categories
 *in the Northwind database and stores them as JPG files in the file system.
 */
namespace NorthWindRetrieve
{
    using System;
    using System.Data.SqlClient;
    using System.IO;
    using System.Drawing;
    using System.Drawing.Imaging;

    public class EntryPoint
    {       
        private const string FirstTaskQuery = "SELECT COUNT(*) FROM Categories";
        private const string SecondTaskQuery = "SELECT CategoryName, Description FROM Categories";
        private const string ThirdTaskQuery = @"SELECT c.CategoryName, p.ProductName
                                                    FROM Categories c
                                                    JOIN Products p 
                                                    ON c.CategoryID = p.CategoryID";
        private const string FifthTaskQuery = "SELECT Picture FROM Categories";
        private const string CreateFolder = @"D:\ADO.NET";

        // more info here http://tihomir.me/tag/northwind
        private const int OLE_METAFILEPICT_START_POSITION = 78;

        static void Main(string[] args)
        {
            NorthWindRetriever retriever = new NorthWindRetriever();
            try
            {
                retriever.ConnectToDB();

                //FIRST TASK
                SqlCommand command = new SqlCommand(
                    FirstTaskQuery, retriever.Connection);

                int result = (int)command.ExecuteScalar();
                Console.WriteLine("The rows in Categories are {0}\n", result);

                //SECOND TASK
                SqlCommand command2 = new SqlCommand(
                    SecondTaskQuery, retriever.Connection);
                SqlDataReader reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("Category name: {0};\nDescription: {1}\n", categoryName, description);
                }

                reader.Close();

                //THIRD TASK
                SqlCommand command3 = new SqlCommand(
                    ThirdTaskQuery, retriever.Connection);
                SqlDataReader reader2 = command3.ExecuteReader();
                while (reader2.Read())
                {
                    string categoryName2 = (string)reader2["CategoryName"];
                    string productName = (string)reader2["ProductName"];
                    Console.WriteLine("Category Name: {0};\nProduct Name: {1};\n", categoryName2, productName);
                }

                reader2.Close();

                //FOURTH TASK
                retriever.AddProduct("Rakia", 1, 1, "2 litra", 5.5m, 10, 5, 5, false);
                Console.WriteLine("Product added successfully...");

                //FIFTH TASK
                
                SqlCommand getFilesCommand = new SqlCommand(
                    FifthTaskQuery, retriever.Connection);
                SqlDataReader fileReader = getFilesCommand.ExecuteReader();
                using (fileReader)
                {
                    int i = 0;
                    while (fileReader.Read())
                    {
                        i++;

                        byte[] pictureBytes = fileReader["Picture"] as byte[];
                        MemoryStream stream = new MemoryStream(pictureBytes, OLE_METAFILEPICT_START_POSITION, pictureBytes.Length - OLE_METAFILEPICT_START_POSITION);
                        Image image = Image.FromStream(stream);
                        using (image) 
                        { 
                            image.Save(i + ".jpg", ImageFormat.Jpeg);
                            //look in bin\debug
                        } 
                    }
                }
            }

            finally 
            {
                retriever.DisconnectFromDB();
            }            
        }
    }
}

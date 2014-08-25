/************** TASK 6 **********************
 * Create an Excel file with 2 columns: name and score
 * Write a program that reads your MS Excel file
 * through the OLE DB data
 * provider and displays the name and score row by row.
 */

/*
 * ************** TASK 7 ********************
 * Implement appending new rows to the Excel file.
 */

namespace ExcelConnection
{
    using System;
    using System.Data;
    using System.Data.OleDb;

    public class Program
    {
        private const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ado.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=Yes;IMEX=1;""";
        private const string NewNameEntry = "Gin4eto";
        private const double NewScoreEntry = 12d;
        static void Main(string[] args)
        {
            OleDbConnection connection = new OleDbConnection(ConnectionString);

            connection.Open();

            using (connection)
            {                
                //TASK 7
                OleDbCommand insertCommand = new OleDbCommand("INSERT INTO [MyTable$] (Name, Score) VALUES (@Name, @Score)", connection);
                insertCommand.Parameters.AddWithValue("@Name", NewNameEntry);
                insertCommand.Parameters.AddWithValue("@Score", NewScoreEntry);
                insertCommand.ExecuteNonQuery();

                Console.WriteLine("Data inserted successfully.");

                connection.Close();
            }

        }
    }
}

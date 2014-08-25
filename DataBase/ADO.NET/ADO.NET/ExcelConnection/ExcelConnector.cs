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

    public class ExcelConnector
    {
        private const string NewNameEntry = "New Entry";
        private const string NewScoreEntry = "125";

        static void Main()
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ado.xlsx;Extended Properties=Excel 12.0;");
           
            connection.Open();
            using (connection)
            {
                //TASK 6
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Sheet1$]", connection);
                OleDbDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        double score = (double)reader["Score"];
                        Console.WriteLine("{0} - score: {1}", name, score);
                    }
                }               
            }

            //TASK 7
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ado.xlsx;Extended Properties=Excel 12.0;");
            con.Open();
            using (con)
            {
                OleDbCommand insertCommand = new OleDbCommand("INSERT INTO [Sheet1$] (Name, Score) VALUES (@Name, @Score)", con);

                insertCommand.Parameters.AddWithValue("@Name", NewNameEntry);
                insertCommand.Parameters.AddWithValue("@Score", NewScoreEntry);
                insertCommand.ExecuteNonQuery();

                Console.WriteLine("Data inserted successfully.");
            }
        }
    }
}

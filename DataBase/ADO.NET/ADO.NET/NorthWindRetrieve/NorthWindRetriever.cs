namespace NorthWindRetrieve
{
    using System.Data.SqlClient;
    using System.IO;

    public class NorthWindRetriever
    {
        private SqlConnection connection;
        public const string ConnectionString = "Server=.\\; " +
            "Database=Northwind; Integrated Security=true";

        public SqlConnection Connection
        {
            get
            {
                return this.connection;
            }
        }

        public void ConnectToDB()
        {
            this.connection = new SqlConnection(ConnectionString);
            this.connection.Open();
        }

        public void DisconnectFromDB()
        {
            if (this.connection != null)
            {
                this.connection.Close();
            }
        }

        public void AddProduct(string product, int supplierId, 
            int categoryId, string quantityInText, decimal unitPrice, 
            int unitsInStock, int unitsOnOrder, int reorderLevel, bool disContinued)
        {
            SqlCommand insertCommand = new SqlCommand(
                @"INSERT INTO Products VALUES (@product, @supplierId, @categoryId,
                   @quantityInText, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @disContinued)", this.Connection);
            insertCommand.Parameters.AddWithValue("@product", product);
            insertCommand.Parameters.AddWithValue("@supplierId", supplierId);
            insertCommand.Parameters.AddWithValue("@categoryId", categoryId);
            insertCommand.Parameters.AddWithValue("@quantityInText", quantityInText);
            insertCommand.Parameters.AddWithValue("@unitPrice", unitPrice);
            insertCommand.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            insertCommand.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
            insertCommand.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            insertCommand.Parameters.AddWithValue("@disContinued", disContinued);

            insertCommand.ExecuteNonQuery();
        }

        public void WriteBinaryFile(byte[] fileContents, string fileLocation)
        {
            FileStream stream = new FileStream(fileLocation, FileMode.Create);
            using (stream)
            {
                stream.Write(fileContents, 0, fileContents.Length);
            }
        }
    }
}

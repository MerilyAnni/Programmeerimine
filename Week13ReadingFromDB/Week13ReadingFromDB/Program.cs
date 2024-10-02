
internal class Program
{
    private static void Main(string[] args)
    {
        CreateConnection();

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection connection = SQLiteConnection("Data Source=mydb.db; Version=3; New=True; Compress=True;");

            try
            {
                connection.Open();
                Console.WriteLine("Connection establisehed");
            }
            catch
            {
                Console.WriteLine("DB connection failed");
            }

            return connection;
        }

        static void ReadData(SQLiteConnection myConnection)
        {
            // SQLiteDataReader read;
            SQLiteCommand command;

            string fName = "Harry";
            string lName = "Potter";
            string dob = "07-31-1980";

            command = myConnection.CreateCommand();
            command = $"INSERT INTO customer(firstName, lastName, dateOfBirth) VALUES ('{fName}', '{lName}', '{dob}')";

            int rowInserted = command.ExcuteNonQuery();
            Console.Clear();
            Console.WriteLine($"Rows insterted: {rowInserted}");
            ReadData(myConnection);

            myConnection.Close();
            //read = command.ExcuteReader();

            // while (read.Read())
            // {
            //string fname = read.GetString(0);
            //string lname = read.GetString(1);
            // string dob = read.GetString(2);

            //Console.Writeline($"Full Name: {fName}; {lName}; DoB: {dob}");

            // }
            //myConnection.Close();
        }

        static void RemoveCustomer(SQLiteConnection myConnection)
        {
            SQLiteCommand command;
            string idToDelete = "9";

            command = myConnection.CreateCommand();
            command.CommandText = $"DELETE FROM customer WHERE rowid = {idToDelete}";

            int rowsDelete = command.ExcuteNonQuery();

            Console.Clear();
            object rowsDeleted = null;
            Console.WriteLine($"Rows deleted: {rowsDeleted}");

            ReadData(myConnection);

            myConnection.Close();
        }
    }

    //private static SQLiteConnection SQLiteConnection(string v)
    
        throw private static SQLiteConnection SQLiteConnection(string v)
    {
        throw new NotImplementedException();
    }

    new NotImplementedException();
    
}
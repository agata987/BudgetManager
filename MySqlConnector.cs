using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BudzetManager
{
    class MySqlConnector
    {

        MySqlConnection connection;
        MySqlDataAdapter adapter;
        string server;
        string database;
        string uid;
        string password;

        public MySqlConnector()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "remotemysql.com";
            database = "uiZU4ZA6xV";
            uid = "uiZU4ZA6xV";
            password = "OgTIPV9l7h";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database Connection Established");
                return true;
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Nie można połączyć się z serwerem.");

                switch (e.Number)
                {

                    case 0:
                        Console.WriteLine("Database Connection Error: Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Database Connection Error: Invalid username/ password, please try again");
                        break;
                }

                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Database Connection Closed");
                return true;
            }
            catch(MySqlException e)
            {
                Console.WriteLine("Database Connection Close Error: " + e.Number);
                return false;
            }
        }

        // insert, update or delete statement
        public bool Query(string query)
        {
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                Console.WriteLine("Rows affected: " + cmd.ExecuteNonQuery());

                this.CloseConnection();

                return true;

            }
            else
            {
                Console.WriteLine("Query Execution Failed: no connection to database");

                return false;
            }
        }

        // select statement
        public MySqlDataReader Select(string query)
        {

            if(this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
               
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    Console.WriteLine("Select statement executed");

                    return reader;

                }
                catch (MySqlException e)
                {
                    Console.WriteLine("MySqlReader exception: " + e.Number);
                    CloseConnection();

                    return null;
                }

            } else
            {
                Console.WriteLine("Query Execution Failed: no connection to database");

                return null;
            }

        }

       public MySqlDataAdapter dataAdapter(string query)
       {
            if (this.OpenConnection())
            {
                adapter = new MySqlDataAdapter(query, connection);
                return adapter;
            }
            else return null;
       }

    }
}

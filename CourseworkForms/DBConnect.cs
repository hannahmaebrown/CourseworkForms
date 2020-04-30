using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CourseworkForms
{
    class DBConnect
    {
        public MySqlConnection connection;
        public static string server;
        public static string database;
        public static string uid;
        public static string password;
        public static string SslMode;
        
        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "proj-mysql.uopnet.plymouth.ac.uk";
            database = "isad157_hbrown";
            uid = "ISAD157_HBrown";
            password = "ISAD157_22226628";
            SslMode = "Required";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + 
                ";" + "PASSWORD=" + password + ";" + "SSLMODE=" + SslMode + ";";

            connection = new MySqlConnection(connectionString);
            
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Connection is OPEN!!!");
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CourseworkForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBConnect connect = new DBConnect();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CBOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOpenConnect_Click(object sender, EventArgs e)
        {
            DBConnect connect = new DBConnect();
            connect.OpenConnection();
        }

        public void CBOptions_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CBOptions.SelectedIndex == 0)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.server + ";" +
                        "DATABASE=" + DBConnect.database + ";" + "UID=" +
                        DBConnect.uid + ";" + "PASSWORD=" +
                        DBConnect.password + ";" + "SslMode=" +
                        DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                        new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_hbrown.users";



                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable userDataTable = new DataTable();
                    sqlDA.Fill(userDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    DGLoadData.DataSource = userDataTable;

                } // End of using (MySqlConnection connection = ...
            }
            else
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.server + ";" +
                    "DATABASE=" + DBConnect.database + ";" + "UID=" +
                    DBConnect.uid + ";" + "PASSWORD=" +
                    DBConnect.password + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "SELECT * FROM isad157_hbrown.friends"; 

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable friendsDataTable = new DataTable();
                    sqlDA.Fill(friendsDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the friends table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    DGLoadData.DataSource = friendsDataTable;
                }
            }
            if (CBOptions.SelectedIndex == 2)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString1 = "SERVER=" + DBConnect.server + ";" +
                        "DATABASE=" + DBConnect.database + ";" + "UID=" +
                        DBConnect.uid + ";" + "PASSWORD=" +
                        DBConnect.password + ";" + "SslMode=" +
                        DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection1 =
                        new MySqlConnection(connectionString1))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query1 = "SELECT * FROM isad157_hbrown.universities";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection1.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection1);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd1);
                    DataTable uniDataTable = new DataTable();
                    sqlDA.Fill(uniDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    DGLoadData.DataSource = uniDataTable;

                } // End of using (MySqlConnection connection = ...
            }// End of private void CBOptions_SelectedIndexChanged
            if (CBOptions.SelectedIndex == 3)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString1 = "SERVER=" + DBConnect.server + ";" +
                        "DATABASE=" + DBConnect.database + ";" + "UID=" +
                        DBConnect.uid + ";" + "PASSWORD=" +
                        DBConnect.password + ";" + "SslMode=" +
                        DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection1 =
                        new MySqlConnection(connectionString1))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query1 = "SELECT * FROM isad157_hbrown.workplace";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection1.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection1);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd1);
                    DataTable workplaceDataTable = new DataTable();
                    sqlDA.Fill(workplaceDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    DGLoadData.DataSource = workplaceDataTable;

                } // End of using (MySqlConnection connection = ...
            }
            if (CBOptions.SelectedIndex == 4)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.server + ";" +
                        "DATABASE=" + DBConnect.database + ";" + "UID=" +
                        DBConnect.uid + ";" + "PASSWORD=" +
                        DBConnect.password + ";" + "SslMode=" +
                        DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection1 =
                        new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query1 = "SELECT * FROM isad157_hbrown.messages";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection1.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection1);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd1);
                    DataTable messagesDataTable = new DataTable();
                    sqlDA.Fill(messagesDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    DGLoadData.DataSource = messagesDataTable;

                } 
            }
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchName(txtSearch.Text);
        }
        //creating a connection to run my query1 which is searching FirstName
        public void searchName(string searchName)
        {
            string connectionString = "SERVER=" + DBConnect.server + ";" +
                        "DATABASE=" + DBConnect.database + ";" + "UID=" +
                        DBConnect.uid + ";" + "PASSWORD=" +
                        DBConnect.password + ";" + "SslMode=" +
                        DBConnect.SslMode + ";";

            using (MySqlConnection connection1 =
                       new MySqlConnection(connectionString))
            {
                string query1 = "SELECT * from Users where FirstName like '%" + searchName + "%'";
                
                connection1.Open();

                MySqlCommand cmd1 = new MySqlCommand(query1, connection1);
                
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd1);
                DataTable UsersDataTable = new DataTable();
                sqlDA.Fill(UsersDataTable);
                
                DGLoadData.DataSource = UsersDataTable;
            }
        }

        private void txtSearchUserID_TextChanged(object sender, EventArgs e)
        {
            searchUniversities(txtSearchUserID.Text);
        }
        //creating a connection to run my query2 which is searching UserID in Universities
        public void searchUniversities(string searchUserID)
        {
            string connectionString = "SERVER=" + DBConnect.server + ";" +
                        "DATABASE=" + DBConnect.database + ";" + "UID=" +
                        DBConnect.uid + ";" + "PASSWORD=" +
                        DBConnect.password + ";" + "SslMode=" +
                        DBConnect.SslMode + ";";

            using (MySqlConnection connection1 =
                       new MySqlConnection(connectionString))
            {
                string query2 = "SELECT * from Universities where UniversityUserID like '%" + searchUserID + "%'";

                connection1.Open();

                MySqlCommand cmd1 = new MySqlCommand(query2, connection1);

                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd1);
                DataTable UniversitiesDataTable = new DataTable();
                sqlDA.Fill(UniversitiesDataTable);

                DGLoadData.DataSource = UniversitiesDataTable;
            }
        }

        private void lblSearchUserID_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchWorkplaces_TextChanged(object sender, EventArgs e)
        {
            searchWorkplaceID(txtSearchWorkplaces.Text);
        }
        //creating a connection to run my query3 which is searching UserID in Workplaces
        public void searchWorkplaceID(string searchWorkplace)
        {
            string connectionString = "SERVER=" + DBConnect.server + ";" + 
                "DATABASE=" + DBConnect.database + ";" + "UID=" +
                DBConnect.uid + ";" + "PASSWORD=" +
                DBConnect.password + ";" + "SslMode=" +
                DBConnect.SslMode + ";";

            using (MySqlConnection connection1 =
                       new MySqlConnection(connectionString))
            {
                string query3 = "SELECT * from Workplace where WorkplaceUserID like '%" + searchWorkplace + "%'";

                connection1.Open();

                MySqlCommand cmd1 = new MySqlCommand(query3, connection1);

                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd1);
                DataTable WorkplaceDataTable = new DataTable();
                sqlDA.Fill(WorkplaceDataTable);

                DGLoadData.DataSource = WorkplaceDataTable;
            }
        }

        private void txtSearchMessages_TextChanged(object sender, EventArgs e)
        {
            searchMessages(txtSearchMessages.Text);
        }
        //creating a connection to run my query4 which is searching SenderUserID in Messages
        public void searchMessages(string searchMessage)
        {
            string connectionString = "SERVER=" + DBConnect.server + ";" +
                "DATABASE=" + DBConnect.database + ";" + "UID=" +
                DBConnect.uid + ";" + "PASSWORD=" +
                DBConnect.password + ";" + "SslMode=" +
                DBConnect.SslMode + ";";
            using (MySqlConnection connection1 =
                      new MySqlConnection(connectionString))
            {
                string query4 = "SELECT * from Messages where SenderUserID like '%" + searchMessage + "%'";

                connection1.Open();

                MySqlCommand cmd1 = new MySqlCommand(query4, connection1);

                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd1);
                DataTable MessageDataTable = new DataTable();
                sqlDA.Fill(MessageDataTable);

                DGLoadData.DataSource = MessageDataTable;
            }
        }

        private void txtSearchFriends_TextChanged(object sender, EventArgs e)
        {
            searchFriends(txtSearchFriends.Text);
        }
        //creating a connection to run my query5 which is searching FriendUserID1 in Friends
        public void searchFriends(string searchFriend)
        {
            string connectionString = "SERVER=" + DBConnect.server + ";" +
                "DATABASE=" + DBConnect.database + ";" + "UID=" +
                DBConnect.uid + ";" + "PASSWORD=" +
                DBConnect.password + ";" + "SslMode=" +
                DBConnect.SslMode + ";";

            using (MySqlConnection connection1 =
                      new MySqlConnection(connectionString))
            {
                string query5 = "SELECT * from Friends where FriendUserID1 like '%" + searchFriend + "%'";

                connection1.Open();

                MySqlCommand cmd1 = new MySqlCommand(query5, connection1);

                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd1);
                DataTable FriendDataTable = new DataTable();
                sqlDA.Fill(FriendDataTable);

                DGLoadData.DataSource = FriendDataTable;
            }
        }
    }
}
        
 
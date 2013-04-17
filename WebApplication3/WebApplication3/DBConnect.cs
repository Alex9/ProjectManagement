using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "cbhcapstone";
            uid = "root";
            password = "SharkDucks1";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
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

        //Insert PHOENIX CITY home_price_index statement
        public void InsertPHXrnsa(System.Web.UI.WebControls.ListBox ListBox1)
        {

            //open connection
            if (this.OpenConnection() == true)
            {
                string a, b, c, d, e;

                FRED f = new FRED();

                b = "Phoenix"; // cityName

                c = "Maricopa"; // countyName

                d = f.phxrnsa(); // home_price_index

                a = f.getDate(); // date

                e = "NULL"; // unemployment

                MessageBox.Show(a);

                if (d == "DNF")
                {
                    ListBox1.Text = "PHXrnsa up to date! \n";
                }

                else
                {

                    try
                    {

                        String query = String.Format("INSERT INTO city_stats VALUES('{0}', '{1}', '{2}', '{3}', {4})", a, b, c, d, e);

                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        //Execute command
                        cmd.ExecuteNonQuery();

                        ListBox1.Text = String.Format("{0} has been updated with PHXrnsa. \n", a);

                    }

                    catch { UpdatePHXrnsa(d, a, ListBox1); }
                }
            }
        }

        //Update PHOENIX CITY home_price_index statement
        public void UpdatePHXrnsa(String d, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE city_stats SET home_price_index= '{0}' WHERE date ='{1}'", d, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text = String.Format("{0} has been updated with PHXrnsa. \n", a);
        }


        //Insert PHOENIX CITY unemployment_NSA statement
        public void InsertPhoeURN(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e;

            FRED f = new FRED();

            b = "Phoenix"; // cityName

            c = "Maricopa"; // countyName

            d = "NULL"; // home_price_index

            a = f.getDate(); // date

            e = f.phoeURN(); // unemployment

            if (e == "DNF")
            {
                ListBox1.Text += "phoeURN up to date! \n";
            }

            else
            {

                try
                {
                    String query = String.Format("INSERT INTO city_stats VALUES('{0}', '{1}', '{2}', {3}, '{4}')", a, b, c, d, e);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with phoeURN. \n", a);

                }
                catch { UpdatePhoeURN(e, a, ListBox1); }
            }
        }

        //Update PHOENIX CITY unemployment_NSA statement
        public void UpdatePhoeURN(String e, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE city_stats SET unemployment_NSA= '{0}' WHERE date ='{1}'", e, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with phoeURN. \n", a);
        }

        //Insert MARICOPA COUNTY unemployment_NSA statement
        public void InsertMariURN(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e, f;

            FRED m = new FRED();

            a = m.getDate(); // date

            b = "Maricopa"; //countyName

            c = "Arizona"; // stateName

            d = m.AZMARIURN(); // unemployment_NSA

            e = "NULL"; // population_NSA

            f = "NULL"; // labor_force_NSA

            if (d == "DNF")
            {
                ListBox1.Text += "mariURN up to date! \n";
            }

            else
            {
                try
                {
                    String query = String.Format("INSERT INTO county_stats VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5})", a, b, c, d, e, f);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with MariURN. \n", a);
                }
                catch { UpdateMariURN(d, a, ListBox1); }
            }
        }

        //Update MARICOPA COUNTY unemployment_NSA statement
        public void UpdateMariURN(String d, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE county_stats SET unemployment_NSA= '{0}' WHERE date ='{1}'", d, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with MariURN. \n", a);
        }

        //Insert MARICOPA COUNTY population_NSA statement
        public void InsertMariPOP(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e, f;

            FRED m = new FRED();

            a = m.getDate(); // date

            b = "Maricopa"; //countyName

            c = "Arizona"; // stateName

            d = "NULL"; // unemployment_NSA

            e = m.AZMARIPOP(); // population_NSA

            f = "NULL"; // labor_force_NSA

            if (e == "DNF")
            {
                ListBox1.Text += "mariPOP up to date! \n";
            }

            else
            {
                try
                {
                    String query = String.Format("INSERT INTO county_stats VALUES('{0}', '{1}', '{2}', {3}, '{4}', {5})", a, b, c, d, e, f);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with MariPOP. \n", a);
                }
                catch { UpdateMariPOP(e, a, ListBox1); }
            }
        }

        //Update MARICOPA COUNTY population_NSA statement
        public void UpdateMariPOP(String e, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE county_stats SET population_NSA= '{0}' WHERE date ='{1}'", e, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with MariPOP. \n", a);
        }

        //Insert MARICOPA COUNTY population_NSA statement
        public void InsertMariLFN(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e, f;

            FRED m = new FRED();

            a = m.getDate(); // date

            b = "Maricopa"; //countyName

            c = "Arizona"; // stateName

            d = "NULL"; // unemployment_NSA

            e = "NULL"; // population_NSA

            f = m.AZMARILFN(); // labor_force_NSA

            if (f == "DNF")
            {
                ListBox1.Text += "mariLFN up to date! \n";
            }

            else
            {
                try
                {
                    String query = String.Format("INSERT INTO county_stats VALUES('{0}', '{1}', '{2}', {3}, {4}, '{5}')", a, b, c, d, e, f);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with MariLFN. \n", a);
                }
                catch { UpdateMariLFN(f, a, ListBox1); }
            }
        }

        //Update MARICOPA COUNTY population_NSA statement
        public void UpdateMariLFN(String f, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE county_stats SET labor_force_NSA= '{0}' WHERE date ='{1}'", f, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with MariLFN. \n", a);
        }

        //Insert All-Transactions House Price Index for Arizona
        public void InsertAZSTHPI(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e, f, g, h, i;

            FRED m = new FRED();

            a = m.getDate(); // date

            b = "Arizona"; // stateName

            c = m.AZSTHPI(); // all-transactions HPI

            d = "NULL"; // 20rsa

            e = "NULL"; // 20rnsa

            f = "NULL"; // 20rpsnsa

            g = "NULL"; // 10rsa

            h = "NULL"; // 10rnsa

            i = "NULL"; // 10rpsnsa

            if (c == "DNF")
            {
                ListBox1.Text += "AZSTHPI up to date! \n";
            }

            else
            {
                try
                {
                    String query = String.Format("INSERT INTO state_stats VALUES('{0}', '{1}', '{2}', {3}, {4}, {5}, {6}, {7}, {8})", a, b, c, d, e, f, g, h, i);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with AZSTHPI. \n", a);
                }
                catch { UpdateAZSTHPI(c, a, ListBox1); }
            }
        }

        //Update All-Transactions House Price Index for Arizona
        public void UpdateAZSTHPI(String c, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE state_stats SET all_trans_house_price_index= '{0}' WHERE date ='{1}'", c, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with AZSTHPI. \n", a);
        }

        //Insert Case-Shiller Composite-20
        public void InsertSPCS20RSA(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e, f, g, h, i;

            FRED m = new FRED();

            a = m.getDate(); // date

            b = "Arizona"; // stateName

            c = "NULL"; // all-transactions HPI

            d = m.SPCS10RSA(); // 20rsa

            e = "NULL"; // 20rnsa

            f = "NULL"; // 20rpsnsa

            g = "NULL"; // 10rsa

            h = "NULL"; // 10rnsa

            i = "NULL"; // 10rpsnsa

            if (d == "DNF")
            {
                ListBox1.Text += "SPCS20RSA up to date! \n";
            }

            else
            {
                try
                {
                    String query = String.Format("INSERT INTO state_stats VALUES('{0}', '{1}', {2}, '{3}', {4}, {5}, {6}, {7}, {8})", a, b, c, d, e, f, g, h, i);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with SPCS20RSA. \n", a);
                }
                catch { UpdateSPCS20RSA(d, a, ListBox1); }
            }
        }

        //Update Case-Shiller Composite-20
        public void UpdateSPCS20RSA(String d, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE state_stats SET cs20city_home_price_index_SA= '{0}' WHERE date ='{1}'", d, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with SPCS20RSA. \n", a);
        }

        //Insert Case-Shiller Composite-20 Not Seasonally Adjusted
        public void InsertSPCS20RNSA(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e, f, g, h, i;

            FRED m = new FRED();

            a = m.getDate(); // date

            b = "Arizona"; // stateName

            c = "NULL"; // all-transactions HPI

            d = "NULL"; // 20rsa

            e = m.SPCS20RNSA(); // 20rnsa

            f = "NULL"; // 20rpsnsa

            g = "NULL"; // 10rsa

            h = "NULL"; // 10rnsa

            i = "NULL"; // 10rpsnsa

            if (e == "DNF")
            {
                ListBox1.Text += "SPCS20RNSA up to date! \n";
            }

            else
            {
                try
                {
                    String query = String.Format("INSERT INTO state_stats VALUES('{0}', '{1}', {2}, {3}, '{4}', {5}, {6}, {7}, {8})", a, b, c, d, e, f, g, h, i);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with SPCS20RNSA. \n", a);
                }
                catch { UpdateSPCS20RNSA(e, a, ListBox1); }
            }
        }

        //Update Case-Shiller Composite-20 Not Seasonally Adjusted
        public void UpdateSPCS20RNSA(String e, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE state_stats SET cs20city_home_price_index_NSA= '{0}' WHERE date ='{1}'", e, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with SPCS20RNSA. \n", a);
        }

        //Insert S&P Case-Shiller 20-City Home Price Sales Pair Counts
        public void InsertSPCS20RPSNSA(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e, f, g, h, i;

            FRED m = new FRED();

            a = m.getDate(); // date

            b = "Arizona"; // stateName

            c = "NULL"; // all-transactions HPI

            d = "NULL"; // 20rsa

            e = "NULL"; // 20rnsa

            f = m.SPCS20RPSNSA(); // 20rpsnsa

            g = "NULL"; // 10rsa

            h = "NULL"; // 10rnsa

            i = "NULL"; // 10rpsnsa

            if (f == "DNF")
            {
                ListBox1.Text += "SPCS20RPSNSA up to date! \n";
            }

            else
            {
                try
                {
                    String query = String.Format("INSERT INTO state_stats VALUES('{0}', '{1}', {2}, {3}, {4}, '{5}', {6}, {7}, {8})", a, b, c, d, e, f, g, h, i);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with SPCS20RPSNSA. \n", a);
                }
                catch { UpdateSPCS20RPSNSA(f, a, ListBox1); }
            }
        }

        //Update S&P Case-Shiller 20-City Home Price Sales Pair Counts
        public void UpdateSPCS20RPSNSA(String f, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE state_stats SET cs20city_home_price_sales_pair_counts_NSA= '{0}' WHERE date ='{1}'", f, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with SPCS20RPSNSA. \n", a);
        }

        //Insert Case-Shiller Composite-10
        public void InsertSPCS10RSA(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e, f, g, h, i;

            FRED m = new FRED();

            a = m.getDate(); // date

            //a = "2014-05-01"; // date

            b = "Arizona"; // stateName

            c = "NULL"; // all-transactions HPI

            d = "NULL"; // 20rsa

            e = "NULL"; // 20rnsa

            f = "NULL"; // 20rpsnsa

            g = m.SPCS10RSA(); // 10rsa

            //g = "97";  //10rsa

            h = "NULL"; // 10rnsa

            i = "NULL"; // 10rpsnsa

            if (g == "DNF")
            {
                ListBox1.Text += "SPCS10RSA up to date! \n";
            }

            else
            {
                try
                {
                    String query = String.Format("INSERT INTO state_stats VALUES('{0}', '{1}', {2}, {3}, {4}, {5}, '{6}', {7}, {8})", a, b, c, d, e, f, g, h, i);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with SPCS10RSA. \n", a);
                }
                catch { UpdateSPCS10RSA(g, a, ListBox1); }
            }
        }

        //Update Case-Shiller Composite-10
        public void UpdateSPCS10RSA(String g, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE state_stats SET cs10city_home_price_index_SA= '{0}' WHERE date ='{1}'", g, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with SPCS10RSA. \n", a);
        }

        //Insert Case-Shiller Composite-10 Not Seasonally Adjusted
        public void InsertSPCS10RNSA(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e, f, g, h, i;

            FRED m = new FRED();

            a = m.getDate(); // date

            b = "Arizona"; // stateName

            c = "NULL"; // all-transactions HPI

            d = "NULL"; // 20rsa

            e = "NULL"; // 20rnsa

            f = "NULL"; // 20rpsnsa

            g = "NULL"; // 10rsa

            h = m.SPCS20RNSA(); // 10rnsa

            i = "NULL"; // 10rpsnsa

            if (h == "DNF")
            {
                ListBox1.Text += "SPCS10RNSA up to date! \n";
            }

            else
            {
                try
                {


                    String query = String.Format("INSERT INTO state_stats VALUES('{0}', '{1}', {2}, {3}, {4}, {5}, {6}, '{7}', {8})", a, b, c, d, e, f, g, h, i);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with SPCS10RNSA. \n", a);
                }
                catch { UpdateSPCS10RNSA(h, a, ListBox1); }
            }
        }

        //Update Case-Shiller Composite-10 Not Seasonally Adjusted
        public void UpdateSPCS10RNSA(String h, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE state_stats SET cs10city_home_price_index_NSA= '{0}' WHERE date ='{1}'", h, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with SPCS10RNSA. \n", a);
        }

        //Insert CS&P Case-Shiller 10-City Home Price Sales Pair Counts
        public void InsertSPCS10RPSNSA(System.Web.UI.WebControls.ListBox ListBox1)
        {
            string a, b, c, d, e, f, g, h, i;

            FRED m = new FRED();

            a = m.getDate(); // date

            b = "Arizona"; // stateName

            c = m.AZSTHPI(); // all-transactions HPI

            d = "NULL"; // 20rsa

            e = "NULL"; // 20rnsa

            f = "NULL"; // 20rpsnsa

            g = "NULL"; // 10rsa

            h = "NULL"; // 10rnsa

            i = m.SPCS20RPSNSA(); // 10rpsnsa

            if (i == "DNF")
            {
                ListBox1.Text += "SPCS10RPSNSA up to date! \n";
            }

            else
            {
                try
                {


                    String query = String.Format("INSERT INTO state_stats VALUES('{0}', '{1}', {2}, {3}, {4}, {5}, {6}, {7}, '{8}')", a, b, c, d, e, f, g, h, i);

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    ListBox1.Text += String.Format("{0} has been updated with SPCS10RPSNSA. \n", a);
                }
                catch { UpdateSPCS10RPSNSA(i, a, ListBox1); }
            }
        }

        //Update CS&P Case-Shiller 10-City Home Price Sales Pair Counts
        public void UpdateSPCS10RPSNSA(String i, String a, System.Web.UI.WebControls.ListBox ListBox1)
        {
            String query1 = String.Format("UPDATE state_stats SET cs10city_home_price_sales_pair_counts_NSA= '{0}' WHERE date ='{1}'", i, a);

            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query1;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            ListBox1.Text += String.Format("{0} has been updated with SPCS10RPSNSA. \n", a);
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM state WHERE stateName='Nevada'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM state";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["state"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM state";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
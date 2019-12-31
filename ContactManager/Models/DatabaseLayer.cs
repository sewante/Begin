using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ContactManager.Models
{
    public class DatabaseLayer
    {
        private MySqlConnection mysqlConnection = null;

        // create the Database connector
        public DatabaseLayer()
        {
            try
            {
                string mysqlConnectionString = ConfigurationManager.AppSettings["MYSQL_DB"];
                mysqlConnection = new MySqlConnection(mysqlConnectionString);
            }
            catch (Exception exception)
            {
                // log the exception
            }
        }
        // connect
        public void OpenConnection()
        {
            if (mysqlConnection != null)
            {
                if(mysqlConnection.State == ConnectionState.Closed)
                    mysqlConnection.Open();
            }
        }
        // close
        public void CloseConnection()
        {
            if (mysqlConnection != null)
            {
                if(mysqlConnection.State == ConnectionState.Open)
                    mysqlConnection.Close();
            }

        }
        public MySqlConnection GetConnection()
        {
            return this.mysqlConnection;
        }
        // get students
        // get courses

    }
}
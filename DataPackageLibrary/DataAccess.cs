using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite; 

namespace DataPackageLibrary
{
    public class DataAccess
    {
        //Creates the SQLite Databsse and stores it in the applications local data store. 
        public static void InitializeDatabase()
        {
            using (SqliteConnection db = new SqliteConnection("FileName=sqliteTravel.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS PackageTable (Primary_Key INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "Code VARCHAR(50) NULL, Destination VARCHAR(MAX) NULL, Location VARCHAR(MAX) NULL " +
                    "Description VARCHAR(MAX) NULL, HWRank INTEGER NULL, FamRank INTEGER NULL, AdvRank INTEGER NULL, " +
                    "CruRank INTEGER NULL, WedRank INTEGER NULL, WATER BIT DEFAULT 0 NOT NULL, SPA BIT DEFAULT 0 NOT NULL " +
                    "AMUSEMENT BIT DEFAULT 0 NOT NULL, HISTORY BIT DEFAULT 0 NOT NULL, CAMPING BIT DEFAULT 0 NOT NULL, " +
                    "ENTERTAINMENT BIT DEFAULT 0 NOT NULL, ZOO BIT DEFAULT 0 NOT NULL, GOLF BIT DEFAULT 0 NOT NULL, " +
                    "HealthWellness BIT DEFAULT 0 NOT NULL, Family BIT DEFAULT 0 NOT NULL, Adventure BIT DEFAULT 0 NOT NULL, " +
                    "Cruise BIT DEFAULT 0 NOT NULL, Wedding BIT DEFAULT 0 NOT NULL, Price INTEGER DEFAULT NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }

        
        /// <summary>
        /// Method to Retrieve rows of data from the Database Table 
        /// </summary>
        /// <returns></returns>
        public static List<String> GetData()
        {
            List<String> entries = new List<string>();

            using (SqliteConnection db =
                new SqliteConnection("Filename=sqliteTravel.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT Text_Entry from PackageTable", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                    entries.Add(query.GetString(1));
                    entries.Add(query.GetString(2));
                    entries.Add(query.GetString(3));
                    entries.Add(query.GetString(4));
                    entries.Add(query.GetString(5));
                    entries.Add(query.GetString(6));
                    entries.Add(query.GetString(7));
                    entries.Add(query.GetString(8));
                    entries.Add(query.GetString(9));
                    entries.Add(query.GetString(10));
                    entries.Add(query.GetString(11));
                    entries.Add(query.GetString(12));
                    entries.Add(query.GetString(13));
                    entries.Add(query.GetString(14));
                    entries.Add(query.GetString(15));
                    entries.Add(query.GetString(16));
                    entries.Add(query.GetString(17));
                    entries.Add(query.GetString(18));
                    entries.Add(query.GetString(19));
                    entries.Add(query.GetString(20));
                    entries.Add(query.GetString(21));
                    entries.Add(query.GetString(22));
                }

                db.Close();
            }

            return entries;
        }
    } 

}

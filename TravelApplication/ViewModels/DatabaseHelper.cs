using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApplication
{
    class DatabaseHelper
    { 
        //Initialize Database and Create Table if it does not exist already
        public static void InitializeDatabase()
        {
            using (SqliteConnection db = new SqliteConnection(@"Filename=C:\Users\melis\source\repos\TravelApplication\MWhittaker521.github.io\TravelApplication\PackageData.db"))
            {
                db.Open();
                using (SqliteCommand fmd = db.CreateCommand())
                {
                    
                    fmd.CommandText = @"SELECT * FROM Packages";
                    fmd.CommandType = System.Data.CommandType.Text;
                    SqliteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        ReadPackages dbPackages = new ReadPackages();
                        var db_packagesList = dbPackages.GetAllPackages(); 
                        foreach(object element in db_packagesList)
                        {
                            Debug.WriteLine(element.ToString()); 
                        }                      
                    }
                }
            }
        }

        ObservableCollection<Package> fullpackages = new ObservableCollection<Package>();
        public static ObservableCollection<Package> GetData()
        {
            ObservableCollection<Package> fullpackages = new ObservableCollection<Package>();
            try
            {
                using (SqliteConnection db = new SqliteConnection(@"Filename=C:\Users\melis\source\repos\TravelApplication\MWhittaker521.github.io\TravelApplication\PackageData.db"))
                {
                    db.Open();
                    
                    SqliteCommand selectCommand = new SqliteCommand
                        (@"SELECT * FROM Packages", db);

                    SqliteDataReader query = selectCommand.ExecuteReader();

                    while (query.Read())
                    {
                        object IdReader = query.GetValue(0);
                        string Code = query.GetString(1);
                        string Destination = query.GetString(2);
                        string Location = query.GetString(3);
                        string Description = query.GetString(4);
                        int HWRank = query.GetInt32(5);
                        int FamRank = query.GetInt32(6);
                        int AdvRank = query.GetInt32(7);
                        int CruRank = query.GetInt32(8);
                        int WedRank = query.GetInt32(9);
                        int Spa = query.GetInt32(10);
                        int Amusement = query.GetInt32(11);
                        int History = query.GetInt32(12);
                        int Camping = query.GetInt32(13);
                        int Entertainment = query.GetInt32(14);
                        int Healthwell = query.GetInt32(15);
                        int Family = query.GetInt32(16);
                        int Adventure = query.GetInt32(17);
                        int Cruise = query.GetInt32(18);
                        int Wedding = query.GetInt32(19);
                        int Lowprice = query.GetInt32(20);
                        int Highprice = query.GetInt32(21);
                        int DestId = query.GetInt32(22);
                        string Link = query.GetString(23);
                        var package = IdReader.ToString() + ", " + Code + ", " + Destination + ", " + Location +
                            ", " + Description + ", " + HWRank.ToString() + ", " + FamRank.ToString() + ", " + AdvRank.ToString() +
                            ", " + CruRank.ToString() + ", " + WedRank.ToString() + ", " + Spa.ToString() + ", " + Amusement.ToString() +
                            ", " + History.ToString() + ", " + Camping.ToString() + ", " + Entertainment.ToString() + ", " + Healthwell.ToString() +
                            ", " + Family.ToString() + ", " + Adventure.ToString() + ", " + Cruise.ToString() + ", " + Wedding.ToString() +
                            ", " + Lowprice.ToString() + ", " + Highprice.ToString() + ", " + DestId.ToString() + ", " + Link;
                        fullpackages.Add(new Package(IdReader, Code, Destination, Location, Description, HWRank, FamRank, AdvRank, CruRank, WedRank, Spa, Amusement, History, Camping, Entertainment, Healthwell, Family, Adventure, Cruise, Wedding, Lowprice, Highprice, DestId, Link));

                    }
                    db.Close();

                }
                return fullpackages;
            }
            catch
            {
                return null;
            }
            
        }
    }
}

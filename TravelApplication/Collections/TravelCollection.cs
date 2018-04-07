using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApplication.Collections
{
    public class TravelCollection: IObservable\\]
    {
        public ObservableCollection<TravelPack> GetTravelPackages(string connectionString)
        {
            const string GetTravelPackagesQuery = "select Dest_Id, Dest_Code, Dest_Name, Dest_Location, Dest_Description," +
                                                  " HW_Rank, FAM_Rank, ADV_Rank, CRU_Rank, WED_Rank, AMN_SPA, AMN_POOL," +
                                                  " AMN_SAUNA, AMN_NUTRITION, AMN_FITNESS, AMN_DANCE, AMN_ENTERTAINMENT," +
                                                  " AMN_FINEDINE, AMN_CAMPING, AMN_AMUSEMENT, AMN_MUSEUM_ART, AMN_HISTORIC," +
                                                  " AMN_BEACH, AMN_ZOO, AMN_GOLF, AMN_SAILING, AMN_SNORKELING, HEALTHWELL," +
                                                  " FAMILY, ADVENTURE, CRUISE, DESTWEDDING, DEST_PRICE";
            var travelPackages = new ObservableCollection<TravelPack>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetTravelPackagesQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var travelPackage = new TravelPack();
                                    travelPackage.Dest_Id = reader.GetInt32(0);
                                    travelPackage.Dest_Code = reader.GetString(1);
                                    travelPackage.Dest_Name = reader.GetString(2);
                                    travelPackage.Dest_Location = reader.GetString(3);
                                    travelPackage.Dest_Description = reader.GetString(4);
                                    travelPackage.HW_Rank = reader.GetInt32(5);
                                    travelPackage.FAM_Rank = reader.GetInt32(6);
                                    travelPackage.ADV_Rank = reader.GetInt32(7);
                                    travelPackage.CRU_Rank = reader.GetInt32(8);
                                    travelPackage.WED_Rank = reader.GetInt32(9);
                                    travelPackage.AMN_SPA = reader.GetBoolean(10);
                                    travelPackage.AMN_POOL = reader.GetBoolean(11);
                                    travelPackage.AMN_SAUNA = reader.GetBoolean(12);
                                    travelPackage.AMN_NUTRITION = reader.GetBoolean(13);
                                    travelPackage.AMN_FITNESS = reader.GetBoolean(14);
                                    travelPackage.AMN_DANCE = reader.GetBoolean(15);
                                    travelPackage.AMN_ENTERTAINMENT = reader.GetBoolean(16);
                                    travelPackage.AMN_FINEDINE = reader.GetBoolean(17);
                                    travelPackage.AMN_CAMPING = reader.GetBoolean(18);
                                    travelPackage.AMN_AMUSEMENT = reader.GetBoolean(19);
                                    travelPackage.AMN_MUSEUM_ART = reader.GetBoolean(20);
                                    travelPackage.AMN_HISTORIC = reader.GetBoolean(21);
                                    travelPackage.AMN_BEACH = reader.GetBoolean(22);
                                    travelPackage.AMN_ZOO = reader.GetBoolean(23);
                                    travelPackage.AMN_GOLF = reader.GetBoolean(24);
                                    travelPackage.AMN_SAILING = reader.GetBoolean(25);
                                    travelPackage.AMN_SNORKELING = reader.GetBoolean(26);
                                    travelPackage.HEALTHWELL = reader.GetBoolean(27);
                                    travelPackage.FAMILY = reader.GetBoolean(28);
                                    travelPackage.ADVENTURE = reader.GetBoolean(29);
                                    travelPackage.CRUISE = reader.GetBoolean(30);
                                    travelPackage.DESTWEDDING = reader.GetBoolean(31);
                                    travelPackage.DEST_PRICE = reader.GetInt32(32);
                                    travelPackages.Add(travelPackage);
                                }
                            }
                        }
                    }
                }
                return travelPackages;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }
    }
}

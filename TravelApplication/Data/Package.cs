using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApplication
{
    public class Package :IComparable
    {
        public static void InitializeDatabase()
        {
            using (SqliteConnection db = new SqliteConnection("FileName=PackageData.db"))
            {
                db.Open();
            }
        }
        ObservableCollection<Package> fullpackages = new ObservableCollection<Package>();
        public ObservableCollection<Package> GetData()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=PackageData.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT * FROM Packages", db);

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
        public Package(object IdReader, string Code, string Destination, string Location, string Description,
            int HWRank, int FamRank, int AdvRank, int CruRank, int WedRank, int Spa, int Amusement, int History,
            int Camping, int Entertainment, int Healthwell, int Family, int Adventure, int Cruise, int Wedding,
            int Lowprice, int Highprice, int DestId, string Link)
        {
            this.idreader = IdReader;
            this.dcode = Code;
            this.dest = Destination;
            this.locate = Location;
            this.descript = Description;
            this.HW = HWRank;
            this.FAM = FamRank;
            this.ADV = AdvRank;
            this.CRU = CruRank;
            this.WED = WedRank;
            this.SPA = Spa;
            this.AMUSE = Amusement;
            this.HISTORIC = History;
            this.CAMP = Camping;
            this.ENTERTAIN = Entertainment;
            this.hw = Healthwell;
            this.fam = Family;
            this.adv = Adventure;
            this.cru = Cruise;
            this.wed = Wedding;
            this.priceLow = Lowprice;
            this.priceHigh = Highprice;
            this.DESTId = DestId;
            this.refLink = Link;
        }

        public object idreader { get; set; }
        public string dcode { get; set; }
        public string dest { get; set; }
        public string locate { get; set; }
        public string descript { get; set; }
        public int HW { get; set; }
        public int FAM { get; set; }
        public int ADV { get; set; }
        public int CRU { get; set; }
        public int WED { get; set; }
        public int SPA { get; set; }
        public int AMUSE { get; set; }
        public int HISTORIC { get; set; }
        public int CAMP { get; set; }
        public int ENTERTAIN { get; set; }
        public int hw { get; set; }
        public int fam { get; set; }
        public int adv { get; set; }
        public int cru { get; set; }
        public int wed { get; set; }
        public int priceLow { get; set; }
        public int priceHigh { get; set; }
        public int DESTId { get; set; }
        public string refLink { get; set; }

        public int CompareTo(object obj)
        {
            Package package = obj as Package;
            if (package == null)
            {
                throw new ArgumentException("Object is not a Travel Package");
            }
            return this.priceLow.CompareTo(package.priceLow);
        }
    }
}

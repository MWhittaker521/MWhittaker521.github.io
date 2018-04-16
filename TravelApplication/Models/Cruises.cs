using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApplication
{
    public class Cruises: IComparable
    {
        public ObservableCollection<Cruises> cruisePackages = new ObservableCollection<Cruises>();

        ObservableCollection<Cruises> GetData()
        {
            using (SqliteConnection db = new SqliteConnection("Filename=PackageData.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                   ("SELECT * FROM Packages WHERE Cruise=1", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    object IdReader = query.GetValue(0);
                    string Code = query.GetString(1);
                    string Destination = query.GetString(2);
                    string Location = query.GetString(3);
                    string Description = query.GetString(4);
                    int Rank = query.GetInt32(8);
                    int Spa = query.GetInt32(10);
                    int Amusement = query.GetInt32(11);
                    int History = query.GetInt32(12);
                    int Camping = query.GetInt32(13);
                    int Entertainment = query.GetInt32(14);
                    int category = query.GetInt32(18);
                    int Lowprice = query.GetInt32(20);
                    int Highprice = query.GetInt32(21);
                    string Link = query.GetString(23);
                    var package = IdReader.ToString() + ", " + Code + ", " + Destination + ", " + Location +
                        ", " + Description + ", " + Rank.ToString() + ", " + Spa.ToString() + ", " + Amusement.ToString() +
                        ", " + History.ToString() + ", " + Camping.ToString() + ", " + Entertainment.ToString() + ", " + category.ToString() +
                        ", " + Lowprice.ToString() + ", " + Highprice.ToString() + ", " + Link;
                    cruisePackages.Add(new Cruises(IdReader, Code, Destination, Location, Description, Rank, Spa, Amusement, History, Camping, Entertainment, category, Lowprice, Highprice, Link));

                }
                db.Close();

            }
            return cruisePackages;
        }

        public Cruises(object IdReader, string Code, string Destination, string Location, string Description,
            int Rank, int Spa, int Amusement, int History, int Camping, int Entertainment, int category,
            int Lowprice, int Highprice, string Link)
        {
            this.idreader = IdReader;
            this.dcode = Code;
            this.dest = Destination;
            this.locate = Location;
            this.descript = Description;
            this.Crank = Rank;
            this.SPA = Spa;
            this.AMUSE = Amusement;
            this.HISTORIC = History;
            this.CAMP = Camping;
            this.ENTERTAIN = Entertainment;
            this.categor = category;
            this.priceLow = Lowprice;
            this.priceHigh = Highprice;
            this.refLink = Link;
        }

        public object idreader { get; set; }
        public string dcode { get; set; }
        public string dest { get; set; }
        public string locate { get; set; }
        public string descript { get; set; }
        public int Crank { get; set; }
        public int SPA { get; set; }
        public int AMUSE { get; set; }
        public int HISTORIC { get; set; }
        public int CAMP { get; set; }
        public int ENTERTAIN { get; set; }
        public int categor { get; set; }
        public int priceLow { get; set; }
        public int priceHigh { get; set; }
        public string refLink { get; set; }

        public int CompareTo(object obj)
        {
            Cruises cruises = obj as Cruises;
            if (cruises == null)
            {
                throw new ArgumentException("Object is not a Cruise Package");
            }
            return this.Crank.CompareTo(cruises.Crank);
        }
    }
}

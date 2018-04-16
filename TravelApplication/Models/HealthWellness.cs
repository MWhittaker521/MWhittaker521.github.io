using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TravelApplication
{
    public class HealthWellness : IComparable, INotifyPropertyChanged
    {
        public ObservableCollection<HealthWellness> wellnessPackages = new ObservableCollection<HealthWellness>();
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public string packageinfo; 

        ObservableCollection<HealthWellness> GetData()
        {

            using (SqliteConnection db = new SqliteConnection("Filename=PackageData.db"))
            {
                db.Open(); 

                     SqliteCommand selectCommand = new SqliteCommand
                        ("SELECT * FROM Packages WHERE HealthWell=1", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    object IdReader = query.GetValue(0);
                    string Code = query.GetString(1);
                    string Destination = query.GetString(2);
                    string Location = query.GetString(3);
                    string Description = query.GetString(4);
                    int Rank = query.GetInt32(5);
                    int Spa = query.GetInt32(10);
                    int Amusement = query.GetInt32(11);
                    int History = query.GetInt32(12);
                    int Camping = query.GetInt32(13);
                    int Entertainment = query.GetInt32(14);
                    int Category = query.GetInt32(15);
                    int Lowprice = query.GetInt32(20);
                    int Highprice = query.GetInt32(21);
                    string Link = query.GetString(23);
                    packageinfo = IdReader.ToString() + ", " + Code + ", " + Destination + ", " + Location +
                        ", " + Description + ", " + Rank.ToString() + ", " + Spa.ToString() + ", " + Amusement.ToString() +
                        ", " + History.ToString() + ", " + Camping.ToString() + ", " + Entertainment.ToString() + ", " + Category.ToString() +
                        ", " + Lowprice.ToString() + ", " + Highprice.ToString() + ", " + Link;
                    wellnessPackages.Add(new HealthWellness(IdReader, Code, Destination, Location, Description, Rank, Spa, Amusement, History, Camping, Entertainment, Category, Lowprice, Highprice, Link)); 
                }
                
                db.Close();
            }
            return wellnessPackages;
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            //Rase the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public HealthWellness(object IdReader, string Code, string Destination, string Location, string Description,
            int Rank, int Spa, int Amusement, int History, int Camping, int Entertainment, int Category,
            int Lowprice, int Highprice, string Link)
        {
            this.idreader = IdReader;
            this.dcode = Code;
            this.dest = Destination;
            this.locate = Location;
            this.descript = Description;
            this.rank = Rank;
            this.SPA = Spa;
            this.AMUSE = Amusement;
            this.HISTORIC = History;
            this.CAMP = Camping;
            this.ENTERTAIN = Entertainment;
            this.cat = Category;
            this.priceLow = Lowprice;
            this.priceHigh = Highprice;
            this.refLink = Link;
        }

        public object idreader
        {
            get
            {
                return this.idreader;
            }
            set
            { this.idreader = value;
                this.OnPropertyChanged(); 
            }
        }
        public string dcode { get; set; }
        public string dest { get; set; }
        public string locate { get; set; }
        public string descript { get; set; }
        public int rank { get; set; }
        public int SPA { get; set; }
        public int AMUSE { get; set; }
        public int HISTORIC { get; set; }
        public int CAMP { get; set; }
        public int ENTERTAIN { get; set; }
        public int cat { get; set; }
        public int priceLow { get; set; }
        public int priceHigh { get; set; }
        public string refLink { get; set; }

        public int CompareTo(object obj)
        {
            HealthWellness hw = obj as HealthWellness;
            if (hw == null)
            {
                throw new ArgumentException("Object is not a Health/Wellness Package");
            }
            return this.rank.CompareTo(hw.rank);
        }
    }
    
}



using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApplication
{
    public class Package
    {
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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TravelApplication.TravelPackages;

namespace TravelApplication
{
    public class TravelPackages : ObservableCollection<TravelPackage>
    {
        public TravelPackages() : base()
        {
            Add(new TravelPackage("OWDW", "Orlando-Walt Disney World", "Orlando, FL", "Best Place on Earth", "NULL", "1", "NULL", "NULL", "2", 599));           
        }

        public class TravelPackage
        {
            private string destCode;
            private string destName;
            private string destLocation;
            private string destDescription;
            private string HWRank;
            private string FAMRank;
            private string ADVRank;
            private string CRURank;
            private string WEDRank;
            private int destPrice; 

            public TravelPackage(string code, string name, string location, string description, string HW, string FAM, string ADV, string CRU, string WED, int price)
            {
                this.destCode = code;
                this.destName = name;
                this.destLocation = location;
                this.destDescription = description;
                this.HWRank = HW;
                this.FAMRank = FAM;
                this.ADVRank = ADV;
                this.CRURank = CRU;
                this.WEDRank = WED;
                this.destPrice = price; 
            }

            public string DestCode
            {
                get { return destCode; }
                set { destCode = value; }
            }
            public string DestName
            {
                get { return destName; }
                set { destName = value; }
            }
            public string DestLocation
            {
                get { return destLocation; }
                set { destLocation = value; }
            }
            public string DestDescription
            {
                get { return destDescription; }
                set { destDescription = value; }
            }
            public string HWrank
            {
                get { return HWRank; }
                set { HWRank = value; }
            }
            public string FAMrank
            {
                get { return FAMRank; }
                set { FAMRank = value; }
            }
            public string ADVrank
            {
                get { return ADVRank; }
                set { ADVRank = value; }
            }
            public string CRUrank
            {
                get { return CRURank; }
                set { CRURank = value; }
            }
            public string WEDrank
            {
                get { return WEDRank; }
                set { WEDRank = value; }
            }

            public int DestPrice
            {
                get { return destPrice; }
                set { destPrice = value; }
            }
        }    
    }
}

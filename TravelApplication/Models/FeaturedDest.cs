using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApplication.Models
{
    public class FeaturedDest : INotifyPropertyChanged
    {
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
        public string imageSource { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

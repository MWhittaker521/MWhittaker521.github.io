using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApplication.Models
{
    public class UserDictionaryItem: INotifyPropertyChanged
    {
        public string first { get; set; }
        public string last { get; set; }
        public string userId { get; set; }
        public string password { get; set; }
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

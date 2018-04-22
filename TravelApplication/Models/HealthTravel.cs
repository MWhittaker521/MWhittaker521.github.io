﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;

namespace TravelApplication.Models
{

    public class HealthTravel : INotifyPropertyChanged
    {
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
        public int destid { get; set; }
        public string refLink { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public int CompareTo(object obj)
        {
            HealthTravel healthPackage = obj as HealthTravel;
            if (healthPackage == null)
            {
                throw new ArgumentException("Object is not a Travel Package");
            }
            return this.rank.CompareTo(healthPackage.rank);
        }
    }
}

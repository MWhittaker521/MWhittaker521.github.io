using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApplication
{
    public class ReadPackages
    {
        
        public ObservableCollection<Package> GetAllPackages()
        {
            return DatabaseHelper.GetData(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hometasks.task1
{
    public class Refrigerator : IHomeAppliance
    {
        public int Power { get; set; }
        public string EnergyRating { get; set; }
        public string Brand { get; set; }
        public string Model { get ; set ; }
    }
}   

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hometasks.task1
{
    public interface IHomeAppliance : IAppliance
    {
        int Power { get; set; }
        string EnergyRating { get; set; }
    }


       
}

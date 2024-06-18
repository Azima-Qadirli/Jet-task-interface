using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hometasks.task3
{
    public class Dog : Animal, IPet
    {
        public string Name { get ; set; }
        public int Age { get; set ; }
        public override void MakeSound()
        {
            Console.WriteLine("Sound of animal");
        }
        
    }

}

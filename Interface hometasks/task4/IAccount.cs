using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hometasks.task4
{
    public interface IAccount
    {
        double Balance { get; set; }
        public void Deposit(double amount);
        public void WithDraw(double amount);
    }
}

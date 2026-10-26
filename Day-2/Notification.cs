using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public abstract class Notification
    {
        public abstract string BuildMessage(string customerName);
        public void Print(string customerName) => Console.WriteLine(BuildMessage(customerName));
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class EmailNotifier : INotifier
    {
        public void Send(string to, string message) => Console.WriteLine($"Email sent to {to} : {message}");
    }
}
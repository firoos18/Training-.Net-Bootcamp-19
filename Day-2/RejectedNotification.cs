using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class RejectedNotification : Notification
    {
        public override string BuildMessage(string customerName) => $"Dear {customerName}, we are unable to approve your application!";
    }
}
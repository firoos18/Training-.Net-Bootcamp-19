using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class ApproveNotification : Notification
    {
        public override string BuildMessage(string customerName) => $"Congratulations {customerName}, your application is approved!";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCreditDay1.Customer
{
    public class Customer
    {
        public int Id { get; set; }                    // int: whole numbers, 4 bytes
        public string Name { get; set; } = string.Empty; // string: Unicode text
        public decimal MonthlyIncome { get; set; }      // decimal: money, 16 bytes
        public DateTime CreatedAt { get; set; }          // DateTime: dates + times
        public bool IsActive { get; set; }

        // public Customer(int id, string name, decimal monthlyIncome, DateTime createdAt, bool isActive)
        // {
        //     Id = id;
        //     Name = name;
        //     MonthlyIncome = monthlyIncome;
        //     CreatedAt = createdAt;
        //     IsActive = isActive;
        // }
    }
}
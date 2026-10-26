using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2.Customer
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        private decimal _monthlyIncome;

        public decimal MonthlyIncome
        {
            get => _monthlyIncome;
            set
            {
                if (value < 0) throw new ArgumentException("Income Cannot be Negative");
                _monthlyIncome = value;
            }
        }

        public string IncomeCategory => MonthlyIncome switch
        {
            > 10_000_000m => "High",
            > 5_000_000m => "Medium",
            > 0 => "Low",
            _ => "None"
        };

        public Customer(int id, string name, decimal income, DateTime createdAt)
        {
            Id = id;
            Name = name;
            MonthlyIncome = income;
            CreatedAt = createdAt;
        }

        public Customer(int id, string name, decimal income) : this(id, name, income, DateTime.Now) { }

        public Customer(int id, string name) : this(id, name, 0) { }

        public decimal GetAnnualIncome()
        {
            return MonthlyIncome * 12;
        }


        public string GetEligibility()
        {
            if (GetAnnualIncome() >= 60_000_000)
            {
                return "Eligible";
            }
            else
            {
                return "Not Eligible";
            }
        }
    }
}



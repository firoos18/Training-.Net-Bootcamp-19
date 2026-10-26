using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class LoanProduct
    {
        public string Name { get; }
        public decimal AnnualRate { get; }

        public LoanProduct(string name, decimal annualRate)
        {
            Name = name;
            AnnualRate = annualRate;
        }

        public virtual decimal CalculateMonthlyPayment(decimal amount, int tenorMonths)
         => (amount + amount * AnnualRate / 12 * tenorMonths) / tenorMonths;

        public string Describe() => $"{Name} ({AnnualRate:P0}) per year";
    }
}
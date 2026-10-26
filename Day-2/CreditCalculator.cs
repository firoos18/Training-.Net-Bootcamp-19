using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class CreditCalculator
    {
        public decimal CalculateMonthly(decimal amount, decimal rate, int months)
        => (amount + (amount * rate / 12 * months)) / months;

        public static decimal CalculateMonthlyStatic(decimal amount, decimal rate, int months)
        => (amount + (amount * rate / 12 * months)) / months;
    }
}
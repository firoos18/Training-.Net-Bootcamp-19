using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class AnnuityLoan : LoanProduct
    {
        public AnnuityLoan(string name, decimal annualRate) : base(name, annualRate) { }

        public override decimal CalculateMonthlyPayment(decimal amount, int tenorMonths)
        {
            decimal r = AnnualRate / 12;
            if (r == 0) return amount / tenorMonths;

            decimal factor = 1;
            for (int i = 0; i < tenorMonths; i++) factor *= 1 + r;

            return amount * r * factor / (factor - 1);
        }
    }
}
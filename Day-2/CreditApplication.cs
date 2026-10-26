using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class CreditApplication
    {
        public int Id { set; get; }
        public decimal Amount { set; get; }
        public decimal InterestRate { set; get; }
        public int TenorMonths { set; get; }
        public string Status { private set; get; }

        public void Submit() { if (Status == "DRAFT") Status = "SUBMITTED"; }
        public void Approve() { if (Status == "SUBMITTED") Status = "APPROVED"; }
        public void Reject() { if (Status != "APPROVED") Status = "REJECTED"; }

        public CreditApplication(int id, decimal amount, int tenorMonths)
        {
            if (amount <= 0) throw new ArgumentException("Loan amount must be positive");
            if (tenorMonths < 1 || tenorMonths > 60) throw new ArgumentException("Tenor must be 1 - 60 months");

            Id = id;
            Amount = amount;
            TenorMonths = tenorMonths;
            Status = "DRAFT";
        }

        public decimal CalculateMonthlyPayment()
        {
            decimal monthlyRate = InterestRate / 12;
            decimal interest = Amount * monthlyRate * TenorMonths;
            return (Amount + interest) / TenorMonths;
        }

        public string GetSummary()
        {
            string statusEmoji = Status switch
            {
                "DRAFT" => "📝",
                "SUBMITTED" => "📤",
                "APPROVED" => "✅",
                "REJECTED" => "❌",
                _ => ""
            };

            return $"{statusEmoji} {Amount,12:N0} | {TenorMonths}m | {CalculateMonthlyPayment(),10:N0}/mo | {Status}";
        }
    }
}
// decimal amount = 50_000_000m;
// decimal rate = 0.12m;
// int tenor = 12;

// decimal monthlyRate = rate / 12;
// decimal totalInterest = amount * rate;
// decimal totalPayment = amount + totalInterest;
// decimal monthlyPayment = totalPayment / tenor;

// Console.WriteLine($"Total Interest: {totalInterest:C}");
// Console.WriteLine($"Total Payment: {totalPayment:C}");
// Console.WriteLine($"Monthly Payment: {monthlyPayment:C}");

// decimal income = 4000000;
// decimal monthlyPayment = 3000000m;
// decimal debtRatio = monthlyPayment / income;

// bool eligible = income >= 3000000m && monthlyPayment <= income * 0.4m;

// string status = income > 5000000m ? "Eligible" : "Not Eligible";

// Console.WriteLine($"Income: {income:C}");
// Console.WriteLine($"Debt Ratio: {debtRatio:P}");
// Console.WriteLine($"Monthly Payment: {monthlyPayment:C}");
// Console.WriteLine($"Is Eligible: {eligible}");
// Console.WriteLine($"Eligibility Status: {status}");

// decimal income = 15_000_000m;

// if (income >= 10_000_000m)
// {
//     Console.WriteLine("Eligible for premium loan");
// }
// else if (income >= 5_000_000m)
// {
//     Console.WriteLine("Eligible for standard loan");
// }
// else
// {
//     Console.WriteLine("Not eligible for loan");
// }

// string status = "APPROVED";

// string label = status switch
// {
//     "APPROVED" => "Congratulations! Your loan has been approved.",
//     "PENDING" => "Your loan application is still under review.",
//     "REJECTED" => "We regret to inform you that your loan application has been rejected.",
//     _ => "Unknown status."
// };

// switch (status)
// {
//     case "APPROVED":
//         Console.WriteLine("Congratulations! Your loan has been approved.");
//         break;
//     case "PENDING":
//         Console.WriteLine("Your loan application is still under review.");
//         break;
//     case "REJECTED":
//         Console.WriteLine("We regret to inform you that your loan application has been rejected.");
//         break;
//     default:
//         Console.WriteLine("Unknown status.");
//         break;
// }

// decimal monthlyPayment = 4_666_666m;
// int tenor = 12;

// for (int month = 1; month <= tenor; month++)
// {
//     Console.WriteLine($"Installment {month,2}: Rp{monthlyPayment:N0}");
// }

// int remaining = 3;

// Console.WriteLine("Using while loop:");
// while (remaining > 0)
// {
//     Console.WriteLine($"Remaining installments: {remaining}");
//     remaining--;
// }

// int remaining2 = 3;

// Console.WriteLine("Using do-while loop:");
// do
// {
//     Console.WriteLine($"Remaining installments: {remaining2}");
//     remaining2--;
// } while (remaining2 > 0);

// decimal amount;
// Console.Write("Enter loan amount: ");

// while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
// {
//     Console.Write("Invalid, Re-enter loan amount: ");
// }

// for (int month = 1; month <= 12; month++)
// {
//     if (month == 6) continue;
//     if (month > 9) break;
//     Console.WriteLine($"Month {month}");
// }

// Latihan (Gunakan input)
// < 30% => (Low)
// 30 - 40% => (Medium)
// > 40% => (High)

// string input = Console.ReadLine();
// decimal debtRatio = decimal.TryParse(input, out decimal result) ? result : 0;
// if (debtRatio < 30)
// {
//     Console.WriteLine("Low");
// }
// else if (debtRatio >= 30 && debtRatio <= 40)
// {
//     Console.WriteLine("Medium");
// }
// else if (debtRatio > 40)
// {
//     Console.WriteLine("High");
// }
// else
// {
//     Console.WriteLine("Invalid input");
// }

// decimal income;
// Console.Write("Enter Your income: ");
// income = decimal.Parse(Console.ReadLine());

// if (income < 30.0m)
// {
//     Console.WriteLine("Low");
// }
// else if (income >= 30.0m && income <= 40.0m)
// {
//     Console.WriteLine("medium");
// }
// else if (income > 40.0m)
// {
//     Console.WriteLine("High");
// }
// else
// {
//     Console.WriteLine("Invalid input");
// }

// decimal income = decimal.Parse(Console.ReadLine());

// if (income >= 40)
// {
//     Console.WriteLine("High.");

// }
// else if (income <= 30)
// {
//     Console.WriteLine("LOW.");
// }
// else
// {
//     Console.WriteLine("MEDIUM.");
// }

// decimal[] income = { 20_000_000m, 30_000_000m, 40_000_000m, 50_000_000m, 60_000_000m };

// Console.WriteLine(income[2]);
// Console.WriteLine(income.Length);

// var incomes = new List<decimal>();

// incomes.Add(20_000_000m);
// incomes.Add(30_000_000m);

// Console.WriteLine($"Incomes count: {incomes.Count}");
// Console.WriteLine($"First income: {incomes[0]:C}");
// Console.WriteLine($"Is Contain 30_000_000? {incomes.Contains(30_000_000m)}");

// incomes.Remove(20_000_000m);
// Console.WriteLine($"is contain 20_000_000? {incomes.Contains(20_000_000m)}");

// var names = new List<string> { "Alice", "Bob", "Charlie" };
// Console.WriteLine($"Names count: {names[0]}");
// names.Add("David");
// Console.WriteLine($"Names count: {names[3]}");

// foreach (string name in names)
// {
//     Console.WriteLine($"Name: {name}");
// }

// static decimal CalculateDebtRatio(decimal monthlyPayment, decimal income)
// {
//     if (income == 0)
//     {
//         throw new ArgumentException("Income cannot be zero.");
//     }
//     return (monthlyPayment / income) * 100;
// }

// decimal monthlyPayment = 3_000_000m;
// decimal income = 10_000_000m;
// decimal debtRatio = CalculateDebtRatio(monthlyPayment, income);
// Console.WriteLine($"Debt Ratio: {debtRatio:F2}%");

// static void PrintInstallmentSchedule(decimal monthlyPayment, int tenor)
// {
//     for (int month = 1; month <= tenor; month++)
//     {
//         Console.WriteLine($"Installment {month,2}: Rp{monthlyPayment:N0}");
//     }
// }

// static bool IsEligibleForLoan(decimal income, decimal monthlyPayment)
// {
//     if (income <= 0)
//     {
//         throw new ArgumentException("Income must be greater than zero.");
//     }
//     return income >= 3_000_000m && monthlyPayment <= income * 0.4m;
// }

// if (IsEligibleForLoan(8_000_000m, 3_000_000m))
// {
//     PrintInstallmentSchedule(3_000_000m, 12);
// }

// static decimal CalculateMonthlyPayment(decimal amount, int tenorMonths, decimal annualRate = 0.12m)
// => (amount + amount * annualRate / 12 * tenorMonths) / tenorMonths;

// Console.WriteLine(CalculateMonthlyPayment(50_000_000m, 12));
// Console.WriteLine(CalculateMonthlyPayment(50_000_000m, tenorMonths: 12, annualRate: 0.5m));

// try
// {
//     int tenor = int.Parse("Twelve");
//     Console.WriteLine($"Tenor: {tenor}");
// }
// catch (FormatException ex)
// {
//     Console.WriteLine($"Error: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Execution completed.");
// }


using EasyCreditDay1.Customer;

var customer1 = new Customer
{
    Id = 1,
    Name = "John Doe",
    MonthlyIncome = 5000000m,
    CreatedAt = DateTime.Now,
    IsActive = true
};

var customers = new List<Customer>();

var customer2 = new Customer();
customer2.Id = 2;
customer2.Name = "Jane Smith";
customer2.MonthlyIncome = 7000000m;

string customer2Name = customer2.Name; // Accessing the Name property of customer2
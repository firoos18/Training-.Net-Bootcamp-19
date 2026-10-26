// using Day_2.Customer;

// var customer = new Customer();
// customer.Id = 1;
// customer.Name = "John Doe";
// customer.MonthlyIncome = 10_000_000m;
// Console.WriteLine($"Customer Name: {customer.Name}, Monthly Income: {customer.MonthlyIncome}\n Annualy : {customer.getAnnualIncome()}, Is elligible : {customer.getEligibility()}");

// var customer2 = new Customer
// {
//     Id = 2,
//     Name = "Jane Doe",
//     MonthlyIncome = 10_000_000m,
//     Email = "",
// };
// Console.WriteLine($"Customer2 Name: {customer2.Name}, Monthly Income: {customer2.MonthlyIncome}, Customer2 Email : {customer.Email}");

// using Day_2;

// var creditApplication = new CreditApplication
// {
//     Id = 1,
//     Amount = 10_000_000m,
//     InterestRate = 0.12m,
//     TenorMonths = 12,
//     Status = "SUBMITTED"
// };
// Console.WriteLine(creditApplication.GetSummary());

// using Day_2;

// var calc = new CreditCalculator();
// decimal m1 = calc.CalculateMonthly(10_000_000m, 0.12m, 12); // instance method

// decimal m2 = CreditCalculator.CalculateMonthlyStatic(10_000_000m, 0.12m, 12); // static method

// using Day_2.Customer;

// var customers = new List<Customer>();
// customers.Add(new Customer { Id = 1, Name = "John Doe", MonthlyIncome = 5_000_000m });
// customers.Add(new Customer { Id = 2, Name = "Jane Doe", MonthlyIncome = 10_000_000m });
// customers.Add(new Customer { Id = 3, Name = "Jack Doe", MonthlyIncome = 15_000_000m });

// foreach (var customer in customers)
// {
//     Console.WriteLine($"Customer Name: {customer.Name}, Monthly Income: {customer.MonthlyIncome}, Customer Email : {customer.Email}");
// }

// Latihan
// a. Tambah method baru "GetAnnualIncome" di class Customer yang mengembalikan 
// nilai Annual Income (MonthlyIncome * 12)
// b. Tambah method baru "GetEligibility" di class Customer yang mengembalikan nilai "Eligible" 
// jika Annual Income >= 60_000_000, dan "Not Eligible" jika Annual Income < 60_000_000

// using Day_2;

// CreditApplication application1 = new CreditApplication(1, 50_000_000m, 12);
// CreditApplication application2 = new CreditApplication(2, -5000, 12);

// using Day_2.Customer;

// Customer cust1 = new Customer(1, "Budi", 8_000_000m, new DateTime(2026, 1, 1));
// Customer cust2 = new Customer(2, "Siti", 12_000_000m);
// Customer cust3 = new Customer(3, "Agus");
// Customer cust4 = new(4, "Alex", -10_000_000m);

// Console.WriteLine($"Cust1 : {cust1.Name}, {cust1.MonthlyIncome}, {cust1.CreatedAt}");
// Console.WriteLine($"Cust2 : {cust2.Name}, {cust2.MonthlyIncome}, {cust2.CreatedAt}");
// Console.WriteLine($"Cust3 : {cust3.Name}, {cust3.MonthlyIncome}, {cust3.CreatedAt}");
// Console.WriteLine($"Cust4 : {cust4.Name}, {cust4.MonthlyIncome}, {cust4.CreatedAt}");

// using Day_2;

// List<LoanProduct> products = new()
// {
//     new LoanProduct("Flat Personal Loan", 0.12m),
//     new AnnuityLoan("Annuity Personal Loan", 0.12m)
// };

// foreach (LoanProduct product in products)
// {
//     decimal monthly = product.CalculateMonthlyPayment(50_000_000m, 12);
//     Console.WriteLine($"{product.Describe()} : Rp{monthly:N0}/month");
// }

using Day_2;

static void NotifyCustomer(INotifier notifier, string to) => notifier.Send(to, "Your loan application was approved!");

NotifyCustomer(new EmailNotifier(), "budi@email.com");
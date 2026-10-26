public class Customer
{
    public int Id { get; set; }                    // int: whole numbers, 4 bytes
    public string Name { get; set; } = string.Empty; // string: Unicode text
    public decimal MonthlyIncome { get; set; }      // decimal: money, 16 bytes
    public DateTime CreatedAt { get; set; }          // DateTime: dates + times
    public bool IsActive { get; set; }               // bool: true/false
}
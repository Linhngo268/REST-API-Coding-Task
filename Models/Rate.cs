namespace LoanRatesApi.Models // Define the namespace for models
{
    public class Rate // Define the Rate model
    {
        public string LoanType { get; set; } = string.Empty; // The type of loan (e.g., owner-occupied)
        public int Term { get; set; } // Loan term in years
        public double InterestRate { get; set; } // Interest rate for the loan
    }
}
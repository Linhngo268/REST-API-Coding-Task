using LoanRatesApi.Models; // Import the models namespace

namespace LoanRatesApi.Services // Define the namespace for services
{
    public class RateService : IRateService // Implement IRateService
    {
        public Rate GetRate(string loanType, int term) // Get rate method implementation
        {
            // Return mock/static data for the requested loan type and term
            return new Rate
            {
                LoanType = loanType, // Set loan type from input
                Term = term, // Set term from input
                InterestRate = 7 // Return a fixed interest rate
            };
        }
    }
}
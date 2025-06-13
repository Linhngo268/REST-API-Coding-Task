using LoanRatesApi.Models; // Import the models namespace

namespace LoanRatesApi.Services // Define the namespace for services
{
    public interface IRateService // Interface for rate service
    {
        Rate GetRate(string loanType, int term); // Method to get rate based on loan type and term
    }
}
A minimal .NET 6 Web API returning mock interest rate data.  
## Endpoint // Endpoint section
`GET /api/rates?loanType=owner-occupied&term=30`  

### Example Response // Example output
```json
{
  "loanType": "owner-occupied",
  "term": 30,
  "interestRate": 7
}
```

## Run Locally // Local development instructions
```bash
dotnet run // Run the application using .NET CLI
```

 
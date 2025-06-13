using LoanRatesApi.Services; // Import the services namespace to access IRateService and RateService

var builder = WebApplication.CreateBuilder(args); // Create a new WebApplication builder
builder.Services.AddControllers(); // Register controller services
builder.Services.AddEndpointsApiExplorer(); // Enable API endpoint explorer (used by Swagger)
builder.Services.AddSwaggerGen(); // Register Swagger generator service
builder.Services.AddScoped<IRateService, RateService>(); // Register IRateService with RateService implementation for dependency injection

var app = builder.Build(); // Build the application

if (app.Environment.IsDevelopment()) // If the environment is Development
{
    app.UseSwagger(); // Enable Swagger middleware
    app.UseSwaggerUI(); // Enable Swagger UI
}

app.UseAuthorization(); // Enable authorization middleware
app.MapControllers(); // Map controller routes
app.Run(); // Run the application
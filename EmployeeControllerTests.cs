using Microsoft.AspNetCore.Authentication; // Ensure this is included
using Microsoft.Extensions.DependencyInjection; // Add this using directive

namespace RPOST.EmployeeApi.Tests.Test
{
    public class EmployeeControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public EmployeeControllerTests(WebApplicationFactory<Program> factory)
        {
            // Step 2b: Customize the API pipeline for testing
            _client = factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    // Replace real authentication with our mock
                    services.AddAuthentication("mock").AddScheme<AuthenticationSchemeOptions, MockJwtAuthHandler>("mock", options => { });
                });
            }).CreateClient();
        }

        [Fact]
        public async Task GetEmployees_ReturnsOk()
        {
            // Add a fake Bearer token
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", "mock-token");

            // Call the API endpoint
            var response = await _client.GetAsync("/api/employees");

            response.EnsureSuccessStatusCode(); // Status 200
        }
    }
}

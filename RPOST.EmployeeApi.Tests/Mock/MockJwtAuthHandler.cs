using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace RPOST.EmployeeApi.Tests.Mock
{
    public class MockJwtAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public MockJwtAuthHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock)
            : base(options, logger, encoder, clock) { }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var claims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier, "1"),
            new Claim(ClaimTypes.Name, "TestUser"),
            new Claim("scope", "employee.read")
        };

            var identity = new ClaimsIdentity(claims, "mock");
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, "mock");

            return Task.FromResult(AuthenticateResult.Success(ticket));
        }
    }

}

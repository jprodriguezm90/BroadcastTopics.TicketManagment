using BroadcastTopics.TicketManagement.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using SendGrid.Helpers.Mail;

namespace BroadcastTopics.TicketManagement.API.IntegrationTests.Base
{
    public class CustomWebApplicationFactory<TProgram>
            : WebApplicationFactory<TProgram> where TProgram : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Remove existing DbContext registrations if any
                var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<BroadcastTopicsDbContext>));
                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }

                // Remove any custom IDbContextOptionsConfiguration registrations that might interfere
                services.RemoveAll(typeof(IDbContextOptionsConfiguration<BroadcastTopicsDbContext>));

                // Use a unique in-memory database name per factory instance to avoid cross-test state
                var inMemoryDbName = "BroadcastTopicsInMemoryTest_" + Guid.NewGuid().ToString();

                services.AddDbContext<BroadcastTopicsDbContext>(options =>
                {
                    options.UseInMemoryDatabase(inMemoryDbName);
                });

                var sp = services.BuildServiceProvider();

                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var context = scopedServices.GetRequiredService<BroadcastTopicsDbContext>();
                    var logger = scopedServices.GetRequiredService<ILogger<CustomWebApplicationFactory<TProgram>>>();

                    // Ensure a clean database for each test run
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();

                    try
                    {
                        Utilities.InitializeDbForTests(context);
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, $"An error occurred seeding the database with test messages. Error: {ex.Message}");
                    }
                }
            });
        }

        public HttpClient GetAnonymousClient()
        {
            return CreateClient();
        }
    }
}

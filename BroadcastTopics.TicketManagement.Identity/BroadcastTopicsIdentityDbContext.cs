using BroadcastTopics.TicketManagement.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BroadcastTopics.TicketManagement.Identity
{
    public class BroadcastTopicsIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public BroadcastTopicsIdentityDbContext()
        {

        }

        public BroadcastTopicsIdentityDbContext(DbContextOptions<BroadcastTopicsIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
        .LogTo(Console.WriteLine)
        .EnableSensitiveDataLogging();

    }
}

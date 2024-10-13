using ManagementTicketsAZ.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ManagementTicketsAZ.Data
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
    
    
}

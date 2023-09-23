using TicketManagement.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TicketManagement.Identity
{
    public class TicketManagementIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public TicketManagementIdentityDbContext()
        {

        }

        public TicketManagementIdentityDbContext(DbContextOptions<TicketManagementIdentityDbContext> options) : base(options)
        {
        }
    }
}


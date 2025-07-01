using dotnet_blazer_CRUD_app.Components.Domain;
using Microsoft.EntityFrameworkCore;

namespace dotnet_blazer_CRUD_app.Components.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}

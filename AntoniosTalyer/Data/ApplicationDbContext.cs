using AntoniosTalyer.Models;
using Microsoft.EntityFrameworkCore;

namespace AntoniosTalyer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Issue> Issues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Issue>()
                .HasOne(issue => issue.Customer)
                .WithMany(customer => customer.Issues)
                .HasForeignKey(issue => issue.CustomerId)
                .IsRequired();
        }
    }
}

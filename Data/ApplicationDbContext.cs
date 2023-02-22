using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Asm_1670Final.Models;

namespace Asm_1670Final.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Asm_1670Final.Models.Book> Book { get; set; }
        public DbSet<Asm_1670Final.Models.Category> Category { get; set; }
        public DbSet<Asm_1670Final.Models.Order> Order { get; set; }
        public DbSet<Asm_1670Final.Models.User> User { get; set; }
    }
}
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data {
    public class ToDoListDbContext : DbContext {
        protected readonly IConfiguration _configuration;

        public ToDoListDbContext(IConfiguration configuration) {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DbConnectionString"));
        }

        public DbSet<ToDoListItem> ToDoListItems { get; set; }
    }
}

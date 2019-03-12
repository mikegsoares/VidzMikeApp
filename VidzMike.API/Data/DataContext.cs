using Microsoft.EntityFrameworkCore;
using VidzMike.API.Models;

namespace VidzMike.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
                                                    : base(options) { }

        public DbSet<Value> Values { get; set; }
    }
}
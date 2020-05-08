using FoodApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
    
    public DbSet<Value> Values { get; set;}
    }
}
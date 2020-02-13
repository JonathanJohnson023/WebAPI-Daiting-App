using DaitingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DaitingApp.API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options){}
    
    public DbSet<Value> values { get; set; }
  }
}
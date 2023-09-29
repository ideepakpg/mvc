using System.Data.Entity;

namespace mvc.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Emp> Employees
        { get; set; }
    }
}
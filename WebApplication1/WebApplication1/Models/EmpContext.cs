using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
  public class EmpContext : DbContext
    {
      public EmpContext(DbContextOptions options) : base(options) { }
      DbSet<Employees> Employees
      {
        get;
        set;
      }  }
}

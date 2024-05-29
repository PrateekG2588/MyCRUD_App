using Microsoft.EntityFrameworkCore;
using MyCRUD_App.Models.DBEntities;
using System.Data;

namespace MyCRUD_App.DAL
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

using EMSPro.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMSPro
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
       : base(options) { }


        public DbSet<LeaveTypes> LeaveTypes { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<LeaveRequests> LeaveRequests { get; set; }
        public DbSet<LeaveAllocations> LeaveAllocations { get; set; }
    }
}

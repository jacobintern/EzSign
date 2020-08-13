using Microsoft.EntityFrameworkCore;

namespace EzSign.Models
{
    public class EzSignDBContext : DbContext
    {
        public EzSignDBContext(DbContextOptions<EzSignDBContext> options) : base(options)
        {
        }

        public DbSet<ez_emp> ez_emp { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using Pharmaceuticals.Models;

namespace Pharmaceuticals.DbContextClass
{
    public class PharmaDbContextClass : DbContext
    {
        public PharmaDbContextClass(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Capsules> tbl_Capsules { get; set; }
        public DbSet<Tablets> Tablets { get; set; }
        public DbSet<LiquidFillings> LiquidFillings { get; set; }
        public DbSet<Admins> tbl_Admins { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
using UnitOfWork.EFModels;

namespace UnitOfWork.Context
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
        }
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
    }
}

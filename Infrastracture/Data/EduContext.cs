using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastracture.Data
{
    public class EduContext : DbContext
    {
        public EduContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Subject> Subjects {get; set;}
    }
}
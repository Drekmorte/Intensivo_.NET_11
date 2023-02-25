using IntensivoCSharp.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace IntensivoCSharp.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {

        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
    }
}

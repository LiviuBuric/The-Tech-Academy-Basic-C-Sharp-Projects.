using System.Data.Entity;

namespace StudentDatabaseApp.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
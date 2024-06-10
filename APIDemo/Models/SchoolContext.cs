using Microsoft.EntityFrameworkCore;

namespace APIDemo.Models
{
    public class SchoolContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                "Initial Catalog=SchoolAPIDB; Integrated Security=True;trustservercertificate=True");
        }
    }
}

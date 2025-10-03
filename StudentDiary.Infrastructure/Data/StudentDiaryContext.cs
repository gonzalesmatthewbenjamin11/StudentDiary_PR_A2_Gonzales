using Microsoft.EntityFrameworkCore;
using StudentDiary.Infrastructure.Entities;

namespace StudentDiary.Infrastructure.Data
{
    public class StudentDiaryContext : DbContext
    {
        public StudentDiaryContext(DbContextOptions<StudentDiaryContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }
    }
}

using be_dozun_tasks.Models;
using Microsoft.EntityFrameworkCore;

namespace be_dozun_tasks.Seeders
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>().HasData(
                new Tasks() { Id = 1, Name = "Task 1", isComplete = false },
                new Tasks() { Id = 2, Name = "Task 2", isComplete = false }
            );
        }
    }
}

using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Infrastructure.Persistence
{
    public static class AppDbContextSeed
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            if (!context.Students.Any())
            {
                context.Students.Add(new Student
                {
                    Name = "Fahmin",
                    Surname = "Gurbanli",
                    Class = 11,
                    StudentNumber = 12346
                });

                await context.SaveChangesAsync();
            }
        }
    }
}

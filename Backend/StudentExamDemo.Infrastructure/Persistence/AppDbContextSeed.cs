using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Infrastructure.Persistence
{
    public static class AppDbContextSeed
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            // Check if there are any students or subjects in the database
            // If not, add some initial data for testing purposes
            if (!context.Students.Any() && !context.Subjects.Any())
            {
                context.Subjects.Add(new Subject
                {
                    Name = "Mathematics",
                    Class = 11,
                    Code = "MAT",
                    TeacherName = "Əli",
                    TeacherSurname = "Məmmədli"
                });

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

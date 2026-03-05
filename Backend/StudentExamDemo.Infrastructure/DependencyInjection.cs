using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentExamDemo.Application.Services;
using StudentExamDemo.Domain.Interfaces;
using StudentExamDemo.Domain.Repositories;
using StudentExamDemo.Infrastructure.Persistence;
using StudentExamDemo.Infrastructure.Repositories;

namespace StudentExamDemo.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration
            )
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("StudentExamConnection"))
            );

            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ISubjectService, SubjectService>();
            
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentService, StudentService>();
            
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IExamService, ExamService>();
            return services;
        }
    }
}

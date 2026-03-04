using AutoMapper;
using StudentExamDemo.Application.DTOs;
using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Application.Mappers
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentCreateDTO, Student>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Exams, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}

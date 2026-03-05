using AutoMapper;
using StudentExamDemo.Application.DTOs;
using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Application.Mappers
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentDTO, Student>()
                .ForMember(dest => dest.Exams, opt => opt.Ignore())
                .ReverseMap();
            
            CreateMap<StudentCreateDTO, Student>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Exams, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}

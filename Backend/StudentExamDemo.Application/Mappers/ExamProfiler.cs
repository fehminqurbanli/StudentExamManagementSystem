using AutoMapper;
using StudentExamDemo.Application.DTOs;
using StudentExamDemo.Domain.Entities;

namespace StudentExamDemo.Application.Mappers
{
    public class ExamProfile : Profile
    {
        public ExamProfile()
        {
            CreateMap<ExamDTO, Exam>()
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.Subject, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ExamCreateDTO, Exam>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Student, opt => opt.Ignore())
                .ForMember(dest => dest.Subject, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}

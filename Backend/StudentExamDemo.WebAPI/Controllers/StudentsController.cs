using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentExamDemo.Application.DTOs;
using StudentExamDemo.Domain.Entities;
using StudentExamDemo.Domain.Interfaces;

namespace StudentExamDemo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _service;
        private readonly IMapper _mapper;

        public StudentsController(IStudentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _service.GetAllAsync();
            var mappedStudents = _mapper.Map<IEnumerable<StudentDTO>>(students);

            return Ok(mappedStudents);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var student = await _service.GetByIdAsync(id);
            if (student == null) return NotFound();

            var mappedStudent = _mapper.Map<StudentDTO>(student);
            return Ok(mappedStudent);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentCreateDTO dto)
        {
            var student = _mapper.Map<Student>(dto);
            await _service.AddAsync(student);
            return CreatedAtAction(nameof(Get), new { id = student.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, StudentCreateDTO dto)
        {
            var student = _mapper.Map<Student>(dto);
            student.Id = id;
            await _service.UpdateAsync(student);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}

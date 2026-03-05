using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentExamDemo.Application.DTOs;
using StudentExamDemo.Domain.Entities;
using StudentExamDemo.Domain.Interfaces;

namespace StudentExamDemo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IExamService _service;
        private readonly IMapper _mapper;

        public ExamsController(IExamService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var exams = await _service.GetAllAsync();
            var mappedExams = _mapper.Map<IEnumerable<ExamDTO>>(exams);

            return Ok(mappedExams);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var exam = await _service.GetByIdAsync(id);
            if (exam == null) return NotFound();

            var mappedExam = _mapper.Map<ExamDTO>(exam);
            return Ok(mappedExam);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExamCreateDTO dto)
        {
            var exam = _mapper.Map<Exam>(dto);
            await _service.AddAsync(exam);
            return CreatedAtAction(nameof(Get), new { id = exam.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ExamCreateDTO dto)
        {
            var exam = _mapper.Map<Exam>(dto);
            exam.Id = id;
            await _service.UpdateAsync(exam);
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

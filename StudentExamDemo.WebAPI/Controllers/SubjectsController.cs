using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentExamDemo.Application.DTOs;
using StudentExamDemo.Domain.Entities;
using StudentExamDemo.Domain.Interfaces;

namespace StudentExamDemo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectService _service;
        private readonly IMapper _mapper;

        public SubjectsController(ISubjectService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var subject = await _service.GetByIdAsync(id);
            if (subject == null) return NotFound();
            return Ok(subject);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SubjectCreateDTO dto)
        {
            var subject = _mapper.Map<Subject>(dto);
            await _service.AddAsync(subject);
            return CreatedAtAction(nameof(Get), new { id = subject.Id }, subject);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Subject subject)
        {
            if (id != subject.Id) return BadRequest();
            await _service.UpdateAsync(subject);
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

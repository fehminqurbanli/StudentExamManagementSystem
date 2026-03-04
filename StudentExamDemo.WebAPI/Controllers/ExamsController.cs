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

        public ExamsController(IExamService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var exam = await _service.GetByIdAsync(id);
            if (exam == null) return NotFound();
            return Ok(exam);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Exam exam)
        {
            await _service.AddAsync(exam);
            return CreatedAtAction(nameof(Get), new { id = exam.Id }, exam);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Exam exam)
        {
            if (id != exam.Id) return BadRequest();
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

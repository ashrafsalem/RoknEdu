using Infrastracture.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectController : ControllerBase
    {
        public EduContext Context {get;}
        public SubjectController(EduContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Subject>>> GetSubjects()
        {
            var subjects = await Context.Subjects.ToListAsync();
            return Ok(subjects);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Subject>> GetSubject(int Id)
        {
            return await Context.Subjects.FindAsync(Id);
        }
    }
}
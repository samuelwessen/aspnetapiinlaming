using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Entities;
using SharedLibrary.Models;
using WepApi.Data;
using WepApi.Services;

namespace WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ErrandIssuesController : ControllerBase
    {
        private readonly SqlDbContext _context;
        private readonly IIdentityService _identity;

        public ErrandIssuesController(SqlDbContext context, IIdentityService identity)
        {
            _context = context;
            _identity = identity;
        }



        [HttpPost("create")]
        public async Task<IActionResult> CreateErrand([FromBody] CreateErrandIssueViewModel model)
        {
            if (await _identity.CreateErrandAsync(model))
                return new OkResult();

            return new BadRequestResult();
        }





        // GET: api/ErrandIssues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ErrandIssue>>> GetErrandIssues()
        {
            return await _context.ErrandIssues.ToListAsync();
        }





        // GET: api/ErrandIssues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ErrandIssue>> GetErrandIssue(int id)
        {
            var errandIssue = await _context.ErrandIssues.FindAsync(id);

            if (errandIssue == null)
            {
                return NotFound();
            }

            return errandIssue;
        }




        // PUT: api/ErrandIssues/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutErrandIssue(int id, ErrandIssue errandIssue)
        {
            if (id != errandIssue.Id)
            {
                return BadRequest();
            }

            _context.Entry(errandIssue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ErrandIssueExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }




        // POST: api/ErrandIssues
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ErrandIssue>> PostErrandIssue(ErrandIssue errandIssue)
        {
            _context.ErrandIssues.Add(errandIssue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetErrandIssue", new { id = errandIssue.Id }, errandIssue);
        }




        // DELETE: api/ErrandIssues/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteErrandIssue(int id)
        {
            var errandIssue = await _context.ErrandIssues.FindAsync(id);
            if (errandIssue == null)
            {
                return NotFound();
            }

            _context.ErrandIssues.Remove(errandIssue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ErrandIssueExists(int id)
        {
            return _context.ErrandIssues.Any(e => e.Id == id);
        }
    }
}

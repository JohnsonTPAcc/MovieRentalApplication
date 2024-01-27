using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieRentalApplication.Server.Data;
using MovieRentalApplication.Server.IRepository;
using MovieRentalApplication.Shared.Domain;

namespace MovieRentalApplication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public DirectorsController(ApplicationDbContext context)
        public DirectorsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Directors
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Director>>> GetDirectors()
        public async Task<IActionResult> GetDirectors()
        {
            var directors = await _unitOfWork.Directors.GetAll();
            return Ok(directors);
        }

        // GET: api/Directors/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Director>> GetDirector(int id)
        public async Task<IActionResult> GetDirector(int id)
        {
          var director = await _unitOfWork.Directors.Get(q => q.Id == id);

            if (director == null)
            {
                return NotFound();
            }
            return Ok(director);
        }

        // PUT: api/Directors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDirector(int id, Director director)
        {
            if (id != director.Id)
            {
                return BadRequest();
            }

            //_context.Entry(director).State = EntityState.Modified;
            _unitOfWork.Directors.Update(director);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!DirectorExists(id))
                if (!await DirectorExists(id))
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

        // POST: api/Directors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Director>> PostDirector(Director director)
        {
            await _unitOfWork.Directors.Insert(director);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetDirector", new { id = director.Id }, director);
        }

        // DELETE: api/Directors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDirector(int id)
        {
            
            //var director = await _context.Directors.FindAsync(id);
            var director = await _unitOfWork.Directors.Get(q => q.Id == id);
            if (director == null)
            {
                return NotFound();
            }

            //_context.Directors.Remove(director);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Directors.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool DirectorExists(int id)
        private async Task<bool> DirectorExists(int id)
        {
            //return (_context.Directors?.Any(e => e.Id == id)).GetValueOrDefault();
            var make = await _unitOfWork.Directors.Get(q => q.Id == id);
            return make != null;
        }
    }
}

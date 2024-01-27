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
    public class MoviesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public MoviesController(ApplicationDbContext context)
        public MoviesController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Movies
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        public async Task<IActionResult> GetMovies()
        {
            var Movies = await _unitOfWork.Movies.GetAll(includes: q => q.Include(x => x.Director).Include(x => x.Category).Include(x => x.Rating));
            return Ok(Movies);
        }

        // GET: api/Movies/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Movie>> GetMovie(int id)
        public async Task<IActionResult> GetMovie(int id)
        {
            var Movie = await _unitOfWork.Movies.Get(q => q.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Ok(Movie);
        }

        // PUT: api/Movies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, Movie Movie)
        {
            if (id != Movie.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Movie).State = EntityState.Modified;
            _unitOfWork.Movies.Update(Movie);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MovieExists(id))
                if (!await MovieExists(id))
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

        // POST: api/Movies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie Movie)
        {
            await _unitOfWork.Movies.Insert(Movie);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMovie", new { id = Movie.Id }, Movie);
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {

            //var Movie = await _context.Movies.FindAsync(id);
            var Movie = await _unitOfWork.Movies.Get(q => q.Id == id);
            if (Movie == null)
            {
                return NotFound();
            }

            //_context.Movies.Remove(Movie);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Movies.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool MovieExists(int id)
        private async Task<bool> MovieExists(int id)
        {
            //return (_context.Movies?.Any(e => e.Id == id)).GetValueOrDefault();
            var make = await _unitOfWork.Movies.Get(q => q.Id == id);
            return make != null;
        }
    }
}

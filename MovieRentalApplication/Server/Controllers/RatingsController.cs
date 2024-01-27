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
    public class RatingsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public RatingsController(ApplicationDbContext context)
        public RatingsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Ratings
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Rating>>> GetRatings()
        public async Task<IActionResult> GetRatings()
        {
            var Ratings = await _unitOfWork.Ratings.GetAll();
            return Ok(Ratings);
        }

        // GET: api/Ratings/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Rating>> GetRating(int id)
        public async Task<IActionResult> GetRating(int id)
        {
            var Rating = await _unitOfWork.Ratings.Get(q => q.Id == id);

            if (Rating == null)
            {
                return NotFound();
            }
            return Ok(Rating);
        }

        // PUT: api/Ratings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRating(int id, Rating Rating)
        {
            if (id != Rating.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Rating).State = EntityState.Modified;
            _unitOfWork.Ratings.Update(Rating);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!RatingExists(id))
                if (!await RatingExists(id))
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

        // POST: api/Ratings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rating>> PostRating(Rating Rating)
        {
            await _unitOfWork.Ratings.Insert(Rating);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRating", new { id = Rating.Id }, Rating);
        }

        // DELETE: api/Ratings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRating(int id)
        {

            //var Rating = await _context.Ratings.FindAsync(id);
            var Rating = await _unitOfWork.Ratings.Get(q => q.Id == id);
            if (Rating == null)
            {
                return NotFound();
            }

            //_context.Ratings.Remove(Rating);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Ratings.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool RatingExists(int id)
        private async Task<bool> RatingExists(int id)
        {
            //return (_context.Ratings?.Any(e => e.Id == id)).GetValueOrDefault();
            var make = await _unitOfWork.Ratings.Get(q => q.Id == id);
            return make != null;
        }
    }
}

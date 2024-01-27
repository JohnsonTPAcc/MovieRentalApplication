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
    public class CategoriesController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public CategoriesController(ApplicationDbContext context)
        public CategoriesController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Categories
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        public async Task<IActionResult> GetCategories()
        {
            var Categories = await _unitOfWork.Categories.GetAll();
            return Ok(Categories);
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Category>> GetCategory(int id)
        public async Task<IActionResult> GetCategory(int id)
        {
            var Category = await _unitOfWork.Categories.Get(q => q.Id == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Ok(Category);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category Category)
        {
            if (id != Category.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Category).State = EntityState.Modified;
            _unitOfWork.Categories.Update(Category);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!CategoryExists(id))
                if (!await CategoryExists(id))
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

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category Category)
        {
            await _unitOfWork.Categories.Insert(Category);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCategory", new { id = Category.Id }, Category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {

            //var Category = await _context.Categories.FindAsync(id);
            var Category = await _unitOfWork.Categories.Get(q => q.Id == id);
            if (Category == null)
            {
                return NotFound();
            }

            //_context.Categories.Remove(Category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Categories.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool CategoryExists(int id)
        private async Task<bool> CategoryExists(int id)
        {
            //return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
            var make = await _unitOfWork.Categories.Get(q => q.Id == id);
            return make != null;
        }
    }
}

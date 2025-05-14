using lab_9.Data;
using lab_9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lab_9.Controllers
{
    public class AnimalsController : ControllerBase
    {
        private readonly PetShopDbContext _context;

        public AnimalsController(PetShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Animal>>> GetAnimals()
            => await _context.Animals.Include(a => a.Species).ToListAsync();

        [HttpPost]
        public async Task<ActionResult<Animal>> AddAnimal(Animal animal)
        {
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAnimals), new { id = animal.Id }, animal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAnimal(int id, Animal animal)
        {
            if (id != animal.Id) return BadRequest();
            _context.Entry(animal).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null) return NotFound();
            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System.Linq;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;
    
    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task <ActionResult<PaginationModel>> Get(string name, string type, string species, string gender, string size, int page, int perPage)
    {
      var query = _db.Animals.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      if (size != null)
      {
        query = query.Where(entry => entry.Size == size);
      }

      List<Animal> animals = await query.ToListAsync();

      if(perPage == 0) perPage = 3;

      int total = animals.Count;
      List<Animal> animalPage = new List<Animal>();

      if(page < (total / perPage ))
      {
        animalPage = animals.GetRange(page * perPage, perPage);
      }

      if(page == (total/perPage))
      {
        animalPage = animals.GetRange(page * perPage, total - (page * perPage));
      }

      return new PaginationModel()
      {
        Data = animalPage,
        Total = total,
        PerPage = perPage,
        Page = page,
        PreviousPage = page == 0 ? "No previous page" : $"/api/animals?page={page -1}&perPage={perPage}",
        NextPage = page == total/perPage ? "No next page" : $"/api/animals?page={page + 1}&perPages={perPage}"
      };
    }

    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);

      if(animal == null)
      {
        return NotFound();
      }

      return animal;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Putl(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
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

    [HttpDelete("{id{")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }
  }
}
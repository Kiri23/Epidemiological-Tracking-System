using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Individual
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public List<string> Symptoms { get; set; } = new List<string>();
        public bool Diagnosed { get; set; }
        public DateTime DateDiagnosed { get; set; }


    }
}

/**
[ApiController]
[Route("api/[controller]")]
public class IndividualsController : ControllerBase
{
    private readonly EpidemiologyContext _context;
    public IndividualsController(EpidemiologyContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Model>>> GetIndividuals()
    {
        return await _context.Individuals.Where(i => i.Diagnosed).ToListAsync();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Model>> GetIndividual(int id)
    {
        var individual = await _context.Individuals.FindAsync(id);
        if (individual == null)
        {
            return NotFound();
        }
        return individual;
    }
    [HttpPost]
    public async Task<ActionResult<Model>> PostIndividual(Model model)
    {
        _context.Individuals.Add(model);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetIndividual), new { id = model.Id }, model);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> PutIndividual(int id, Model model)
    {
        if (id != model.Id)
        {
            return BadRequest();
        }
        _context.Entry(model).State = EntityState.Modified;
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Individuals.Any(e => e.Id == id))
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
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteIndividual(int id)
    {
        var individual = await _context.Individuals.FindAsync(id);
        if (individual == null)
        {
            return NotFound();
        }
        _context.Individuals.Remove(individual);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}


*/
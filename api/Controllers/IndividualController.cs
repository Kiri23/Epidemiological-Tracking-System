using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Models;
using api.Data;

namespace api.Controllers
{
    [Route("api/individual")]
    [ApiController]
    public class IndividualController : ControllerBase
    {
        private readonly EpidemiologyDBContext _context;
        public IndividualController(EpidemiologyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Individual>>> GetIndividuals()
        {
            return await _context.Individuals.Where(i => i.Diagnosed).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Individual>> GetIndividual(int id)
        {
            var individual = await _context.Individuals.FindAsync(id);
            if (individual == null)
            {
                return NotFound();
            }
            return individual;
        }

        [HttpPost]
        public async Task<ActionResult<Individual>> PostIndividual(Individual individual)
        {
            _context.Individuals.Add(individual);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetIndividual), new { id = individual.Id }, individual);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutIndividual(int id, Individual individual)
        {
            if (id != individual.Id)
            {
                return BadRequest("The ID in the URL does not match the ID in the request body.");
            }
            _context.Entry(individual).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Reload the entity to see if it still exists
                var existingIndividual = await _context.Individuals.FindAsync(id);
                if (existingIndividual == null)
                {
                    return NotFound($"An individual with ID {id} no longer exists.");
                }
                else
                {
                    // Entity exists but has been modified by another process
                    return Conflict("The individual has been modified by another process.");
                }

            }
            // For simplicity we are returning non content but the individual that got updated could be sent too.
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
}
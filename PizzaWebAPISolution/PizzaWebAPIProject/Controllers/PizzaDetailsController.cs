using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaWebAPIProject.Models;

namespace PizzaWebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaDetailsController : ControllerBase
    {
        private readonly PizzaContext _context;

        public PizzaDetailsController(PizzaContext context)
        {
            _context = context;
        }

        // GET: api/PizzaDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PizzaDetail>>> GetPizzaDetails()
        {
            return await _context.PizzaDetails.ToListAsync();
        }

        // GET: api/PizzaDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaDetail>> GetPizzaNameByPizzaId(int id)
        {
            var pizzaDetail = await _context.PizzaDetails.FindAsync(id);

            if (pizzaDetail == null)
            {
                return NotFound();
            }

            return pizzaDetail;
        }

        // PUT: api/PizzaDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPizzaDetail(int id, PizzaDetail pizzaDetail)
        {
            if (id != pizzaDetail.PizzaId)
            {
                return BadRequest();
            }

            _context.Entry(pizzaDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaDetailExists(id))
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

        // POST: api/PizzaDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PizzaDetail>> PostPizzaDetail(PizzaDetail pizzaDetail)
        {
            _context.PizzaDetails.Add(pizzaDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPizzaDetail", new { id = pizzaDetail.PizzaId }, pizzaDetail);
        }

        // DELETE: api/PizzaDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePizzaDetail(int id)
        {
            var pizzaDetail = await _context.PizzaDetails.FindAsync(id);
            if (pizzaDetail == null)
            {
                return NotFound();
            }

            _context.PizzaDetails.Remove(pizzaDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PizzaDetailExists(int id)
        {
            return _context.PizzaDetails.Any(e => e.PizzaId == id);
        }
    }
}

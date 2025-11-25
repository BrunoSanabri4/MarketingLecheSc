using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Marketing_Sc.Data;
using Marketing_Sc.Entidades;

namespace Marketing_Sc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaniaController : ControllerBase
    {
        private readonly Marketing_ScContext _context;

        public CampaniaController(Marketing_ScContext context)
        {
            _context = context;
        }

        // GET: api/Campania
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Campania>>> GetCampania()
        {
            return await _context.Campania.ToListAsync();
        }

        // GET: api/Campania/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Campania>> GetCampania(int id)
        {
            var campania = await _context.Campania.FindAsync(id);

            if (campania == null)
            {
                return NotFound();
            }

            return campania;
        }

        // PUT: api/Campania/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampania(int id, Campania campania)
        {
            if (id != campania.Id)
            {
                return BadRequest();
            }

            _context.Entry(campania).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaniaExists(id))
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

        // POST: api/Campania
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Campania>> PostCampania(Campania campania)
        {
            _context.Campania.Add(campania);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCampania", new { id = campania.Id }, campania);
        }

        // DELETE: api/Campania/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCampania(int id)
        {
            var campania = await _context.Campania.FindAsync(id);
            if (campania == null)
            {
                return NotFound();
            }

            _context.Campania.Remove(campania);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CampaniaExists(int id)
        {
            return _context.Campania.Any(e => e.Id == id);
        }
    }
}

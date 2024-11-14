using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiBravo.Models;

namespace WEBAPI_Bravo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BtnNomorRekeningsController : ControllerBase
    {
        private readonly BravoContext _context;

        public BtnNomorRekeningsController(BravoContext context)
        {
            _context = context;
        }

       
       
        [HttpGet("ProfileCustomerByCustomerId")]
        public async Task<ActionResult<BtnNomorRekening>> GetBtnNomorRekening(string customerId)
        {
            var btnNomorRekening = await _context.BtnNomorRekenings.Where( x => x.CustomerId == customerId).ToListAsync();

            if (btnNomorRekening == null)
            {
                return StatusCode(400, NotFound());
            }
            return StatusCode(201, btnNomorRekening);
            
        }

        // GET: api/BtnNomorRekenings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BtnNomorRekening>> GetBtnNomorRekening(int id)
        {
            var btnNomorRekening = await _context.BtnNomorRekenings.FindAsync(id);

            if (btnNomorRekening == null)
            {
                return NotFound();
            }

            return btnNomorRekening;
        }

        // PUT: api/BtnNomorRekenings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBtnNomorRekening(int id, BtnNomorRekening btnNomorRekening)
        {
            if (id != btnNomorRekening.Id)
            {
                return BadRequest();
            }

            _context.Entry(btnNomorRekening).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BtnNomorRekeningExists(id))
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

        // POST: api/BtnNomorRekenings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BtnNomorRekening>> PostBtnNomorRekening(BtnNomorRekening btnNomorRekening)
        {
            _context.BtnNomorRekenings.Add(btnNomorRekening);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBtnNomorRekening", new { id = btnNomorRekening.Id }, btnNomorRekening);
        }

        // DELETE: api/BtnNomorRekenings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBtnNomorRekening(int id)
        {
            var btnNomorRekening = await _context.BtnNomorRekenings.FindAsync(id);
            if (btnNomorRekening == null)
            {
                return NotFound();
            }

            _context.BtnNomorRekenings.Remove(btnNomorRekening);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BtnNomorRekeningExists(int id)
        {
            return _context.BtnNomorRekenings.Any(e => e.Id == id);
        }
    }
}

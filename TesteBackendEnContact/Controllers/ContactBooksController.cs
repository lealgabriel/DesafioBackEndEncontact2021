using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteBackEndEnContact.Database;
using TesteBackendEnContact.Core.Domain.ContactBook;

namespace TesteBackendEnContact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactBooksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactBooksController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ContactBooks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactBook>>> GetContactBooks()
        {
            return await _context.ContactBooks.ToListAsync();
        }

        // GET: api/ContactBooks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactBook>> GetContactBook(int id)
        {
            var contactBook = await _context.ContactBooks.FindAsync(id);

            if (contactBook == null)
            {
                return NotFound();
            }

            return contactBook;
        }

        // PUT: api/ContactBooks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactBook(int id, ContactBook contactBook)
        {
            if (id != contactBook.Id)
            {
                return BadRequest();
            }

            _context.Entry(contactBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactBookExists(id))
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

        // POST: api/ContactBooks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContactBook>> PostContactBook(ContactBook contactBook)
        {
            _context.ContactBooks.Add(contactBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactBook", new { id = contactBook.Id }, contactBook);
        }

        // DELETE: api/ContactBooks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactBook(int id)
        {
            var contactBook = await _context.ContactBooks.FindAsync(id);
            if (contactBook == null)
            {
                return NotFound();
            }

            _context.ContactBooks.Remove(contactBook);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactBookExists(int id)
        {
            return _context.ContactBooks.Any(e => e.Id == id);
        }
    }
}

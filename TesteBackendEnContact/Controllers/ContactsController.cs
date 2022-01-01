using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteBackEndEnContact.Database;
using TesteBackendEnContact.Core.Domain.ContactBook;
//using CsvHelper;
using LINQtoCSV;

namespace TesteBackendEnContact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("ListarTodos/page/{page:int}/line/{line:int}")]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts(
            [FromServices] AppDbContext context,
            int page,
            int line)
        {
            if (page <= 0)
            {
                return BadRequest("Page must be greater than 0");
            }

            var contacts = await context
                .Contacts
                .AsNoTracking()
                .Skip((page - 1) * line)
                .Take(line)
                .ToListAsync();

            var total = context.Contacts.Count();
            var pageShown = contacts.Count();

            return Ok(new
            {
                TotalFound = total,
                Shown = pageShown,
                contacts
            });
        }

        [HttpGet("SearchNameCompany/{nameCompany}/page/{page:int}/line/{line:int}")]
        public async Task<ActionResult<Contact>> GetContactForNameCompany(
            [FromServices] AppDbContext context,
            string nameCompany,
            int page,
            int line)

        {
            var searchNameCompany = from p
                                    in _context.Companies
                                    where p.Name == nameCompany
                                    select p.Id;

            var searchNameCompany1 = from p
                                    in _context.Contacts
                                     where p.CompanyId.Equals(searchNameCompany.First())
                                     select p;

            var contacts = await searchNameCompany1
                .Skip(page)
                .Take(line)
                .ToListAsync();

            var total = searchNameCompany1.Count();
            var pageShown = contacts.Count();

            return Ok(new
            {
                TotalFound = total,
                Shown = pageShown,
                contacts
            });
        }

        [HttpGet("SearchContactBookId/{contactBookId:int}/page/{page:int}/line/{line:int}")]
        public async Task<ActionResult<Contact>> GetContactForContactBookId(
            [FromServices] AppDbContext context,
            int contactBookId,
            int page,
            int line)

        {
            var searchContactBookId = from p
                               in _context.Contacts
                                      where p.ContactBookId.Equals(contactBookId)
                                      select p;

            var contacts = await searchContactBookId
                .Skip(page)
                .Take(line)
                .ToListAsync();

            var total = searchContactBookId.Count();
            var pageShown = contacts.Count();

            return Ok(new
            {
                TotalFound = total,
                Shown = pageShown,
                contacts
            });
        }


        [HttpGet("SearchId/{contactId:int}/page/{page:int}/line/{line:int}")]
        public async Task<ActionResult<Contact>> GetContactForId(
            [FromServices] AppDbContext context,
            int contactId,
            int page,
            int line)

        {
            var searchId = from p
                               in _context.Contacts
                           where p.Id.Equals(contactId)
                           select p;

            var contacts = await searchId
                .Skip(page)
                .Take(line)
                .ToListAsync();

            var total = searchId.Count();
            var pageShown = contacts.Count();

            return Ok(new
            {
                TotalFound = total,
                Shown = pageShown,
                contacts
            });
        }


        [HttpGet("SearchConpanyId/{conpanyId:int}/page/{page:int}/line/{line:int}")]
        public async Task<ActionResult<Contact>> GetContactForConpanyId(
            [FromServices] AppDbContext context,
            int conpanyId,
            int page,
            int line)

        {
            var searchConpanyId = from p
                               in _context.Contacts
                                  where p.CompanyId.Equals(conpanyId)
                                  select p;

            var contacts = await searchConpanyId
                .Skip(page)
                .Take(line)
                .ToListAsync();

            var total = searchConpanyId.Count();
            var pageShown = contacts.Count();

            return Ok(new
            {
                TotalFound = total,
                Shown = pageShown,
                contacts
            });
        }


        [HttpGet("SearchNameContact/{nameContact}/page/{page:int}/line/{line:int}")]
        public async Task<ActionResult<Contact>> GetContactForName(
            [FromServices] AppDbContext context,
            string nameContact,
            int page,
            int line)

        {
            var searchNameContact = from p
                                    in _context.Contacts
                                    where p.Name.Equals(nameContact)
                                    select p;

            var contacts = await searchNameContact
                .Skip(page)
                .Take(line)
                .ToListAsync();

            var total = searchNameContact.Count();
            var pageShown = contacts.Count();

            return Ok(new
            {
                TotalFound = total,
                Shown = pageShown,
                contacts
            });
        }

        [HttpGet("SearchPhone/{phoneContact}/page/{page:int}/line/{line:int}")]
        public async Task<ActionResult<Contact>> GetContactForPhone(
            [FromServices] AppDbContext context,
            string phoneContact,
            int page,
            int line)

        {
            var searchContactPhone = from p
                               in _context.Contacts
                                     where p.Phone.Equals(phoneContact)
                                     select p;

            var contacts = await searchContactPhone
                .Skip(page)
                .Take(line)
                .ToListAsync();

            var total = searchContactPhone.Count();
            var pageShown = contacts.Count();

            return Ok(new
            {
                TotalFound = total,
                Shown = pageShown,
                contacts
            });
        }

        [HttpGet("SearchEmail/{emailContact}/page/{page:int}/line/{line:int}")]
        public async Task<ActionResult<Contact>> GetContactForEmail(
            [FromServices] AppDbContext context,
            string emailContact,
            int page,
            int line)

        {
            var searchEmailContact = from p
                                    in _context.Contacts
                                     where p.Email.Equals(emailContact)
                                     select p;

            var contacts = await searchEmailContact
                .Skip(page)
                .Take(line)
                .ToListAsync();

            var total = searchEmailContact.Count();
            var pageShown = contacts.Count();

            return Ok(new
            {
                TotalFound = total,
                Shown = pageShown,
                contacts
            });
        }

        [HttpGet("SearchAddress/{addressContact}/page/{page:int}/line/{line:int}")]
        public async Task<ActionResult<Contact>> GetContactForAddress(
            [FromServices] AppDbContext context,
            string addressContact,
            int page,
            int line)

        {
            var searchAddressContact = from p
                                       in _context.Contacts
                                       where p.Address.Equals(addressContact)
                                       select p;

            var contacts = await searchAddressContact
                .Skip(page)
                .Take(line)
                .ToListAsync();

            var total = searchAddressContact.Count();
            var pageShown = contacts.Count();

            return Ok(new
            {
                TotalFound = total,
                Shown = pageShown,
                contacts
            });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact(int id, Contact contact)
        {
            if (id != contact.Id)
            {
                return BadRequest();
            }

            _context.Entry(contact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(id))
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

        [HttpPost("ImportCsvFile/{path}")]
        public async Task<ActionResult<Contact>> ImportCsvFile(
            [FromServices] AppDbContext context, string path)

        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
                UseFieldIndexForReadingData = true
            };

            var csvContext = new CsvContext();
            var contacts = csvContext.Read<Contact>(path, csvFileDescription);

            try
            {
                foreach (var contact in contacts)
                {
                    if (!ContactExists(contact.Id))
                    {
                        Contact newContact = new Contact(
                            contact.Id,
                            contact.ContactBookId,
                            contact.CompanyId,
                            contact.Name,
                            contact.Phone,
                            contact.Email,
                            contact.Address);

                        _context.Contacts.Add(newContact);
                    }
                }

                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Contact>> PostContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContact", new { id = contact.Id }, contact);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.Id == id);
        }
    }
}

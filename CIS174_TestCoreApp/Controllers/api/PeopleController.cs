using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CIS174_TestCoreApp;
using CIS174_TestCoreApp.Entities;
using CIS174_TestCoreApp.Filters;

namespace CIS174_TestCoreApp.Controllers.api
{
    [LogResourceFilter]
    [FeatureEnabled(IsEnabled = true)]
    [Route("api/People")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly PersonContext _context;

        public PeopleController(PersonContext context)
        {
            _context = context;
        }

        // GET: api/People
        [HttpGet]
        public IEnumerable<Person> GetPersons()
        {
            return _context.Persons;
        }

        // GET: api/People/5
        [ValidateModel]
        [Route("get")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson([FromRoute] int id)
        {

            var person = await _context.Persons.FindAsync(id);

            return Ok(person);
        }

        // PUT: api/People/5
        [ValidateModel]
        [Route("put")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson([FromRoute] int id, [FromBody] Person person)
        {

            if (id != person.Id)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
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

        // PUT: api/People/5
        [ValidatePerson]
        [Route("update")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerson([FromRoute] int id, [FromBody] Person person)
        {

            if (id != person.Id)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
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

        // POST: api/People
        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> PostPerson([FromBody] Person person)
        {

            _context.Persons.Add(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerson", new { id = person.Id }, person);
        } 

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        [Route("delete")]
        public async Task<IActionResult> DeletePerson([FromRoute] int id)
        {

            var person = await _context.Persons.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();

            return Ok(person);
        }

        private bool PersonExists(int id)
        {
            return _context.Persons.Any(e => e.Id == id);
        }
    }
}
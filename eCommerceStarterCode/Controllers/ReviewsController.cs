using Microsoft.AspNetCore.Mvc;
using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;
using eCommerceStarterCode.Controllers;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ReviewsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var allProducts = _context.Reviews.Include(p => p.Customer).Where(p => p.ProductId == id);
            return Ok(allProducts);
        }

        // POST api/<ReviewsController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Review value)
        {
            _context.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<ReviewsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReviewsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

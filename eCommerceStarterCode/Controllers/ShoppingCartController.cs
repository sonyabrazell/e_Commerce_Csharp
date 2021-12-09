using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ShoppingCartController>/b8761e98-e02e-4f34-ad8f-fd2dcc25af5b
        [HttpGet("{Userid}"), Authorize]
        public IActionResult Get(string UserId)
        {
            var shoppingCart = _context.ShoppingCarts.Include(sc => sc.Customer).Include(sc => sc.Product).Where(sc => sc.UserId == UserId).ToList();
            return Ok(shoppingCart);
        }

        // POST api/<ShoppingCartController>
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] ShoppingCart value)
        {
            _context.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<ShoppingCartController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShoppingCartController>/5
        [HttpDelete("{id}"), Authorize]
        public IActionResult Delete(int id)
        {
            var shoppingCart = _context.ShoppingCarts.Where(sc => sc.Id == id).SingleOrDefault();
            _context.Remove(shoppingCart);
            _context.SaveChanges();
            return StatusCode(200, shoppingCart);
        }
    }
}

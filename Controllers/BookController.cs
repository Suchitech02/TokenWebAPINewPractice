using System.Threading.Tasks;
using TokenWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TokenWebAPI.Controllers
{
   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController: ControllerBase
    {
        private readonly jwt1Context _context;
        public BookController(jwt1Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var data = await _context.TblBook.ToListAsync();
            return Ok(data);
        }
    }
}
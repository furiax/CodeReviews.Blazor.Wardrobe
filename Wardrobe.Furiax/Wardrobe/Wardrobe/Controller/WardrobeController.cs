using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wardrobe.Context;
using Wardrobe.Shared.Entities;

namespace Wardrobe.Controller
{
    [Route("api/wardrobe")]
    [ApiController]
    public class WardrobeController : ControllerBase
    {
        private readonly WardrobeContext _context;
        public WardrobeController(WardrobeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Clothpiece>>> GetAllClothsAsync()
        {
            return await _context.ClothPieces.ToListAsync();
        }
    }
}

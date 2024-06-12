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
        private readonly IWebHostEnvironment _environment;
        public WardrobeController(WardrobeContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [HttpGet]
        public async Task<ActionResult<List<Clothpiece>>> GetAllClothsAsync()
        {
            return await _context.ClothPieces.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Clothpiece>>> GetClothByIdAsync(int id)
        {
            var result = await _context.ClothPieces.FindAsync(id);
            if (result == null)
                return NotFound("Clothpiece not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClothAsync(int id)
        {
            var result = await _context.ClothPieces.FindAsync(id);
            if (result == null)
                return NotFound("Clothpiece not found");
            _context.Remove(result);
            _context.SaveChangesAsync();

            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Clothpiece>> UpdateClothAsync(int id, Clothpiece updatedCloth)
        {
            var dbCloth = await _context.ClothPieces.FindAsync(id);
            if (dbCloth == null)
                return NotFound("Clothpiece not found");

            dbCloth.Type = updatedCloth.Type;
            dbCloth.Color = updatedCloth.Color;
            dbCloth.Brand = updatedCloth.Brand;
            dbCloth.ImageUrl = updatedCloth.ImageUrl;

            _context.SaveChangesAsync();

            return Ok(dbCloth);
        }

        [HttpPost]
        public async Task<ActionResult<Clothpiece>> AddClothAsync(Clothpiece newCloth)
        {
            _context.Add(newCloth);
            await _context.SaveChangesAsync();

            return Ok(newCloth);
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadImageAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            var allowedExtensions = new[] { ".jpg", ".jpeg", ".gif", ".png" };
            var fileExtension = Path.GetExtension(file.FileName).ToLower();
            if (!allowedExtensions.Contains(fileExtension))
            {
                return BadRequest("Invalid file extension. Only .jpg, .jpeg, .gif and .png are allowed.");
            }

            var uploadPath = Path.Combine(_environment.WebRootPath, "uploads");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            var fileName = Path.GetFileNameWithoutExtension(file.FileName);
            var newFileName = $"{fileName}-{Guid.NewGuid()}{fileExtension}";
            var filePath = Path.Combine(uploadPath, newFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var fileUrl = $"/uploads/{newFileName}";
            return Ok(fileUrl);
        }

    }
}

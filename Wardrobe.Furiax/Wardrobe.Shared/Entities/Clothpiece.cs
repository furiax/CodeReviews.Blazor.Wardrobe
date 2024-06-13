using System.ComponentModel.DataAnnotations;

namespace Wardrobe.Shared.Entities
{
    public class Clothpiece
    {
        public int Id { get; set; }
        public ClothType Type { get; set; }
        [Required(ErrorMessage ="Color is a required field.")]
        [StringLength(50, ErrorMessage ="Color cannot exceed 50 characters.")]
        public string Color { get; set; }
        [Required(ErrorMessage ="Brand is required, if unknown please type unknown.")]
        [StringLength(50, ErrorMessage ="Brand cannot exceed 50 characters.")]
        public string Brand { get; set; }
        public string Image { get; set; }
    }

    public enum ClothType
    {
        Tshirt,
        Shirt,
        Sweater,
        Jacket,
        Underwear,
        Pants,
        ShortPants,
        Socks,
        Shoes,
        Other
    }
}

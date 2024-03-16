namespace Wardrobe.Components.Models
{
    public class Cloth
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public string Color { get; set; }
        public string? Brand { get; set; }
        public string ImageUrl { get; set; }

    }

    public enum Type
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

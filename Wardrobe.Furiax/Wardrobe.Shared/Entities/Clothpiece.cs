namespace Wardrobe.Shared.Entities
{
    public class Clothpiece
    {
        public int Id { get; set; }
        public ClothType Type { get; set; }
        public string Color { get; set; }
        public string? Brand { get; set; }
        public string ImageUrl { get; set; }
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

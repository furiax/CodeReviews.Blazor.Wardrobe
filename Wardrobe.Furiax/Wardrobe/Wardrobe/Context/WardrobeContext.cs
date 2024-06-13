using Microsoft.EntityFrameworkCore;
using Wardrobe.Shared.Entities;

namespace Wardrobe.Context
{
    public class WardrobeContext : DbContext
    {
        public WardrobeContext(DbContextOptions<WardrobeContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Clothpiece>().HasData(
                new Clothpiece { Id = 1, Type = Shared.Entities.ClothType.Tshirt, Brand = "Jack & Jones", Color = "blue", Image = "https://images.jackjones.com/12237367/4239534/001/jackjones-gedruktt-shirtvoorjongens-blauw.jpg?v=45584ed700fb0f028ac104ed43721306&format=webp&width=1280&quality=90&key=25-0-3" },
                new Clothpiece { Id = 2, Type = Shared.Entities.ClothType.Pants, Brand = "Lee Cooper", Color = "blue", Image = "https://cf75d1d9c.cloudimg.io/v7/imageserver/original/LC110ZP_ECO%20MID%20BLUE.jpg" },
                new Clothpiece { Id = 3, Type = Shared.Entities.ClothType.Shoes, Brand = "Addidas", Color = "white", Image = "https://www.torfs.be/dw/image/v2/BCQR_PRD/on/demandware.static/-/Sites-torfs-catalog-master/default/dwe08d8d54/hi-res/pdp/319/319013/319013-3.jpg?sw=820" }
                );
        }
        public DbSet<Clothpiece> ClothPieces { get; set; }
    }
}

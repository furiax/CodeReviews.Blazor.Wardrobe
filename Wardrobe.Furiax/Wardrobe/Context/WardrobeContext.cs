﻿using Microsoft.EntityFrameworkCore;
using Wardrobe.Components.Models;

namespace Wardrobe.Context
{
    public class WardrobeContext: DbContext
    {
        public WardrobeContext(DbContextOptions<WardrobeContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cloth>().HasData(
                new Cloth { Id = 1, Type = Components.Models.Type.Tshirt, Brand = "Jack & Jones", Color = "blue", ImageUrl= "https://images.jackjones.com/12237367/4239534/001/jackjones-gedruktt-shirtvoorjongens-blauw.jpg?v=45584ed700fb0f028ac104ed43721306&format=webp&width=1280&quality=90&key=25-0-3" },
                new Cloth { Id = 2, Type = Components.Models.Type.Pants, Brand = "Lee Cooper", Color = "blue", ImageUrl= "https://cf75d1d9c.cloudimg.io/v7/imageserver/original/LC110ZP_ECO%20MID%20BLUE.jpg" },
                new Cloth { Id = 3, Type = Components.Models.Type.Shoes, Brand = "Addidas", Color = "white", ImageUrl= "https://i8.amplience.net/i/jpl/jd_348391_a?qlt=92&w=750&h=531&v=1&fmt=auto" }
                );
        }
        public DbSet<Cloth> Cloths { get; set; }
    }
}

using E_Commerce_App.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_App.Data
{

    public class EcommercelDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public EcommercelDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>().HasData(
              new Categorie { CategorieId = 1, CategoryName = "INDOOR PLANTS ", CategoryDescription= "Add a touch of natural beauty to your place! Through a variety of indoor ornamental plants equipped in containers and basins, in addition to large and small flowering indoor plants." },
              new Categorie { CategorieId = 2, CategoryName = "OUTDOOR PLANTS ", CategoryDescription = "A variety of outdoor plants that can be used in open spaces such as the garden of the house or around the walls and entrances of the house" },
             new Categorie { CategorieId = 3, CategoryName = "Bedroom Plants ", CategoryDescription = "Bedroom plants can do more than just make your shelves look brighter. They can also boost your mood, enhance your creativity, reduce your stress levels, increase your productivity, naturally filter air pollutants, and much more. "},
          new Categorie { CategorieId = 4, CategoryName = "Jungle Plants ", CategoryDescription = "Null" }



                 );
        }
    }

}

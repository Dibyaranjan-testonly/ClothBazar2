using ClothBazar.Entities;
using System.Data.Entity;


namespace ClothBazar.Database
{
    class CBContext : DbContext
    {
        public CBContext() : base("name=ClothBazarDatabase")
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }

    }
}

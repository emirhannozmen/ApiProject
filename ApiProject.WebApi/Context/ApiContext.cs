using ApiProject.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.WebApi.Context
{
    public class ApiContext:DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EMIR;initial catalog=YummyDb;integrated security=true;TrustServerCertificate=True;");
        }
        DbSet<Category> Categories { get; set; }
        DbSet<Chef> Chefs { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Feature> Features { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<Testimonial> Testimonials { get; set; }
    }
}
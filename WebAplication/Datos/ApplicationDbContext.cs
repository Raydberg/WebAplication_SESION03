using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using WebAplication.Models;
namespace WebAplication.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Contacto> Contacto { get; set; }
       
    }
}
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
<<<<<<< HEAD
=======
       
>>>>>>> 3d36b5b0a731da8d000d621163790cc2c3e72395
    }
}
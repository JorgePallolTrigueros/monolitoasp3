using CrudEFCoreNet6.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudEFCoreNet6.Datos
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        //Agregar el modelo usuario y todos los modelos aquí, de la siguiente forma:
        public DbSet<Usuario> Usuario { get; set; }
    }
}

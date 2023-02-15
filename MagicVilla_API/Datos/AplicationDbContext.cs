using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }   //Definimos como se va crear en la base de datos
        public DbSet<NumeroVilla> NumeroVillas { get; set; }

    }
}

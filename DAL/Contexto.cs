using Microsoft.EntityFrameworkCore;

namespace DAL
{
    /// <summary>
    /// Clase que crea el contexto con la base de datos
    /// <author>ASMP 14-12-23</author>
    /// </summary>
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcion) : base(opcion)
        {

        }
        public DbSet<Vajilla> vajillas { get; set; }
        public DbSet<Prestamo> prestamos { get; set; }

        public DbSet<Rel_Vajilla_Prestamo> rel_Vajillas_Prestamos { get; set; }
       
    }
}
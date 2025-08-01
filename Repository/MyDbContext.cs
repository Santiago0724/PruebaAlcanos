using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository;

public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
{
    public DbSet<Colas> Colas { get; set; }
    public DbSet<Mensajes> Mensajes { get; set; }
    public DbSet<Suscriptores> Suscriptores { get; set; }

}

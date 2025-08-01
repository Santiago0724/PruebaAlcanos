using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository.Entidades;

public class ColaRepository(MyDbContext db)
{
    public async Task<List<Colas>> GetAsync()
        => await db.Colas.Include(x => x.oSuscriptores).ToListAsync();
    
}

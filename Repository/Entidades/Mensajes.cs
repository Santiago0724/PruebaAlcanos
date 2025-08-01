using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository.Entidades;

public class MensajesRepository(MyDbContext db)
{
    public async Task<List<Mensajes>> GetAsync()
         => await db.Mensajes.ToListAsync();

    public async Task UpdateAsync(Mensajes entidad)
    {
        db.Update(entidad);
        await db.SaveChangesAsync();
    }


}

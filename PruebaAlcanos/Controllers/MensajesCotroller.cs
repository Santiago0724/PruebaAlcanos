using Microsoft.AspNetCore.Mvc;
using Models;
using Repository.Entidades;

namespace PruebaAlcanos.Controllers;


[ApiController]
[Route("[controller]")]
public class MensajesCotroller(MensajesRepository r)
{
    [HttpGet]
    public async Task<List<Mensajes>> GetAsync()
    => await r.GetAsync();

    [HttpPatch]
    public async Task Update(Mensajes entidad)
        => await r.UpdateAsync(entidad);
}

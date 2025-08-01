using Microsoft.AspNetCore.Mvc;
using Models;
using Repository.Entidades;

namespace PruebaAlcanos.Controllers;


[ApiController]
[Route("[controller]")]
public class ColasController(ColaRepository r)
{
    [HttpGet]
    public async Task<List<Colas>> GetAsync()
        => await r.GetAsync();
}

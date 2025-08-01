using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Colas
{
    public int Id { get; set; }
    public string? Descripcion { get; set; }
    public int Suscriptores_id { get; set; }

    [ForeignKey("Suscriptores_id")]
    public Suscriptores oSuscriptores { get; set; }
}

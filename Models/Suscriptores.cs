using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Suscriptores
{
    public int Id { get; set; }
    public int Cola_id { get; set; }
    [ForeignKey("Cola_id")]
    public Colas oCola { get; set; }
}

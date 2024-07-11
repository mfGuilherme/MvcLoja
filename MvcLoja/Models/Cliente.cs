using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLoja.Models;

public class Cliente
{

    [Column("IdCliente")]
    [Key]
    public int ClienteID { get; set; }
    [Column("NmCliente")]
    public required string Nome { get; set; }
    [Column("Cidade")]
    public required string Cidade { get; set; }
}

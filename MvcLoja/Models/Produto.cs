using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLoja.Models
{
    public class Produto
    {
        [Column("IdProduto")]
        [Key]
        public int ProdutoID { get; set; }
        [Column("DscProduto")]
        public required string Descricao { get; set; }
        [Column("VlrUnitario")]
        public float Valor { get; set; }
    }
}

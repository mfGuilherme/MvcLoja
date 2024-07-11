using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLoja.Models
{
    public class Venda
    {

        [Column("IdVenda")]
        public int ID { get; set; }
        [Column("IdCliente")]
        public int ClienteID { get; set; }
        [Column("IdProduto")]
        public int ProdutoID { get; set; }
        [Column("QtdVenda")]
        public int Quantidade { get; set; }
        [Column("VlrUnitarioVenda")]
        [Display(Name = "Valor Da Venda")]
        public int ValorVenda { get; set; }
        [Column("DthVenda")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        [Column("VlrTotalVenda")]
        [Display(Name = "Valor Total Da Compra")]
        public int ValorTotal { get; set; }
        [ValidateNever]
        public Cliente Cliente { get; set; }
        [ValidateNever]
        public Produto Produto { get; set; }

    }
}

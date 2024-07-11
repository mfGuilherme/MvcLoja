using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcLoja.Data;
using MvcLoja.Models;

namespace MvcLoja.Controllers
{
    public class TesteAPIController : Controller
    {
        private readonly MvcLojaContext _context;

        public TesteAPIController(MvcLojaContext context)
        {
            _context = context;
        }
        public IActionResult Cliente(List<Cliente> Clientes)
        {
            foreach (var cliente in Clientes)
            {
                _context.Add(cliente);

            }
            _context.SaveChangesAsync();
            return Ok();
        }
        public IActionResult Produto(List<Produto> Produtoes)
        {
            {
                foreach (var produto in Produtoes)
                {
                    _context.Add(produto);

                }
                _context.SaveChangesAsync();

                return Ok();
            }
        }
        public IActionResult Venda(List<Venda> Vendas)
        {
            {

                foreach (var venda in Vendas)
                {
                   _context.Add(venda);

                }
                _context.SaveChangesAsync();

                 return Ok();

            }
        }
        
    }
}

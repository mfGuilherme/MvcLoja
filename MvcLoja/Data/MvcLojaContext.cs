using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcLoja.Models;

namespace MvcLoja.Data
{
    public class MvcLojaContext : DbContext
    {
        public MvcLojaContext (DbContextOptions<MvcLojaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcLoja.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<MvcLoja.Models.Produto> Produto { get; set; } = default!;
        public DbSet<MvcLoja.Models.Venda> Venda { get; set; } = default!;
    }
}

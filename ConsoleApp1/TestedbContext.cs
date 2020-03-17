using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TestedbContext : DbContext
    {
        public TestedbContext(DbContextOptions<TestedbContext> options) : base(options)
        {
        }
        public DbSet<Exemplo> Exemplos { get; set; }
    }
}

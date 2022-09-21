using maisumdenovo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maisumdenovo.Data
{
    public class Contexto: DbContext
    {

        public Contexto(DbContextOptions options) : base(options) { 
        }

        DbSet<Pessoa> pessoas { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SEPLAN-0368\SQLEXPRESS;Database=devPessoa;Trusted_Connection=True;");
        }
    }
}

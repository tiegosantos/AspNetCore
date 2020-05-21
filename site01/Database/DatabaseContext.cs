using Microsoft.EntityFrameworkCore;
using site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace site01.Database
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Palavra> Palavras { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> Options) : base(Options)
        {
            //EF GARANTIR QUE O BANCO DE DADOS SEJA CRIADO PELO  EF
            Database.EnsureCreated();
        }
    }
}

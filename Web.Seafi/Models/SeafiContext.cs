using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Seafi.Models
{
    public class SeafiContext: DbContext
    {
        public SeafiContext(DbContextOptions<SeafiContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}

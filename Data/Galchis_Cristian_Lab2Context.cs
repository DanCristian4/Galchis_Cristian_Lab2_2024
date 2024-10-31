using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Galchis_Cristian_Lab2.Models;

namespace Galchis_Cristian_Lab2.Data
{
    public class Galchis_Cristian_Lab2Context : DbContext
    {
        public Galchis_Cristian_Lab2Context (DbContextOptions<Galchis_Cristian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Galchis_Cristian_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Galchis_Cristian_Lab2.Models.Publisher> Publisher { get; set; } = default!;

        public DbSet<Galchis_Cristian_Lab2.Models.Author> Author { get; set; } = default!;

    }
}

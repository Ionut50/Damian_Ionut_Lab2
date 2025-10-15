using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Damian_Ionut_Lab2.Models;

namespace Damian_Ionut_Lab2.Data
{
    public class Damian_Ionut_Lab2Context : DbContext
    {
        public Damian_Ionut_Lab2Context (DbContextOptions<Damian_Ionut_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Damian_Ionut_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Damian_Ionut_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Damian_Ionut_Lab2.Models.Author> Author { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Herembas_Timotei_Lab2.Models;

namespace Herembas_Timotei_Lab2.Data
{
    public class Herembas_Timotei_Lab2Context : DbContext
    {
        public Herembas_Timotei_Lab2Context (DbContextOptions<Herembas_Timotei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Herembas_Timotei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Herembas_Timotei_Lab2.Models.Publisher> Publisher { get; set; }
    }
}

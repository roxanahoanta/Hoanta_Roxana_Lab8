using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hoanta_Roxana_Lab8.Models;

namespace Hoanta_Roxana_Lab8.Data
{
    public class Hoanta_Roxana_Lab8Context : DbContext
    {
        public Hoanta_Roxana_Lab8Context (DbContextOptions<Hoanta_Roxana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Hoanta_Roxana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Hoanta_Roxana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Hoanta_Roxana_Lab8.Models.Category> Category { get; set; }
    }
}

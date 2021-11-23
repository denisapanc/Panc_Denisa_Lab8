using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Panc_Denisa_Lab8.Models;

namespace Panc_Denisa_Lab8.Data
{
    public class Panc_Denisa_Lab8Context : DbContext
    {
        public Panc_Denisa_Lab8Context (DbContextOptions<Panc_Denisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Panc_Denisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Panc_Denisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Panc_Denisa_Lab8.Models.Category> Category { get; set; }
    }
}

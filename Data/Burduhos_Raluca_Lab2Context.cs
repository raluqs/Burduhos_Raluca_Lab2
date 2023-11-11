using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Burduhos_Raluca_Lab2.Models;

namespace Burduhos_Raluca_Lab2.Data
{
    public class Burduhos_Raluca_Lab2Context : DbContext
    {
        public Burduhos_Raluca_Lab2Context (DbContextOptions<Burduhos_Raluca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Burduhos_Raluca_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Burduhos_Raluca_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Burduhos_Raluca_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Burduhos_Raluca_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Burduhos_Raluca_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Burduhos_Raluca_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}


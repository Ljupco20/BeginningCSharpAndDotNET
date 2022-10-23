using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginCSharpDotNet_17_1_CodeFirstDatabase
{
    public class BookContext : DbContext
    {public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Data Source=(LocalDB)\MSSQLLocalDB;Database=Books;Integrated Security=True");
        }

    }
}

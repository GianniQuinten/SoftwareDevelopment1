using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    internal class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Genre> Genres { get; set; } = null!;

        public DbSet<Item> Items { get; set; } = null!;

        public DbSet<Publisher> Publishers { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			// this here uses the connection. but how do we make it a non static connection so that everyone can use it?
			optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=librarymvvm;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

		}


	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MapleMvc01.BookStoreEntities;

namespace MapleMvc01.Models
{
    public class BookStoreDbContext:DbContext
    {
        public BookStoreDbContext() : base()
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categoris { get; set; }
        


    }

}
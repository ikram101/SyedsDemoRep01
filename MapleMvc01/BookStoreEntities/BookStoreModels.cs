using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MapleMvc01.BookStoreEntities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string LastName { get; set; }
        public List<Book> Titles { get; set; } = new List<Book>();
    }

    public class Book
    {

        public Book()
        {
            Categories = new HashSet<Category>();
        }

        public int BookId { get; set; }
        public string Title { get; set; }

        public int Price { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public int? AuthorId { get; set; }
        public Author Author { get; set; }

        public AuthorBiography Biography { get; set; }


        public ICollection<Category> Categories { get; set; }
    }

    public class Category
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Book> Books { get; set; }
    }


    
    public class AuthorBiography
{
    public int AuthorBiographyId { get; set; }
    public string Biography { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; }
    public string Nationality { get; set; }
          
    public int? AuthorId { get; set; }
    public Author Author { get; set; }
}
}
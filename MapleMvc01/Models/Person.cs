using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapleMvc01.Models
{
    //public class Author
    //{
    //    public int AuthorId { get; set; }
    //    public string LastName { get; set; }
    //    public List<Book> Titles { get; set; } = new List<Book>();
    //}

    //public class Book
    //{
    //    public int BookId { get; set; }
    //    public string Title { get; set; }
    //    public Author Author { get; set; }
    //}


    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }

        public List<car> Cars { get; set; }
    }

    public class MyGenClass<T>
    {
        private T gnMember;

        public MyGenClass(T value)
        {
            gnMember = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), gnMember);

            return gnMember;
        }

        public T gnProperty { get; set; }
    }


    public class Hello
    {
        Person person = new Person();

        MyGenClass<int> genIntClass = new MyGenClass<int>(22);

        MyGenClass<Person> genPersonClass = new MyGenClass<Person>(new Person());

    }

}
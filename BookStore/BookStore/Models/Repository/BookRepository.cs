using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repository
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        IList<Book> books;

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Id = 1, Title= "C# Programming", Description="No Description"
                },
                new Book
                {
                    Id = 2, Title= "Java Programming", Description="Nothing"
                },
                new Book
                {
                    Id = 3, Title= "Python Programming", Description="No Data"
                },
            };
        }

        public void Add(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Book Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Book> List()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Book entity)
        {
            throw new NotImplementedException();
        }
    }
}

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
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id, Book NewEntity)
        {
            var book = Find(id);
            book.Title = NewEntity.Title;
            book.Author = NewEntity.Author;
            book.Description = NewEntity.Description; 
        }
    }
}

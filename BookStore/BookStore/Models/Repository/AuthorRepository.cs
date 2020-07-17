using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repository
{
    public class AuthorRepository : IBookstoreRepository<Author>
    {
        IList<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author
                {
                    Id=1, FullName="Abdullah"
                },
                new Author
                {
                    Id=2, FullName="Marwah"
                },
                new Author
                {
                    Id=3, FullName="Mohammed"
                },
            };
        }
        public void Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Author Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Author> List()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Author entity)
        {
            throw new NotImplementedException();
        }
    }
}

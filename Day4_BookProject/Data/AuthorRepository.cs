using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Data
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly List<Author> _authors;
        public AuthorRepository()
        {
            _authors = new List<Author>()
            {
                new Author() { Id=1,Name="Sir Arthur Conan Doyl"},
                new Author() { Id=2,Name="Maurice Leblanc"},
                new Author() { Id=3,Name="Mustafa Kemal Atatürk"},
                new Author() { Id=4,Name="Jack Weatherford"},
                new Author() { Id=5,Name="Peyami Safa"},
                new Author() { Id=6,Name="Gök Türk"}
            };
        }

        public void Add(Author author)
        {
            _authors.Add(author);
        }

        public void Delete(int id)
        {
            Author? author = _authors.Where(x=>x.Id == id).FirstOrDefault();
            if (author is null)
            {
                throw new AuthorNotFoundException(id);
            }
            _authors.Remove(author);
        }

        public List<Author> GetAll()
        {
            return _authors;
        }

        public Author? GetById(int id)
        {
            Author? author = _authors.Where(x=> x.Id == id).FirstOrDefault();
            if (author is null)
            {
                throw new AuthorNotFoundException(id);
            }
            return author;
        }
    }
}

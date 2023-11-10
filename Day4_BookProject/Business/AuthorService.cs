using Day4_BookProject.Data;
using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Business
{
    internal class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository IAR)
        {
            _authorRepository = IAR;
        }

        public void Add(Author author)
        {
            try
            {
                AddRules(author);
                _authorRepository.Add(author);
                GetList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _authorRepository.Delete(id);
                GetList();
            }
            catch (AuthorNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetById(int id)
        {
            try
            {
                Author? author=_authorRepository.GetById(id);
                Console.WriteLine(author);
            }
            catch (AuthorNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetList()
        {
            List<Author> authors = _authorRepository.GetAll();
            authors.ForEach(author => Console.WriteLine(author));
        }

        public void AddRules(Author author)
        {
            if(author.Name.Length < 2)
            {
                throw new AuthorNameException(author.Name);
            }
        }
    }
}

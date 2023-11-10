using Day4_BookProject.Models;

namespace Day4_BookProject.Business
{
    internal interface IAuthorService
    {
        void GetList();
        void Add(Author author);
        void Delete(int id);
        void GetById(int id);

    }
}

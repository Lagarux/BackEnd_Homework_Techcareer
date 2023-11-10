// Kitap ekleme listeleme ve silme gibi operasyonları simüle edeceğiz
// veri tabanı gibi çalışan bir liste kullanacağız

using Day4_BookProject.Business;
using Day4_BookProject.Data;
using Day4_BookProject.Models;
// Dapper


IBookService bookService = new BookService(new BookRepository());
//bookService.GetList();

Book book = new Book()
{
    Id = 5,
    Description = "Test",
    Price=2500,
    Stock=-2000,
    Title= "Test",
    AuthorID=4,
    CategoryId="2",
    ISBN= "978-975-17-3133-3"
};

Book book2 = new Book()
{
    Id = 21,
    Description = "Son zamanlarda Soğuk Savaş'tan itibaren gelişen savaş stratejileri ve davranış biçimleri...",
    Price = 320,
    Stock = 1500,
    Title = "Savaşın Son Yüzü",
    AuthorID = 4,
    CategoryId = "2",
    ISBN = "891-975-08-1683-7"
};

Console.WriteLine("Kayıt ekleme : ");
bookService.Add(book);
bookService.Add(book2);
//Console.WriteLine("Kayıt silme : ");
//bookService.Delete(2);

//Console.WriteLine("Id ye göre getirme:");
//bookService.GetById(2);


//Console.WriteLine("Kitapların listesi");
//bookService.GetList();

IAuthorService IAS=new AuthorService(new AuthorRepository());
Author bookAuthor = new Author() { Id=8,Name = "Marcus Le Graven"};
//IAS.Add(bookAuthor);
//IAS.GetById(3);
IAS.Delete(9);
IAS.Add(bookAuthor);
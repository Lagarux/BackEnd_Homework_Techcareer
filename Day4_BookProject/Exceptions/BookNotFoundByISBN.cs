using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Exceptions
{
    public class BookNotFoundByISBN : Exception
    {
        public BookNotFoundByISBN(string ISBN) : base($"ISBN : {ISBN} olan bir kitap bulunmamaktadır")
        {
            
        }
    }
}

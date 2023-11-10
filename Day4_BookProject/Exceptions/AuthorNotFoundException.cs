using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Exceptions
{
    public class AuthorNotFoundException : Exception
    {
        public AuthorNotFoundException(int id) : base($" ID : {id} olan yazar bulunamadı")
        {
            
        }
    }
}

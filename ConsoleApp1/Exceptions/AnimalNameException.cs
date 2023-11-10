using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Const;

namespace Zoo_Project.Exceptions
{
    public class AnimalNameException: Exception
    {
        public AnimalNameException(string name) : base(ErrorMessages.AnimalNameExceptionMessage(name))
        {
            
        }
    }
}

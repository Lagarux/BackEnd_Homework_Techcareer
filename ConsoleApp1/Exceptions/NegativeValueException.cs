using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Const;

namespace Zoo_Project.Exceptions
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException(int val) : base (ErrorMessages.NegativeValueExceptionMessage(val))
        {
            
        }

        public NegativeValueException(decimal val) : base(ErrorMessages.NegativeValueExceptionMessage(val))
        {
            
        }
    }
}

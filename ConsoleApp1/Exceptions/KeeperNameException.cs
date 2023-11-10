using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Const;

namespace Zoo_Project.Exceptions
{
    public class KeeperNameException : Exception
    {
        public KeeperNameException(string name) : base(ErrorMessages.KeeperNameExceptionMessage(name))
        {
            
        }
    }
}

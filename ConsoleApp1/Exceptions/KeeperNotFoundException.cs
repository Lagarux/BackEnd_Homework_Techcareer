using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project.Exceptions
{
    internal class KeeperNotFoundException : Exception
    {
        public KeeperNotFoundException(int id) : base($"ID : {id} olan Bakıcı bulunamadı")
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project.Exceptions
{
    public class AnimalNotFoundException : Exception
    {
        public AnimalNotFoundException(int id) : base($"ID: {id} olan hayvan bulunamadı")
        {
            
        }
    }
}

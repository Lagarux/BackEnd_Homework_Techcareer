using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project.Exceptions
{
    public class FoodNotFoundException : Exception
    {
        public FoodNotFoundException(int id) : base($"ID: {id} olan yiyecek bulunamadı")
        {
            
        }
    }
}

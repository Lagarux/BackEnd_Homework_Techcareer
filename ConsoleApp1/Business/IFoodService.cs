using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Models;

namespace Zoo_Project.Business
{
    public interface IFoodService
    {
        void GetAll();
        void Add(Foods food);
        void GetByID(int id);
    }
}

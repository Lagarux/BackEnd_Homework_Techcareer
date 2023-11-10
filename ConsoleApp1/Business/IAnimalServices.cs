using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Models;

namespace Zoo_Project.Business
{
    public interface IAnimalServices
    {
        void GetAll();
        void Add(Animals animal);
        void Remove(int id);
        void GetById(int id);
    }
}

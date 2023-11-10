using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Models;

namespace Zoo_Project.Business
{
    internal interface IKeeperService
    {
        void GetList();
        void Add(Keepers keeper);
        void Delete(int id);
        void GetById(int id);
    }
}

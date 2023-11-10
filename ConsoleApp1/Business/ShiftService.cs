using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Data;

namespace Zoo_Project.Business
{
    internal class ShiftService : IShiftService
    {
        private readonly IShiftRepository _shiftRepository;
        public ShiftService(IShiftRepository ISR)
        {
            _shiftRepository = ISR;
        }

        public void GetList()
        {
            _shiftRepository.GetAll().ForEach(x=>Console.WriteLine(x));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Models;

namespace Zoo_Project.Data
{
    public class ShiftRepository : IShiftRepository
    {
        private readonly List<Shifts> _shifts;
        public ShiftRepository()
        {
            _shifts = new List<Shifts>()
            {
                new Shifts() { Id = 1,Type="Gündüz Vardiyası",startTime="09:00",endTime="17:00"},
                new Shifts() { Id = 2,Type="Gece Vardiyası",startTime="19:00",endTime="08:00"},
                new Shifts() { Id = 3,Type="Hafta Sonu Vardiyası",startTime="10:00",endTime="19:00"},
            };
        }

        public void Add(Shifts shift)
        {
            _shifts.Add(shift);
        }

        public void Delete(int id)
        {
            Shifts? shift = _shifts.Where(x => x.Id == id).FirstOrDefault();
            if(shift is null)
            {

            }
            _shifts.Remove(shift);
        }

        public List<Shifts> GetAll()
        {
            return _shifts;
        }

        public Shifts? GetByID(int id)
        {
            Shifts? shift = _shifts.Where(x => x.Id == id).FirstOrDefault();
            if (shift is null)
            {

            }
            return shift;
        }
    }
}

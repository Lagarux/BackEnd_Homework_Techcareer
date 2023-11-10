using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Exceptions;
using Zoo_Project.Models;

namespace Zoo_Project.Data
{
    public class KeeperRepository : IKeeperRepository
    {
        private readonly List<Keepers> _keepers;
        public KeeperRepository()
        {
            _keepers = new List<Keepers>() 
            {
                new Keepers() {Id=1,Name="Kamil Hasırcı", Age=23,PhoneNumber="+90 552 341 14 57",ShiftID=1},
                new Keepers() {Id=2,Name="Mustafa Demirkargı", Age=30,PhoneNumber="+90 542 114 61 48",ShiftID=1},
                new Keepers() {Id=3,Name="Emine Darzade", Age=29,PhoneNumber="+90 507 725 11 39",ShiftID=2},
                new Keepers() {Id=4,Name="Müberra Kazancıgil", Age=36,PhoneNumber="+90 556 145 81 24",ShiftID=2},
                new Keepers() {Id=5,Name="Şakir Çamlıdere", Age=26,PhoneNumber="+90 506 298 43 26",ShiftID=3}
            };
        }

        public void Add(Keepers keeper)
        {
            _keepers.Add(keeper);
        }

        public void Delete(int id)
        {
            Keepers? keeper = _keepers.Where(x=>x.Id==id).FirstOrDefault();
            if(keeper is null)
            {
                throw new KeeperNotFoundException(id);
            }
            _keepers.Remove(keeper);
        }

        public List<Keepers> GetAll()
        {
            return _keepers;
        }

        public Keepers? GetByID(int id)
        {
            Keepers? keeper = _keepers.Where(x=>x.Id == id).FirstOrDefault();
            if (keeper is null)
            {
                throw new KeeperNotFoundException(id);
            }
            return keeper;
        }
    }
}

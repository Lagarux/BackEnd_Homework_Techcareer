using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Exceptions;
using Zoo_Project.Models;

namespace Zoo_Project.Data
{
    public class FoodRepository : IFoodRepository
    {
        private readonly List<Foods> _foods;
        public FoodRepository()
        {
            _foods = new List<Foods>()
            {
                new Foods() {Id=1,Name="Et Bonfile",Amount=350},
                new Foods() {Id=2,Name="Et Kaburga",Amount=480},
                new Foods() {Id=3,Name="Sakatat",Amount=225},
                new Foods() {Id=4,Name="Somon",Amount=118},
                new Foods() {Id=5,Name="Havyar (Balık Yumurtası)",Amount=85},
                new Foods() {Id=6,Name="Marul",Amount=150},
                new Foods() {Id=7,Name="Özel Plankton Çözelti",Amount=255},
                new Foods() {Id=8,Name="Özel Karışım Köpek Maması",Amount=325},
                new Foods() {Id=9,Name="Fındık",Amount=325},
                new Foods() {Id=10,Name="Tahıllar Karışımı",Amount=750},
            };
        }


        public void Add(Foods food)
        {
            _foods.Add(food);
        }

        public void Delete(int id)
        {
            Foods? food = _foods.Where(x => x.Id == id).FirstOrDefault();
            if(food is null)
            {
                throw new FoodNotFoundException(id);
            }
            _foods.Remove(food);
        }

        public List<Foods> GetAll()
        {
            return _foods.ToList();
        }

        public Foods? GetByID(int id)
        {
            Foods? food = _foods.Where(x => x.Id == id).FirstOrDefault();
            if (food is null)
            {
                throw new FoodNotFoundException(id);
            }
            return food;
        }
    }
}

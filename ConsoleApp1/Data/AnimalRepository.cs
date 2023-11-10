using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Exceptions;
using Zoo_Project.Models;

namespace Zoo_Project.Data
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly List<Animals> _animals;
        public AnimalRepository()
        {
            var _foodRep=new FoodRepository();
            List<Foods> animalFoods = _foodRep.GetAll();
            _animals = new List<Animals>()
            {
                new Animals()
                {
                Id=1,Name="Aslan",
                Description="Büyük, güçlü ve etobur bir yırtıcı hayvan.",
                Type="Memeli",
                Genus="Panthera leo",
                KeeperID=2,
                FoodSeries=new List<Foods>(){animalFoods[0],animalFoods[1]}
                },                
                new Animals()
                {
                Id=2,Name="Kartal",
                Description="Büyük, keskin bakışlı ve yüksek uçan bir kuş.",
                Type="Kuş",
                Genus="Aquila",
                KeeperID=1,
                FoodSeries=new List<Foods>(){animalFoods[0],animalFoods[1],animalFoods[2]}
                },                
                new Animals()
                {
                Id=3,Name="Denizanası",
                Description="Şeffaf, jelatinimsi bir yapıya sahip, denizde yüzen bir organizma.",
                Type="Omurgasız",
                Genus="Medusea",
                KeeperID=2,
                FoodSeries=new List<Foods>(){animalFoods[6]}
                },                
                new Animals()
                {
                Id=4,Name="Kaplan",
                Description="Büyük, güçlü ve çoğunlukla ormanlarda yaşayan bir kedi türü.",
                Type="Memeli",
                Genus="Panthera tigris",
                KeeperID=3,
                FoodSeries=new List<Foods>(){ animalFoods[0], animalFoods[1], animalFoods[2] }
                },                
                new Animals()
                {
                Id=5,Name="Kaplumbağa",
                Description="Sert bir kabuğa sahip, kara ve su habitatlarında yaşayan bir hayvan.",
                Type="Sürüngen",
                Genus="Testudines",
                KeeperID=5,
                FoodSeries=new List<Foods>(){animalFoods[5],animalFoods[9]}
                },                
                new Animals()
                {
                Id=6,Name="Köpek",
                Description="Sadık, evcil bir hayvan ve insanların en yakın dostlarından biri.",
                Type="Memeli",
                Genus="Canis lupus familiaris",
                KeeperID=6,
                FoodSeries=new List<Foods>(){ animalFoods[0], animalFoods[1], animalFoods[2], animalFoods[7], animalFoods[3] }
                }
            };
        }

        public void Add(Animals animal)
        {
            _animals.Add(animal);
        }

        public void Delete(int id)
        {
            Animals? animal=_animals.Where(x=>x.Id==id).FirstOrDefault();
            if(animal is null)
            {
                throw new AnimalNotFoundException(id);
            }
            _animals.Remove(animal);
        }

        public List<Animals> GetAll()
        {
            return _animals;
        }

        public Animals? GetByID(int id)
        {
            Animals? animal = _animals.Where(x => x.Id == id).FirstOrDefault();
            if (animal is null)
            {
                throw new AnimalNotFoundException(id);
            }
            return animal;
        }
    }
}

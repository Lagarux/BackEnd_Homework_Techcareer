using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Data;
using Zoo_Project.Exceptions;
using Zoo_Project.Models;

namespace Zoo_Project.Business
{
    public class AnimalService : IAnimalServices
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimalService(IAnimalRepository IAR)
        {
            _animalRepository = IAR;
        }

        public void Add(Animals animal)
        {
            try
            {
                checkOut(animal);
                _animalRepository.Add(animal);
                GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        public void GetAll()
        {
            List<Animals> animals = _animalRepository.GetAll();
            animals.ForEach(animal => Console.WriteLine(animal));
        }

        public void GetById(int id)
        {
            try
            {
                Animals? animal=_animalRepository.GetByID(id);
                Console.WriteLine(animal);
            }
            catch (AnimalNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Remove(int id)
        {
            try
            {
                _animalRepository.Delete(id);
            }
            catch (AnimalNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        
        
        private void checkOut(Animals animal)
        {
            if (animal.Name.Length < 2)
            {
                throw new AnimalNameException(animal.Name);
            }
        }
    }
}

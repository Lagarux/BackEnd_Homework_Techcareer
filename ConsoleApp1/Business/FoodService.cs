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
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepository;
        public FoodService(IFoodRepository IFR)
        {
            _foodRepository = IFR;
        }

        public void Add(Foods food)
        {
            try
            {
                checkOut(food);
                _foodRepository.Add(food);
                GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        public void GetAll()
        {
           List<Foods> foods = _foodRepository.GetAll();
           foods.ForEach(x=>Console.WriteLine(x)); 
        }

        public void GetByID(int id)
        {
            try
            {
                Foods food=_foodRepository.GetByID(id);
                Console.WriteLine(food);
            }
            catch (FoodNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        
        
        private void checkOut(Foods food)
        {
            if (food.Amount < 0)
            {
                throw new NegativeValueException(food.Amount);
            }
        }
    }
}

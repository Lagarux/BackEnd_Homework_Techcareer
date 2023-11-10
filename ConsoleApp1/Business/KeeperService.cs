using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Project.Data;
using Zoo_Project.Exceptions;
using Zoo_Project.Models;

namespace Zoo_Project.Business
{
    public class KeeperService : IKeeperService
    {
        private readonly IKeeperRepository _keeperRepository;
        public KeeperService(IKeeperRepository IKR)
        {
            _keeperRepository = IKR;
        }

        public void Add(Keepers keeper)
        {
            try
            {
                checkOut(keeper);
                _keeperRepository.Add(keeper);
                GetList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        public void Delete(int id)
        {
            try
            {
                _keeperRepository.Delete(id);
            }
            catch (KeeperNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetById(int id)
        {
            try
            {
                Keepers? keeper = _keeperRepository.GetByID(id);
                Console.WriteLine(keeper);
            }
            catch (KeeperNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetList()
        {
            List<Keepers> keepers = _keeperRepository.GetAll();
            keepers.ForEach(keep =>  Console.WriteLine(keep) );
        }        
        
        private void checkOut(Keepers keeper)
        {
            if(keeper.Age < 0)
            {
                throw new NegativeValueException(keeper.Age);
            }

            if(keeper.Name.Length < 2)
            {
                throw new KeeperNameException(keeper.Name);
            }
        }
    }
}

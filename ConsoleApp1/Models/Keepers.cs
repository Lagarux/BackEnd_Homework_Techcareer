using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project.Models
{
    public class Keepers : EntityBase<int>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public int ShiftID { get; set; }

        public override string ToString()
        {
            return $"Bakıcı ID : {Id} \n Adı : {Name} \n Yaş : {Age} \n Telefon Numarası : {PhoneNumber} \n Vardiya ID: {ShiftID} \n";
        }
    }
}

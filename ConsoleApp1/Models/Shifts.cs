using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project.Models
{
    public class Shifts : EntityBase<int>
    {
        public string? Type { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }

        public override string ToString()
        {
            return  $"Vardiya ID : {Id} \n Vardiya Türü : {Type} \n Başlangıç Saati : {startTime} \n Bitiş Saati : {endTime}";
        }
    }
}

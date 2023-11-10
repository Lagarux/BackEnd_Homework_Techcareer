using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project.Models
{
    public class Foods : EntityBase<int>
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"Yiyecek Adı : {Name} \n Total Miktarı : {Amount} \n";
        }
    }
}

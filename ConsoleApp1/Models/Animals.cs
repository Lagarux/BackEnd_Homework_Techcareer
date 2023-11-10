using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project.Models
{
    public class Animals : EntityBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Genus { get; set; }
        public int KeeperID { get; set; }
        public List<Foods> FoodSeries { get; set; }

        public override string ToString()
        {
            string res = $"Hayvan ID : {Id} \n Adı : {Name} \n Açıklama : {Description} \n Türü : {Type} \n Cinsi : {Genus} \n Besin Öğeleri : ";
            string resCon = "";
            foreach (Foods food in FoodSeries)
            {
                resCon += $" | {food.Name} | " ; 
            }
            resCon += "\n\n";
            
            return string.Concat(res, resCon);
        }
    }
}

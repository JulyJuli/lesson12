using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
   public class Bouqet
    {
        public Bouqet()
        {
            NewBouqet = new List<Flowers>();
        }

        public void AddFlower(Flowers flower)
        {
            NewBouqet.Add(flower);
        }

        public List<Flowers> NewBouqet { get; set; }
        public double CostOfBouquet(List<Flowers> bouquet)
        {
            double costOfBouquet = 0;
            for (int i = 0; i < bouquet.Count; i++)
            {
                costOfBouquet += bouquet[i].Price;
            }
            return costOfBouquet;
        }
    }
}

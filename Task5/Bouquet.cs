using System.Collections.Generic;
using System.Linq;
using Task5.Interfaces;

namespace Task5
{
    public class Bouquet
    {
        private List<IFlower> CustomBouquet { get; set; }
        private string CustomerName { get; set; }


        public Bouquet(string customerName)
        {
            CustomerName = customerName;
            CustomBouquet = new List<IFlower>();
        }


        public void AddRange(params IFlower[] flower)
        {
            CustomBouquet.AddRange(flower);
        }
        public string GetInfo()
        {
            string result = string.Empty;

            result += $"Bouquet customer: {CustomerName}\n";
            result += $"Total flowers: {CustomBouquet.Count}.\n";
            result += $"Bouquet contains:\n";
            CustomBouquet.GroupBy(flower => flower.GetFlowerSort()).ToList().ForEach(group => result += ($" {group.Count()} pcs of {group.Key.ToLower()} flower;\n"));
            result += $"Final price: {CustomBouquet.Sum(flower => flower.GetPrice())} $.";

            return result;
        }
    }
}


namespace Task5
{
    public abstract class Flower
    {
        //Необходимо реализовать иерархию цветов (розы, гвоздики, тюльпаны).
        //Создать несколько объектов-цветов. Собрать букет с определением его стоимости. В букет может входить несколько цветов
        //одного типа.

        public abstract string FlowerName { get; }
        public  abstract decimal FlowerCost { get; set; }

        public Flower(decimal price)
        {
            FlowerCost = price;
        }

        public Flower()
        {

        }
        public Flower(int count=1)
        {
            Count = count;
        }

        public int Count { get; set; }
        public override string ToString()
        {
            return $"{FlowerName} costs {FlowerCost}";
        }
    }
}

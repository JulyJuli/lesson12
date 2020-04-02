namespace Task1
{
    public class Point
    {
        //Дан класс Равнобедренная трапеция, члены класса: координаты 4-х точек. 
        //В функции main продемонстрировать работу с классом:
        //дано N трапеций, найти количество трапеций, у которых площадь больше средней площади.        
        private int _x;
        private int _y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get => _x;
            set
            {
                if (value > 0)
                    _x = value;
            }
        }
        public int Y
        {
            get => _y;
            set
            {
                if (value > 0)
                    _y = value;
            }
        }


    }
}

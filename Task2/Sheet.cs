using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    public class Sheet : IEnumerable
    {
        private List<Circle> Circles { get; set; }


        public Sheet()
        {
            Circles = new List<Circle>();
        }


        public Circle this[int index]
        {
            get => Circles[index];
            set => Circles[index] = value;
        }


        public void AddCircles(params Circle[] circles)
        {
            Circles.AddRange(circles);
        }

        public int IndexOf(Circle circle)
        {
            return Circles.IndexOf(circle);
        }

        public string AreasCompare(Circle circle1, Circle circle2)
        {
            string res = $"Areas of the circles with R{circle1.Radius} and R{circle2.Radius}: ";
            res += (circle1.GetArea() == circle2.GetArea()) ? "circles have the equal area." : "circles have the different areas.";
            return res;
        }

        public IEnumerator GetEnumerator()
        {
            return Circles.GetEnumerator();
        }
    }
}

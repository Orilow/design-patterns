using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Visitor_Homework.Shapes;

namespace DesignPatterns.Visitor_Homework.Visitors
{
    class AreaVisitor : IVisitor
    {
        public void VisitCircle(Circle circle)
        {
            Console.WriteLine($"Площадь круга: {Math.PI * Math.Pow(circle.Radius, 2)}");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine($"Площадь прямоугольника: {rectangle.SideALength * rectangle.SideBLength}");
        }

        public void VisitTriangle(Triangle triangle)
        {
            var p = (triangle.CathetA + triangle.CathetB + triangle.Hypotenuse) / 2;
            var s = Math.Sqrt(p * (p - triangle.CathetA) * (p - triangle.CathetB) * (p - triangle.Hypotenuse));
            Console.WriteLine($"Площадь прямоугольника: {s}");
        }
    }
}

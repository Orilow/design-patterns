using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Visitor_Homework.Shapes;

namespace DesignPatterns.Visitor_Homework.Visitors
{
    class PerimeterVisitor : IVisitor
    {
        public void VisitCircle(Circle circle)
        {
            Console.WriteLine($"Периметр круга: {2 * Math.PI * circle.Radius}");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine($"Периметр прямоугольника: {(rectangle.SideALength + rectangle.SideBLength) * 2}");
        }

        public void VisitTriangle(Triangle triangle)
        {
            Console.WriteLine($"Периметр треугольника: {triangle.CathetB + triangle.CathetA + triangle.Hypotenuse}");
        }
    }
}

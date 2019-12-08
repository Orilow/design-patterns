using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Visitor_Homework.Shapes;

namespace DesignPatterns.Visitor_Homework.Visitors
{
    class DrawVisitor : IVisitor
    {
        public void VisitCircle(Circle circle)
        {
            Console.WriteLine("Рисуем круг...");
        }

        public void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine("Рисуем Прямоугольник...");
        }

        public void VisitTriangle(Triangle triangle)
        {
            Console.WriteLine("Рисуем квадрат...");
        }
    }
}

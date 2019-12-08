using DesignPatterns.Visitor_Homework.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor_Homework.Visitors
{
    interface IVisitor
    {
        void VisitRectangle(Rectangle rectangle);
        void VisitTriangle(Triangle triangle);
        void VisitCircle(Circle circle);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Visitor_Homework.Visitors;

namespace DesignPatterns.Visitor_Homework.Shapes
{
    class Circle : Shape
    {
        public int Radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitCircle(this);
        }
    }
}

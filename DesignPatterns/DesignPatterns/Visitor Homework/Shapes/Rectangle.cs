using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Visitor_Homework.Visitors;

namespace DesignPatterns.Visitor_Homework.Shapes
{
    class Rectangle : Shape
    {
        public int SideALength;
        public int SideBLength;

        public Rectangle(int a, int b)
        {
            SideALength = a;
            SideBLength = b;
        }   

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRectangle(this);
        }
    }
}

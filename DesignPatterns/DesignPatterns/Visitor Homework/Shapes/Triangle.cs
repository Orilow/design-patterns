using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Visitor_Homework.Visitors;

namespace DesignPatterns.Visitor_Homework.Shapes
{
    class Triangle : Shape
    {
        public int CathetA;
        public int CathetB;
        public int Hypotenuse;

        public Triangle(int a, int b, int c)
        {
            CathetA = a;
            CathetB = b;
            Hypotenuse = c;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitTriangle(this);
        }
    }
}

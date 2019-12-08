using DesignPatterns.Visitor_Homework.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor_Homework.Shapes
{
    abstract class Shape
    {
        public abstract void Accept(IVisitor visitor);
    }
}

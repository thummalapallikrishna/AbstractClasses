using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InheritanceDemo.AbstractClass;

namespace InheritanceDemo
{
    public class Circle : Shape, ICircle
    {

        public override void Draw()

        {

            Console.WriteLine("Draw a circle");

        }

    }

}
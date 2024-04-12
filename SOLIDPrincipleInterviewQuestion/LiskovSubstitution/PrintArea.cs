using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleInterviewQuestion.LiskovSubstitution
{
    public static class PrintArea
    {
        public static void PrintShapeArea(Shape shape)
        {
            Console.WriteLine($"Area: {shape.Area()}");
        }
    }
}

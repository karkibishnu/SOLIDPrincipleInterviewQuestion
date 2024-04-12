using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleInterviewQuestion.LiskovSubstitution
{
    public class LiskovSquare : Shape
    {
        public double Side { get; set; }
        public LiskovSquare(double side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleInterviewQuestion.OpenClose
{
    public static class AreaCalculator
    {
        //Polymorphic Behavior:
        //The GetTotalArea method now accepts an array of shape objects, which can include
        //any concrete subclass of the shape class.
        //Inside the GetTotalArea method, polymorphism is used: the Area() method of each
        //shape object is called without needing to know the specific type of shape.

        //The GetTotalArea method is now closed for modification because it doesn't need to
        //be modified when new shapes are introduced. Instead, it's open for extension because
        //it can accommodate any new shape that adheres to the shape interface by simply adding
        //a new concrete shape class.
        public static double GetTotalArea(shape[] shapes)
        {
            double totalArea = 0;
            foreach (shape shape in shapes)
            {
                totalArea += shape.Area();
            }

            return totalArea;
        }
    }
}

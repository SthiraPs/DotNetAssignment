using System;
using Xunit;

namespace DotNetAssignment.Classes
{
    public class TriangleClass
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public bool IsRightTriangle(TriangleClass triangle)
        {
            double a = Math.Pow(triangle.SideA, 2); //getting the square of the length
            double b = Math.Pow(triangle.SideB, 2);
            double c = Math.Pow(triangle.SideC, 2);

            if (a == 0 || b == 0 || c == 0) //at least one of the side is 0, it is not a triangle
            {
                return false;
            }
            else if (a + b == c || a + c == b || b + c == a) //check if the lenghts meet the Pythagorean theorem
            {
                return true;
            }
            
            return false;
        }
    }
}


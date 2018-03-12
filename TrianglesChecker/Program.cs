using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesChecker
{
    public enum TriangleTypes { Scalene, Isosceles, Equilateral, Error };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CheckTriangle: " + new Program().CheckTriangleType(2, 2, 2));
            Console.ReadKey();
        }

        public TriangleTypes CheckTriangleType(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || b + c <= a || a + c <= b)
                return TriangleTypes.Error;

            else if (a == b && b == c && c == a)
                return TriangleTypes.Equilateral;

            else if (a == b || b == c || c == a)
                return TriangleTypes.Isosceles;

            else if (a != b && b != c && a != c)
                return TriangleTypes.Scalene;

            else
                return TriangleTypes.Error;
        }
    }
}

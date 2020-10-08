using System;
using System.Security.Cryptography.X509Certificates;

namespace Triangle1
{
    public static class TriangleSolver
    {
        //checking the formation of triangle
        public static int TriangleCheck(int a, int b, int c)
        {
            if (a + b <= c || b + c <= a || a + c <= b)
            {
                //Console.WriteLine("The Triangle cannot be formed");
                 return 0;
            }
            else
            {
                //Console.WriteLine("The Triangle can be formed");
                return 1;
            }
        }
        public static bool Analyze(int a, int b, int c)
        {
                
            if (a == b && b == c)


            {
                Console.WriteLine("The triangle formed is an equilateral triangle");
                return true;
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("The Triangle formed is an Isosceles triangle");
                return true;
            }
            else
            { 
                Console.WriteLine("The triangle formed is a scalene triangle");
                return true;
            }

        }
        

        public static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter the lenghts of the sides");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int formed=TriangleSolver.TriangleCheck(a, b, c);
            if (formed == 0)
            {
                Console.WriteLine("Cannot form triangle");
            }
            else
            {
                TriangleSolver.Analyze(a, b, c);
            }


            
        }

        
    }
}

using System;

namespace TestRce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. číslo: ");
            string sA = Console.ReadLine();
            Console.Write("2. číslo: ");
            string sB = Console.ReadLine();
            Console.Write("3. číslo: ");
            string sC = Console.ReadLine();
            double a = Convert.ToDouble(sA);
            double b = Convert.ToDouble(sB);
            double c = Convert.ToDouble(sC);
            RceCalculator.FinalResault(a, b, c);
        }
    }
    public class RceCalculator
    {
        public static double Discriminant(double a, double b, double c)
        {
            return b*b-4.0*a*c;
        }
        public static double CalculatorPlus(double a, double b, double discriminant)
        {
            return (-b + Math.Sqrt(discriminant))/2*a;
        }
        public static double CalculatorMinus(double a, double b, double discriminant)
        {
            return (-b - Math.Sqrt(discriminant)) / 2 * a;
        }
        public static void FinalResault(double a, double b, double c)
        {
            double discriminant = Discriminant(a, b, c);
            if (discriminant==0)
            {
                Console.WriteLine("x: " + CalculatorPlus(a,b,discriminant));
            }
            else if (discriminant>0)
            {
                Console.WriteLine("x1: " + CalculatorPlus(a, b, discriminant) + " x2: " + CalculatorMinus(a, b, discriminant));
            }
            else
            {
                Console.WriteLine("Nejde");
            }
        }
    }
}

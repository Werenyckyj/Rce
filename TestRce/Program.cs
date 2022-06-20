using System;

namespace TestRce
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0;
            while (true)
            {
                Console.Write("1. číslo: ");
                string sA = Console.ReadLine();
                try
                {
                    a = Convert.ToDouble(sA);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Tak tohle ne!!!");
                }
            }
            double b = 0.0;
            while (true)
            {
                Console.Write("2. číslo: ");
                string sB = Console.ReadLine();
                try
                {
                    b = Convert.ToDouble(sB);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Tak tohle ne!!!");
                }
            }
            double c = 0.0;
            while (true)
            {
                Console.Write("3. číslo: ");
                string sC = Console.ReadLine();
                try
                {
                    c = Convert.ToDouble(sC);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Tak tohle ne!!!");
                }
            }
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

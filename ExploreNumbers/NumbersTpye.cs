using System;

namespace NumbersType
{
    class Numbers{
        public static void IntegerMath()
        {
            int a = 10;
            int b = 5;
            int c = 2;
            Console.WriteLine("\n------Operations On Integers-----\n");
            Console.WriteLine("\n||    Here a=10 , b=5 , c=2   ||");
            Console.WriteLine("\na+b : "+(a+b));
            Console.WriteLine("\na-b : "+(a-b));
            Console.WriteLine("\na*b : "+(a*b));
            Console.WriteLine("\na/b : "+(a/b));
            Console.WriteLine("\n------Explore order of operations------\n");
            Console.WriteLine("\na + b * c : "+(a + b * c));
            Console.WriteLine("\n(a + b) * c : "+((a + b)* c));
            Console.WriteLine("\n(a + b) - 6 * c + (12 * 4) / 3 + 12 : "+((a + b) - 6 * c + (12 * 4) / 3 + 12));
            Console.WriteLine("\n(a + b) / c : "+((a + b) / c));
            Console.WriteLine("\n------Explore integer precision and limits------\n");
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"\nFor quotient of d = (a + b) / c : {d}");
            Console.WriteLine($"\nFor remainder of e = (a + b) % c : {e}");
            Console.WriteLine($"\nThe range of integers is {int.MinValue} to {int.MaxValue}");
            int max=int.MaxValue;
            int what =  max+3;
            Console.WriteLine($"\nAn example of overflow: {what}");
        }

        public static void DoubleMath()
        {
            double a = 15;
            double b = 24;
            double c = 4;
            Console.WriteLine("\n------Work with the double type------");
             Console.WriteLine("\n||    Here a=15 , b=24 , c=4   ||");
            Console.WriteLine("\n(a + b) / c : "+((a + b) / c));
            Console.WriteLine($"\nThe range of double is {double.MinValue} to {double.MaxValue}");
            Console.WriteLine("\n1.0 / 3.0 : "+ (1.0 / 3.0));
        }

        public static void DecimalType()
        {
            Console.WriteLine("\n-------Work with decimal types-----");
            Console.WriteLine($"The range of the decimal type is {decimal.MinValue} to {decimal.MaxValue}"); 
            Console.WriteLine("\nDifference of precision between decimal and double: ");
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine("\nDouble 1.0 / 3.0  : "+(a / b));
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine("\nDecimal 1.0M / 3.0M  : "+(c / d));
        }

        public static void findAreaOfCircle()
        {
            double radius = 14.2;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"\nArea of circle where radius({radius}) = {area}");
        }
    }
} 
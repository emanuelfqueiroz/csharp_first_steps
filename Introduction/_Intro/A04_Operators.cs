using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Introduction._Intro
{
    public class A04_Operators
    {
        internal static void Load()
        {
            var l = new List<Action> {
                Division,
                Division02,
                DivisionAndReminder,
                DivisionDecimal,
                DivisionDecimal02,
                DivisionDecima03_Precision
            };
            l.ForEach(a => {
                Console.WriteLine("\n\n" + a.Method.Name + "\n---------------------");
                a();
            });
        }

        /// <summary>
        /// OPERATOR SUM
        /// 4 + 4
        /// </summary>
        private static void Sample01()
        {
            var sum = 10 + 10;
            Console.WriteLine(10 + 10);
            Console.WriteLine(sum);
            
        }
        /// <summary>
        /// type int
        /// 4 + 4
        /// </summary>
        private static void Sample02()
        {
            int sum = 10 + 10;
            Console.WriteLine(10 + 10);
            Console.WriteLine(sum);

        }

        /// <summary>
        /// Changing the order of addends does not change the sum.
        /// </summary>
        private static void Sum02()
        {
            int p = 10;
            int q = 10;

            int sum = p + q;
            //Console.WriteLine(sum);
            Console.WriteLine($"{p}");
            Console.WriteLine($"{q}");
            Console.WriteLine($"-----");
            Console.WriteLine($"{sum}");
            Console.WriteLine($"{p+q}");
        }
        /// <summary>
        /// Show 3 variables
        /// </summary>
        private static void Sum03()
        {
            int p = 10;
            int q = 10;
            int r = 10;
            int sum = p + q + r;
            //Console.WriteLine(sum);
            Console.WriteLine($"{p}");
            Console.WriteLine($"{q}");
            Console.WriteLine($"{r}");
            Console.WriteLine($"-----");
            Console.WriteLine($"{sum}");
        }

        /// <summary>
        /// 1) Showing +=
        /// 2) Try Substract
        /// </summary>
        private static void Sum04()
        {
            int p = 10;
            Console.WriteLine($"{p}");

            int q = 10;
            Console.WriteLine($"{q}");
            Console.WriteLine($"-----");
            Console.WriteLine($"{p}");
            p += q;
            
            Console.WriteLine($"{p}");
        }
        /// <summary>
        /// Use \t
        /// </summary>
        private static void Product01()
        {
            int p = 10;
            int q = 5;
            int prod = p * q;

            Console.WriteLine($"Prod Sample");
            Console.ResetColor();
            Console.WriteLine($"\t{p}");
            Console.WriteLine($"\t{q}");
            Console.WriteLine($"-----------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t{prod}");
            Console.ResetColor();
        }
        /// <summary>
        /// Use \t
        /// </summary>
        private static void Product02()
        {
            int p = 10;
            int q = 10;
            int r = 10;
            int prod = p * q * r;

            Console.WriteLine($"Sum Sample");
            Console.WriteLine($"\t{p}");
            Console.WriteLine($"\t{q}");
            Console.WriteLine($"\t{r}");
            Console.WriteLine($"-----------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t{prod}");
            Console.ResetColor();
        }

        public static void Sample()
        {
            int a = 5;
            int b = 2;
            int c = 4;
            Console.WriteLine(a + b * c + a);
            //Improving Console
            
            Console.WriteLine($"{a} + {b} * {c} + {a}:   { a + b * c + a}");

        }

        private static void Division()
        {
            int divisor = 100;
            int dividend = 4;
            int quotient = divisor / dividend;

            Console.WriteLine($"Division {divisor} / {dividend}");
            Console.WriteLine($"Quotient: {quotient}");
        }
        private static void Division02()
        {
            int divisor = 100;
            int dividend = 6;
            int quotient = divisor / dividend;

            Console.WriteLine($"Division {divisor} / {dividend}");
            Console.WriteLine($"Quotient: {quotient}");
        }
        private static void DivisionAndReminder()
        {
            int divisor = 100;
            int dividend = 3;
            int quotient = divisor / dividend;
            int reminder = divisor % dividend;

            Console.WriteLine($"Division {divisor} / {dividend}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"reminder: {reminder}");
            
        }

        private static void DivisionDecimal()
        {
            decimal divisor = 100;
            decimal dividend = 3;
            decimal quotient = divisor / dividend;
           

            Console.WriteLine($"Division {divisor} / {dividend}");
            Console.WriteLine($"Quotient: {quotient}");
        }

        /// <summary>
        /// Suffix M
        /// </summary>
        private static void DivisionDecimal02()
        {
            decimal divisor = 100.32m;
            decimal dividend = 3.4m;
            decimal quotient = divisor / dividend;


            Console.WriteLine($"Division {divisor} / {dividend}");
            Console.WriteLine($"Quotient: {quotient}");
        }

        /// <summary>
        /// Suffix M
        /// </summary>
        private static void DivisionDecima03_Precision()
        {
            decimal divisor = 100.32m;
            decimal dividend = 3.4m;
            decimal quotient = divisor / dividend;


            Console.WriteLine($"Division {divisor} / {dividend}");
            Console.WriteLine($"Quotient: {quotient.ToString("0.##")}");
        }

        
    }
}

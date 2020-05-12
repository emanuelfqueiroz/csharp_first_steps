using System;
using System.Collections.Generic;
using System.Text;

namespace Introduction._Intro
{
    public class A01
    {
        private static void A01_Load()
        {
            A01.Sample01();
            A01.Sample02();
            A01.Sample03();
            A01.Sample04();
            A01.Bonus04_Object();
            A01.Bonus03_List();
        }

        public static void Sample01()
        {
            Console.WriteLine("Hello " + "John" + "!");

            var name = "John";
            Console.WriteLine("Hello " + name + "!");
        }
        public static void Sample02()
        {
            var greeting = "Good morning";
            var name = "John";

            Console.WriteLine(greeting + " " + name + "!");
        }
        /// <summary>
        /// Write vs WrileLine
        /// </summary>
       
        public static void Sample03()
        {
            var name = "John";
            var greeting = "Good morning";

            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"{greeting} {name}!");
        }
        public static void Sample04()
        {
            var name = "John";
            var greeting = "Good morning";

            Console.WriteLine("Hello {0}!", "John");
            Console.WriteLine("{0} {1}!", "Good Morning", "John");

            Console.WriteLine("Hello {0}!", name);
            Console.WriteLine("{0} {1}!", greeting, name);
        }
        public static void Bonus01_Write()
        {
            var greeting = "Good morning";
            var name = "John";

            Console.Write(greeting);
            Console.Write(" ");
            Console.Write(name + "!");
            Console.WriteLine("-----------");
        }
        /// <summary>
        /// Escape Sequence \n
        /// </summary>
        public static void Bonus02_NewLine()
        {
            var name = "John";

            Console.Write($"Hi {name}, \nHow are you?");
        }
        public static void Bonus03_List()
        {
            var wedding = new[] { "Ana", "John" };
            Console.WriteLine("Wedding: {0} & {1}", wedding);
        }
        public static void Bonus04_Object()
        {
            var context = new { Name = "John", Greeting = "Good morning" };

            Console.WriteLine($"{context.Greeting} {context.Name}!");
            Console.WriteLine("{0} {1}!", context.Greeting, context.Name);
        }
    }
}

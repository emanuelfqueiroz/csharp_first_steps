using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Introduction._Intro
{
    class A02_ReadLine
    {
        internal static void Load()
        {
            Sample02();
        }

        private static void Sample01()
        {
            Console.WriteLine("What's your name:");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
            Console.Read();
            
        }
        private static void Sample02()
        {
            Console.WriteLine("What's your first name:");
            var firstName = Console.ReadLine();
            
            Console.Clear();
            
            Console.WriteLine("What's your last name:");
            var lastName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Hello {firstName} {lastName}!");
            Console.Read();
        }

       
    }
}

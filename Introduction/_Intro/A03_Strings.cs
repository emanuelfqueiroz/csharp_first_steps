using System;
using System.Collections.Generic;
using System.Text;

namespace Introduction._Intro
{
    /// <summary>
    /// Documentation
    /// <see cref="https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/strings/"/>
    /// </summary>
    class A03_Strings
    {
        /// <summary>
        /// string type
        /// </summary>

        public static void Sample_NoValue()
        {
            string name = null; //No value for String
            Console.WriteLine($"The value of name is: {name}. \nThere is no value. Its Empty");
        }
        public static void Bonus_Empty()
        {
            string name = String.Empty; //No value for String
            Console.WriteLine($"You can define empty value using 'String.Empty'.");
        }

        public static void Sample()
        {
            string quote = "The unexamined life is not worth living";
            string author = "Socrates";
            Console.Write($"{quote} - {author}");
        }
        /// <summary>
        /// If you need write double quotes:
        /// I think therefore I am” (“Cogito, ergo sum”) - René Descartes
        /// </summary>
        public static void Double_Quotes()
        {
            //Use \"
            string text = "I think therefore I am\" (\"Cogito, ergo sum\") - René Descartes";
            Console.WriteLine(text);
        }
        internal static void Load()
        {
            string helloWorld = "Hello" + "World";
            Console.WriteLine(helloWorld);
            //Copying
            string var1 = "Hello ";
            string var2 = var1;

            Console.WriteLine($"var1: {var1} \nvar2: {var2}");

            var1 = var1 + "World";
            Console.WriteLine($"var1 = var1 + \"World\": {var1}");

            string var3 = "Concat strings using += ";
            var3 += "World!";
            Console.WriteLine($"var3 : {var3} ");
        }

        private static void BonusSamples()
        {
            string columns = "Column 1\tColumn 2\tColumn 3";
            //Output: Column 1        Column 2        Column 3
            Console.WriteLine(columns);
            string rows = "Row 1\r\nRow 2\r\nRow 3";
            Console.WriteLine(rows);
            /* Output:
              Row 1
              Row 2
              Row 3
            */
            string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
            Console.WriteLine(title);
            //Output: "The Æolean Harp", by Samuel Taylor Coleridge
        }
        
        /// <summary>
        /// Symbol @
        /// </summary>
        private static void LargeStrings()
        {
            string text = @"C# (pronounced see sharp, like the musical note C♯, but written with the number sign)[b] is a general-purpose, multi-paradigm programming language encompassing strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines.[16] It was developed around 2000 by Microsoft as part of its .NET initiative, and later approved as an international standard by Ecma (ECMA-334) and ISO (ISO/IEC 23270:2018). Mono is the name of the free and open-source project to develop a compiler and runtime for the language. C# is one of the programming languages designed for the Common Language Infrastructure (CLI)";
            Console.Write(text);
        }
        /// <summary>
        /// Symbols: $@ 
        /// </summary>
        private static void LargeStrings2()
        {
            var cli = "Common Language Infrastructure(CLI)";
            var details = "(pronounced see sharp, like the musical note C♯, but written with the number sign);";

            string text = $@"C# {details} is a general-purpose, multi-paradigm programming language encompassing strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines.[16] It was developed around 2000 by Microsoft as part of its .NET initiative, and later approved as an international standard by Ecma (ECMA-334) and ISO (ISO/IEC 23270:2018). Mono is the name of the free and open-source project to develop a compiler and runtime for the language. C# is one of the programming languages designed for the {cli}";
            Console.Write(text);
        }
        private static void MultipleLines_optional()
        {
            string text = @"You can discover more about a person
                 in an hour of play than in a year of conversation
                - Plato";
            Console.Write(text);
        }
        public static void MultipleLines_optional2()
        {
            string r = "\r"; //return scape
            string author = "Plano";
            string text = $@"You can discover more about a person 
                           {"\r"}in an hour of play than in a year of conversation
                           {r}- {author}";
            Console.Write(text);
        }

        private static void EasyWay()
        {
            // Represent a Path 
            // c:\Program Files\Microsoft Visual Studio 8.0\
            string bars = @"c:\Program Files\Microsoft Visual Studio 8.0\";
            Console.WriteLine(bars);
        }

        private static void Path()
        {
            // Represent a Path 
            // c:\Program Files\Microsoft Visual Studio 8.0\
            string bars = "c:\\Program Files\\Microsoft Visual Studio 8.0\\";
            Console.WriteLine(bars);
        }
    }
}

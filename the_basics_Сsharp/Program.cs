using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_basics_Сsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constant and variables
            const string MyName = "Jack";
            string MyMidleName;
            
            MyMidleName = "Dolan";

            Console.Write($"{MyName} \n");
            Console.Write($"{MyMidleName}");

            //Literals

            Console.WriteLine("\t Привет, мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n Jane");

            //Task 1

            Console.WriteLine("Привет,\n мир");

            //Task 2

            Console.WriteLine('\u0040');
            Console.WriteLine('\x23');

            //Task 3

            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.ReadKey();
        }
    }
}

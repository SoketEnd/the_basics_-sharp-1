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
            int age = 27;
            bool pet = true;
            double size = 37.5;

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

            //Task in Modul two

            Console.WriteLine($"My name is {MyName}");
            Console.WriteLine($"My age is {age}");
            Console.WriteLine($"Du i have a pet ? {pet}");
            Console.WriteLine($"My shoe size is {size}");

            //Task in Modul 3

            DayOfWeek MyfavitDay;
            MyfavitDay = DayOfWeek.Friday;
            Console.WriteLine(MyfavitDay);

            //Task 4

            colorTrafficLight Color;
            Color = colorTrafficLight.Green;
            Console.WriteLine(Color);

            //Tasl 5

            double result = 5 / 2 * 3;
            Console.WriteLine(result);

            //task 6 Анкета 

            (string name, int age, string bursday)User;

            Console.WriteLine("Введите ваше Имя: ");
            User.name = Console.ReadLine();
            Console.WriteLine("Введите ваш возрост: ");
            User.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вашу дату рождения: ");
            User.bursday = Console.ReadLine();

            Console.WriteLine($"Здравствуйте {User.name}");
            Console.WriteLine($"Ваш возрост {User.age}");
            Console.WriteLine($"Дата вашего рождения {User.bursday}");

            Console.ReadKey();
        }
    }
}
enum DaysOfWeek : byte
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Trusday,
    Friday,
    Saturday,
    Sunday
}

enum colorTrafficLight: int
{
    Red = 100,
    Yellow = 200,
    Green = 300
}
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
//            Первая задача
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Добрый день, {name}");

//            Вторая задача
            Console.WriteLine("Введите первое число");
            string first = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string second = Console.ReadLine();
            string tree = second;
            second = first;
            Console.WriteLine($"Ранее вы вводили первым {tree}, а вторым {second}?");

//            Третья задача
            Console.WriteLine("Введите число, а я скажу сколько в нем чисел");
            string number = Console.ReadLine();
            Console.WriteLine($"В числе содержится {number.Length} чисел");

//            Четвертая задача
            Console.WriteLine("Введите длины трех сторон треугольника, через пробел");
            string arrayString = Console.ReadLine();
            string[] words = arrayString.Split(' ');
            Console.WriteLine(words[0]);
            Console.WriteLine(words[1]);
            Console.WriteLine(words[2]);
            double result = 0.5 * (Convert.ToInt32(words[0]) + Convert.ToInt32(words[1]) + Convert.ToInt32(words[2]));
            Console.WriteLine(result);
        }
    }
}
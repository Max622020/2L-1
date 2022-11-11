using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Лабораторна робота №2 на тему: <Введення-виведення iнформацiї, з використанням файлiв>");
            Console.WriteLine("");
            Console.WriteLine("Варiант №3");
            Console.WriteLine("");
            Console.WriteLine("Виконав:Харченко Максим Олександрович");
            Console.WriteLine("");
            Console.WriteLine("Група: ЕС-137Бстн");
            Console.WriteLine("");
            double a = 0.086;
            int c = -19;
            double i = 4.025;
            bool l = false;
            string patronymic = " Oleksandrovich ";
            Console.WriteLine(" patronymic = {0 }, l = {1 }", patronymic, l);
            Console.WriteLine(" a={0,6:f3} , c={1,4}, i={2,6:f3}", a, c, i );
            Console.WriteLine(" ");
            Console.WriteLine(" Для виходу натиснiть Enter");
            Console.ReadKey();
        }

    }
}
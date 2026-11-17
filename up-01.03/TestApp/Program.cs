using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static up_01._03.Class01;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var lib = new Class1();

                Console.WriteLine("=== Тестирование методов из MyLibrary.dll ===");
                Console.WriteLine();

                lib.SayHello("Иван");
                Console.WriteLine();

                lib.PrintMultiplicationTable(3);
                Console.WriteLine();

                int sum = lib.Add(15, 27);
                Console.WriteLine($"Add(15, 27) = {sum}");

                double area = lib.CircleArea(5.0);
                Console.WriteLine($"CircleArea(5.0) = {area:F2}");

                string fullName = lib.FormatFullName("Иванов", "Иван", "Иванович");
                Console.WriteLine($"FormatFullName(...) = {fullName}");

                Console.WriteLine();
                Console.WriteLine("Тестирование завершено успешно.");
                Console.ReadLine();
            }
        }
    }



}
    


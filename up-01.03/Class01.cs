using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_01._03
{
    public class Class01
    {
        public class Class1
    {
        // void 1
        public void SayHello(string name)
        {
            Console.WriteLine($"Привет, {name}! Это метод из DLL-библиотеки.");
        }

        // void 2
        public void PrintMultiplicationTable(int n)
        {
            Console.WriteLine($"Таблица умножения для {n}:");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
        }

        // int
        public int Add(int a, int b)
        {
            return a + b;
        }

        // double
        public double CircleArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным.");
            return Math.PI * radius * radius;
        }

        // string
        public string FormatFullName(string lastName, string firstName, string middleName)
        {
            return $"{lastName} {firstName[0]}. {middleName[0]}.";
        }
    }
    }
}

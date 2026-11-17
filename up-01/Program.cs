using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // ---- Задание 1: методы Add и Dev ----
                var calc = new Calculator();

                int sum = calc.Add(7, 5);              // public, int
                double quotient = calc.Divide(10, 4);  // double, через приватный Dev

                Console.WriteLine($"Add(7, 5) = {sum}");
                Console.WriteLine($"Dev(10, 4) = {quotient}");
                Console.WriteLine();

                // ---- Задание 2: класс User ----
                var user = new User
                {
                    Id = 1,
                    Login = "ivan_petrov",
                    Email = "ivan@example.com",
                    DisplayName = "Иван",
                    FirstName = "Иван",
                    LastName = "Петров",
                    Age = 27,
                    Role = "User",
                    Balance = 1500.50m
                };

                Console.WriteLine(user);

                Console.ReadLine(); // чтобы окно консоли не закрылось сразу
            }
        }
    }
    }


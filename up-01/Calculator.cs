using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_01
{
    public class Calculator
    {
        // Публичный метод, возвращает int
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Приватный метод, возвращает double
        private double Dev(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Делить на ноль нельзя.");
            return a / b;
        }

        // Публичная обёртка, чтобы показать работу приватного Dev
        public double Divide(double a, double b)
        {
            return Dev(a, b);
        }
    }
}


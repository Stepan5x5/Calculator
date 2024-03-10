using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, total;
            string action;
            Console.WriteLine("Вы открыли консольный калькулятор.");
            Console.WriteLine("Введите первое число:");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Выбери что ты хочешь сделать с этими числами, например: \n '*' - умножение \n '/' - деление \n '+' - сложение \n '-' - вычетание");
            action = Console.ReadLine();


            switch (action)
            {
                case "*":
                    total = number1 * number2;
                    Console.WriteLine(total); 
                    break;
                case "/":
                    total = number1 / number2;
                    Console.WriteLine(total);
                    break;
                case "+":
                    total = number1 + number2;
                    Console.WriteLine(total);
                    break;
                case "-":
                    total = number1 - number2;
                    Console.WriteLine(total);
                    break;
                default:
                    Console.WriteLine("Вы ввели недопустимый символ, попробуйте снова.");
                    break;
            }
            Console.ReadLine();
        }
    }
}

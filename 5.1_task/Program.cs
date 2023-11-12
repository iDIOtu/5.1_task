using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float prevInput = float.NaN;

            while (true)
            {
                Console.Write("Введите \"q\", чтобы выйти: ");
                string inputStr = Console.ReadLine();

                if (inputStr == "q")
                {
                    break;
                }
                if (int.TryParse(inputStr, out int inputInt))
                {
                    Console.WriteLine((char)inputInt);
                }
                else if (float.TryParse(inputStr, out float inputFloat))
                {
                    if (inputFloat == prevInput)
                    {
                        Console.WriteLine("Ввод равен предыдущему. Ввод завершается.");
                        break;
                    }
                    prevInput = inputFloat;
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                }
            }
        }
    }
}
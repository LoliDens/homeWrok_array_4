using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWrok_array_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandSum = "sum";

            int[] number = new int[0];
            string userInput;
            bool isExit = false;

            while (isExit == false) 
            {
                Console.WriteLine($"Введите числа для нахождения их суммы" +
                    $"\n{CommandSum} - для вывода суммы всех введенных чисел" +
                    $"\n{CommandExit} - для выхода из программы");
                userInput = Console.ReadLine();

                if (userInput == CommandExit)
                {
                    isExit = true;
                }
                else if (userInput == CommandSum)
                {
                    if (userInput.Length > 0)
                    {
                        int sum = 0;

                        for (int i = 0; i < number.Length; i++)
                        {
                            sum += number[i];
                        }

                        Console.WriteLine($"Сумма введеных чисел равна {sum}");
                    }
                    else
                    {
                        Console.WriteLine("Вы не ввели числа");
                    }
                }
                else 
                {
                    int[] arrayForIncrease = new int[number.Length + 1];

                    for (int i = 0; i < number.Length; i++) 
                    {
                        arrayForIncrease[i] = number[i];
                    }

                    arrayForIncrease[arrayForIncrease.Length - 1] = Convert.ToInt32(userInput);
                    number = arrayForIncrease;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

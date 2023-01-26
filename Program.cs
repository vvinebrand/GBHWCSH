using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr;
            Console.Write("Введите слова через пробел: ");
            string words = Console.ReadLine();
            arr = words.Split(' ');
            Console.WriteLine(" ");
            Console.Write("Ваш массив: ");
            foreach (var word in arr)
            {
                Console.Write($"[{word}] ");
            }
            var M = new string[arr.Length];
            var rSize = 0;
            foreach (var value in arr)
            {
                if (value.Length <= 3)
                {
                    M[rSize] = value;
                    rSize++;
                }
            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace лб6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Enter some text: ");
            string str = Console.ReadLine(); // Вводим строку
            string reversed = ""; // здесь будет наша перевернутая строка
            for (i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i]; // переворачиваем строку
            }
            Console.WriteLine("The result: ");
            Console.WriteLine(reversed);
            Console.ReadKey();
        }
    }
}

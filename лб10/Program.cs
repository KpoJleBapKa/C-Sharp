using System;
using System.Linq;
// Створити розширяючий метод для масиву цілих чисел, який спочатку виводить парні елементи, а потім непарні. 
namespace лб10
{
        public static class ArrayExtensions
        {
            public static void PrintEvenThenOdd(this int[] array)
            {
                var evenNumbers = array.Where(x => x % 2 == 0);
                var oddNumbers = array.Where(x => x % 2 != 0);

                foreach (var number in evenNumbers)
                {
                    Console.Write(number + " ");
                }

                foreach (var number in oddNumbers)
                {
                    Console.Write(number + " ");
                }
            }
        }

}

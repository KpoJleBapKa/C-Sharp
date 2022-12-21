using System;
using System.Collections.Generic;


//Створити ліст інтових змінних, який може містити тільки прості числа. Порахувати кількість повторень кожного простого числа. Скопіювати отриманий ліст в масив.
namespace лб7
{
    class Program {
        static void Main(string[] args) {
            List<int> list = new List<int>();

            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(7);
            list.Add(11);

            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int number in list)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            foreach (KeyValuePair<int, int> entry in counts)
            {
                Console.WriteLine("Number: " + entry.Key + ", Count: " + entry.Value);
            }

            int[] array = list.ToArray();

        }
    }
}

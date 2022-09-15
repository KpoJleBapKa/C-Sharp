using System;
//Перевірити істинність вислову: "Серед трьох даних цілих чисел є хоч би одна пара співпадаючих".
namespace лб3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;
            bool flag = false;
            do
            {
                Console.WriteLine("Введіть перше число: ");
                flag = int.TryParse(Console.ReadLine(), out first);
            } while (first <= 0 || !flag);
            flag = false;
            do
            {
                Console.WriteLine("Введіть друге число: ");
                flag = int.TryParse(Console.ReadLine(), out second);
            } while (second <= 0 || !flag);
            flag = false;
            do
            {
                Console.WriteLine("Введіть третє число: ");
                flag = int.TryParse(Console.ReadLine(), out third);
            } while (third <= 0 || !flag);

            if (first == second || second == third || third == first)
            {
                Console.WriteLine("Серед цих трьох цілих чисел є хоча б одна пара співпадаючих.");
            } else
            {
                Console.WriteLine("Серед цих трьох цілих чисел немає хоча б одної пара співпадаючих.");
            }
        }
    }
}

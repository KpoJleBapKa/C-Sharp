using System;
// Обчислення опору електричного ланцюга, що складається із двох паралельно з'єднаних резисторів
// R - опір. 1/R = 1/R_1 + 1/R_2
namespace лб1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                double R, R_1, R_2;
                bool flag = false;
                do
                {
                    Console.WriteLine("Введіть значення першого резистора: ");
                    flag = double.TryParse(Console.ReadLine(), out R_1);
                } while (R_1 <= 0 || !flag);
                flag = false;
                do
                {
                    Console.WriteLine("Введіть значення другого резистора: ");
                    flag = double.TryParse(Console.ReadLine(), out R_2);
                } while (R_2 <= 0 || !flag);
            
                R = (1 / R_1) + (1 / R_2);
                Console.WriteLine("Відповідь: " + R);
                Console.ReadLine();
            }
        }
    }
}

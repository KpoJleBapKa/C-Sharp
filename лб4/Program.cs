using System;
//Даний масив цілих чисел розміру N. Вивести спочатку всі його парні (непарні) елементи, а потім — непарні (парні). 
namespace лб4
{
    class Program
    {
        static void Main(string[] args)
        {
            string kroll = "0";
            int bob = Convert.ToInt32(kroll);
            string num = "0";
            int i = Convert.ToInt32(num);
            string N = "10";
            int arr = Convert.ToInt32(N);
            int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Непарні: ");
            for (i = 0; i < 5; i++)
            {
                if (i == 5)
                {
                    break;
                }
                else if (bob <= 10)
                {
                    Console.WriteLine(nums[bob]);
                    bob += 2;
                }
            }
            bob = 1;
            Console.WriteLine("Парні: ");
            for (i = 0; i < 5; i++)
            {
                if (i == 5)
                {
                    break;
                }
                else if (bob <= 10)
                {
                    Console.WriteLine(nums[bob]);
                    bob += 2;
                }
            }

        }
    }
}

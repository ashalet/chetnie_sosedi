using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задана последовательность целых чисел.
//Подсчитать количество элементов, у которых четные соседи.

namespace chetnie_sosedi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа через пробел: ");
            string str = " ";
            str = Console.ReadLine();
            var array = Array.ConvertAll(str.Split(' '), s => int.Parse(s));
            int Length_array = array.Length;
            int count = 0;


            for (int i = 1; i < Length_array - 1; i++)
            {
                if (array[i - 1] % 2 == 0 && array[i + 1] % 2 == 0)
                {
                    count++;
                }
            }
            if (array[1] % 2 == 0) count++;
            if (array[Length_array - 2] % 2 == 0) count++;

            
            Console.WriteLine($"Ответ: {count}");
            Console.ReadLine();
        }
    }
}

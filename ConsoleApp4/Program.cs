using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполните массив действительными числами с помощью генератора случайных чисел(N элементов).
            //Нас интересуют только числа массива, находящиеся в диапазоне -100 до 100, выведете:
            //1) количество чисел диапазона
            //2) сумму отрицательных чисел диапазона
            //3) сумму положительных чисел диапазона

            int min = -100, nol = 0, max = 100, x = 0, y = 0, neg = 0, pol = 0, rmin = -300, rmax = 300;
            //min - Минимальное число диапазона, nol - Ноль, max - Максимальное число диапазона, x - длинна главного массива, y - Количество чисел диапазона,
            //neg - сумма отрицательных чисел диапазона, pol - сумма положительных чисел диапазона, rmin - минимальное число рандома, rmax - максимальное число рандома

            do                                                                                  //Защита от поломки из-за букв
            {
                Console.WriteLine("Введите количество элементов массива ");
                if (masstrue() > 0)
                    break;
            } while (true);

            int[] array = new int[x];                                                           //главный массив 
            Random random = new();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(rmin, rmax);
                //Console.Write(array[i] + " ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] >= min) && (array[i] <= max))                                     //подсчёт количества чисел диапазона
                    y++;

                if ((array[i] < nol) && (array[i] >= min))                                     //подсчёт суммы отрицательных чисел
                    neg += array[i];

                if ((array[i] >= nol) && (array[i] <= max))                                     //подсчёт суммы положительных чисел
                    pol += array[i];
            }

            Console.WriteLine("Сумма отрицательных чисел: " + neg);
            Console.WriteLine("Сумма положительных чисел: " + pol);
            Console.WriteLine("Количество чисел диапазона " + y);

            var count = array.Count(x => x >= min && x <= max);
            var neg1 = array.Where(x => x < nol && x >= min);

            static int masstrue()
            {
                int x = 0;
                bool result = int.TryParse(Console.ReadLine(), out x);
                if (result == false)
                    Console.WriteLine("Вводите цыфры, не буквы!");
                return x;
            }
        }
    }
}

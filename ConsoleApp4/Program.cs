using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать массив класса People(Guid, Дата рождения, Возраст) и заполнить его 100 случайными значениями.
            // Создать метод, который перенесет из него элементы несовершеннолетних людей в отдельный массив.
            // Вывести оба массива в консоль.
            // Примечание: совершеннолетие - старше 16 лет.

            int[] array = new int[100];                                                    //все возраста
            int[] array16 = new int[100];                                                  //старше 16
            Guid[] name = new Guid[100];
            DateTime[] arrayDATE = new DateTime[100];


            Random random = new();

            for (int i = 0; i < array.Length; i++)                                         //цикл создания даты рождения
            {
                DateTime startDate = new(1922, 1, 1);
                DateTime newDate = startDate.AddDays(random.Next(36500));
                DateTime today = DateTime.Today;

                People.guid = Guid.NewGuid();

                arrayDATE[i] = newDate;

                int age = today.Year - newDate.Year;                                       //вычисление возраста
                if (newDate.AddYears(age) > today)
                {
                    age--;
                }

                name[i] = People.guid;
                array[i] = age;
                Console.WriteLine(People.guid + " " + newDate + " " + age);
            }

            for (int i = 0; i < array16.Length; i++)
            {
                if (array[i] > 16)
                {
                    array16[i] = array[i];
                }
            }

            Console.WriteLine("|");

            for (int i = 0; i < array16.Length; i++)                                       //вывод > 16
            {

                if (array[i] > 16)
                {
                    array16[i] = array[i];
                    Console.WriteLine(name[i] + " " + arrayDATE[i] + " " + array16[i]);
                }

            }
            Console.ReadKey();
        }

        public class People
        {
            public Guid Guid { get; set; }
            public DateTime Birth { get; set; }
        }
    }
}
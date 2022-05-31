using System;
using System.Collections.Generic;
using System.Linq;

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

            Random random = new();
            People[] people = new People[100];

            for (int i = 0; i < people.Length; i++)
            {
                var d = DateTime.Now.AddDays(-random.Next(36672));
                people[i] = new People
                {
                    Guid = Guid.NewGuid(),
                    Birth = d,
                    Age = DateTime.Now.Year - d.Year,
                };
            }
            PrintArray(FillArray(people));
        }
        static People[] FillArray(People[] people)
        {
            List<People> result = new List<People>();
            List<People> kids = new List<People>();
            foreach (People p in people)
            {
                if (p.Age > 16)
                {
                    result.Add(p);
                }
                else
                {
                    kids.Add(p);
                }
            }
            result = result.Union(kids).ToList();
            return  result.ToArray();
        }

        static void PrintArray(People[] people)
        {
            foreach(People p in people)
            {
                Console.WriteLine(p.Guid + " | " + p.Birth + " | " + p.Age);
            }
        }

public class People
        {
            public Guid Guid { get; set; }
            public DateTime Birth { get; set; }
            public int Age { get; set; }
        }
    }
}
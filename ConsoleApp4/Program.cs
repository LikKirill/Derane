// Создать массив класса People(Guid, Дата рождения, Возраст) и заполнить его 100 случайными значениями.
// Создать метод, который перенесет из него элементы несовершеннолетних людей в отдельный массив.
// Вывести оба массива в консоль.
// Примечание: совершеннолетие - старше 16 лет.


Random random = new();
People[] people = new People[100];

for (int i = 0; i < 100; i++)                                         //цикл создания даты рождения, guid, вычисление возраста.
{
    
    DateOnly startDate = new(1922, 1, 1);
    DateOnly newDate = startDate.AddDays(random.Next(36672));
    DateOnly today = DateOnly.FromDateTime(DateTime.Now);

    people[i] = new People();

    int age = today.Year - newDate.Year;                                       //вычисление возраста
    if (newDate.AddYears(age) > today)                                         //как работает:  возраст(age) = сегодняшний год(today.Year) - год сгенерированной даты(newDate.Year)
    {                                                                          //если ( сгенерированная дата(newDate) + возраст(age) ) больше (>) сегодняшняя дата(today)
        age--;                                                                 //возраст(age)--.
    }

    people[i].Guid = Guid.NewGuid();
    people[i].Birth = newDate;
    people[i].Age = age;

    

    Console.WriteLine(people[i].Guid + " | " + people[i].Birth + " | " + people[i].Age);
   
}

//for (int i = 0; i < 100; i++)
//    {
//        int getsix()
//    {
//        int psixteen = 0;
//        if (people[i].Age > 16)
//        {
//            psixteen = people[i].Age;
//        }
//        return psixteen;
//    }
//        Console.WriteLine(getsix);
//    }
public class People
{
    public Guid Guid { get; set; }
    public DateOnly Birth { get; set; } 
    public int Age { get; set; }
}
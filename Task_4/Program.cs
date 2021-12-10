using System;
//Создайте класс, который  будет  содержать  информацию  о  дате  (день, месяц, год).  С помощью 
//механизма  перегрузки  операторов, определите  операцию  разности  двух  дат  (результат  в  виде 
//количества дней между датами), а также операцию увеличения даты на определенное количество дней. 

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate date1 = new MyDate(DateTime.Now);
            Console.WriteLine(date1.ToString());

            MyDate date2 = new MyDate(new DateTime(2021, 11, 29));
            Console.WriteLine(date2.ToString());

            Console.WriteLine("Разница в днях: " + (date1 - date2));
            Console.WriteLine("Прибавим к первой дате 23 дня\n" + (date1 + 23));

            // Delay.
            Console.ReadKey();
        }
    }
}

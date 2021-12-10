using System;

namespace Task_4
{
    class MyDate
    {
        readonly DateTime date;

        public MyDate(DateTime date)
        {
            this.date = date;
        }

        public static int operator -(MyDate date1, MyDate date2)
        {
            TimeSpan timeSpan = date1.date - date2.date;
            return timeSpan.Days;
        }

        public static MyDate operator +(MyDate date1, int n)
        {
            DateTime newDate = date1.date.AddDays(n);
            return new MyDate(newDate);
        }


        public override string ToString()
        {
            return "Дата: " + date;
        }
    }
}

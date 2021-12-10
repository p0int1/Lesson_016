using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте  структуру  описывающую  точку  в  трехмерной  системе  координат.  Организуйте  возможность 
//сложения двух точек, через использование перегрузки оператора +. 

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1, 1);
            Point b = new Point(5, 6, 7);

            Point c = a + b;

            Console.WriteLine("Координаты точки с равны: " + c.X + " " + c.Y + " " + c.Z);

            // Delay.
            Console.ReadKey();
        }
    }
}

using System;
//Создайте класс Block с 4-мя полями сторон, переопределите в нем методы:  
//Equals – способный сравнивать блоки между собой,
//ToString – возвращающий информацию о полях блока.  

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Block a = new Block(1, 2, 3, 4);
            Block b = new Block(5, 6, 7, 8);
            Block c = new Block(1, 2, 3, 4);
            Block d = a.Clone();

            Console.WriteLine("объект: " + a.ToString() + " хешкод " + a.GetHashCode());
            Console.WriteLine("объект: " + b.ToString() + " хешкод " + b.GetHashCode());
            Console.WriteLine("объект: " + c.ToString() + " хешкод " + c.GetHashCode());
            Console.WriteLine("объект: " + d.ToString() + " хешкод " + d.GetHashCode());

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("a равно b = {0} ", a.Equals(b));
            Console.WriteLine("a равно c = {0} ", a.Equals(c));

            // Delay.
            Console.ReadKey();
        }
    }
}

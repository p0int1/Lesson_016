using System;
//Создайте класс House c двумя полями и свойствами.  
//Создайте  два  метода  Clone()  и DeepClone(),  которые выполняют  поверхностное  и  глубокое 
//копирование соответственно. Реализуйте простой способ проверки. 

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new House("Героев", "87");

            House clone;
            //clone = house.Clone();
            clone = house.DeepClone();

            Console.WriteLine("Original: {0}, {1}", house.Street, house.Number);
            Console.WriteLine("Clone   : {0}, {1}", clone.Street, clone.Number);
            Console.WriteLine(new string('-', 50));

            clone.Street = "Яворницкого";
            clone.Number = "76 В";

            Console.WriteLine("Original: {0}, {1}", house.Street, house.Number);
            Console.WriteLine("Clone   : {0}, {1}", clone.Street, clone.Number);

            // Delay.
            Console.ReadKey();
        }
    }
}

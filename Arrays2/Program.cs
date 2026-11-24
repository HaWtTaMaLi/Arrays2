using System;

namespace Arrays2
{
    internal class Program
    {
        static string[] fruit = {"Apple", "Banana", "Orange"};
        static int[] fruitOnHand = {0, 4, 23};
        static int currentFruit;

        static void Main()
        {
            Console.WriteLine("=== Arrays ===");
            Console.WriteLine("Fruit List: ");
            Console.WriteLine(fruit[0] + "   = " + fruitOnHand[0]);
            Console.WriteLine(fruit[1] + "  = " + fruitOnHand[1]);
            Console.WriteLine(fruit[2] + "  = " + fruitOnHand[2]);

            
            
        }
    }
}
